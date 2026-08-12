using PhongKham.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace PhongKham.Forms
{
    public partial class frmNhapXuatTon : Form
    {
        public frmNhapXuatTon()
        {
            InitializeComponent();
        }

        private LPsoft.Helpers.ucLookup ucSearchCD;
        private TextBox activeTextBox;
        private void frmNhapXuatTon_Load(object sender, EventArgs e)
        {
            DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
            loadNhomThuoc();

            ucSearchCD = new LPsoft.Helpers.ucLookup();
            this.Controls.Add(ucSearchCD);
            ucSearchCD.Visible = false;


            this.Controls.Add(ucSearchCD);
            ucSearchCD.Visible = false;
            ucSearchCD.BringToFront();

            // Xử lý khi chọn xong dữ liệu
            ucSearchCD.OnRowSelected += (row) =>
            {
                // Kiểm tra xem TextBox nào đang được ghi nhớ
                if (activeTextBox == txtTenThuoc)
                {
                    txtTenThuoc.Text = row["ten_thuoc"].ToString();
                    ucSearchCD.Visible = false;
                    DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
                }
                //else if (activeTextBox == txtDiaChi)
                //{
                //    // LƯU Ý: Phải viết đúng tên cột trong SQL (diachi)
                //    txtDiaChi.Text = row["diachi"].ToString();

                //    ucSearchCD.Visible = false;

                //    txtBacSi.Focus();
                //}
                ucSearchCD.Visible = false;
            };
        }

        private void loadNhomThuoc()
        {
            cboxNhomThuoc.DropDownWidth = 200;
            cboxNhomThuoc.DropDownHeight = 200;

            cboxNhomThuoc.DataSource = Helpers.MySqlHelper.ExecuteDataTable("SELECT DISTINCT nhom_thuoc FROM dm_thuoc");
            cboxNhomThuoc.DisplayMember = "nhom_thuoc";
            cboxNhomThuoc.ValueMember = "nhom_thuoc";
            cboxNhomThuoc.SelectedIndex = -1;
        }

        private void loadDanhSachNhapXuatton()
        {
            string query = @"
SELECT 
    t1.ma_thuoc,
    t1.ten_thuoc,
    t1.hoat_chat,
    t1.nhom_thuoc,
    t1.don_vi_le,
    v1.lsx,
    v1.hsd,
    v1.so_nhap,
    v1.so_xuat,
    v1.ton_kho,
    v1.ngay_nhap ,
    v1.ngay_xuat
    
FROM
    dm_thuoc t1
        JOIN
    vw_ton_kho v1 ON t1.ma_thuoc = v1.ma_thuoc
WHERE
    v1.ngay_nhap >= @tungay 
        AND (v1.ngay_xuat < @denngay 
        OR v1.ngay_xuat IS NULL)
        and t1.ten_thuoc like @tenthuoc
        AND t1.nhom_thuoc like @nhomthuoc 
order by t1.nhom_thuoc asc;
";

            dgvNhapXuatTon.DataSource = Helpers.MySqlHelper.ExecuteDataTable(query,
                new MySqlParameter("@tungay", dtpTuNgay.Value.Date),
                new MySqlParameter("@denngay", dtpDenNgay.Value.Date.AddDays(1)),
                new MySqlParameter("@tenthuoc", "%" + txtTenThuoc.Text.Trim() + "%"),
                new MySqlParameter("@nhomthuoc", "%" + cboxNhomThuoc.Text.Trim() + "%")
                );
            dgvNhapXuatTon.AutoGenerateColumns = false;
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export.ExportExcel(dgvNhapXuatTon);
        }

        private void cboxNhomThuoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
        }

        private void cboxNhomThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
        }

        private void cboxNhomThuoc_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
        }

        private void cboxNhomThuoc_TextChanged(object sender, EventArgs e)
        {
            if (cboxNhomThuoc.SelectedIndex == -1)
            {
                DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
            }
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            if(txtTenThuoc.Text == "")
            {
                ucSearchCD.Visible = false;
                DebounceManager.Execute("LoaNhapXuatTon", 100, loadDanhSachNhapXuatton);
                return;
            }
            activeTextBox = txtTenThuoc;
            string tenThuoc = "%" + txtTenThuoc.Text.Trim() + "%";

            if (string.IsNullOrEmpty(txtTenThuoc.Text.Trim()))
            {
                ucSearchCD.Visible = false;
                return;
            }

            DataTable dtTenThuoc = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT ten_thuoc, hoat_chat FROM dm_thuoc where 
        (ten_thuoc LIKE @ten_thuoc OR hoat_chat LIKE @ten_thuoc)
        order by ten_thuoc asc",
                new MySqlParameter("@ten_thuoc", tenThuoc)
            );

            if (dtTenThuoc != null && dtTenThuoc.Rows.Count > 0)
            {
                // 1. Điền dữ liệu và định dạng
                var widths = new Dictionary<string, int> { { "ten_thuoc", 400 },{"hoat_chat",400 } };
                //var formats = new Dictionary<string, string> { { "Gia", "#,###" } };
                ucSearchCD.FillData(dtTenThuoc, widths, null);

                // 2. TÍNH TOÁN VỊ TRÍ ĐỂ VẼ NGAY DƯỚI TEXTBOX
                // Lấy tọa độ của TextBox so với Form chính (bất kể nó nằm trong Panel nào)
                Point locationOnForm = txtTenThuoc.Parent.PointToScreen(txtTenThuoc.Location);
                locationOnForm = this.PointToClient(locationOnForm);

                ucSearchCD.Left = locationOnForm.X;
                ucSearchCD.Top = locationOnForm.Y + txtTenThuoc.Height;
                ucSearchCD.Width = 800; // Độ rộng của bảng kết quả
                ucSearchCD.Height = 150; // Chiều cao của bảng kết quả

                ucSearchCD.Visible = true;
                ucSearchCD.BringToFront();
            }
            else
            {
                ucSearchCD.Visible = false;
            }
        }

        private void txtTenThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (ucSearchCD != null && ucSearchCD.Visible)
            {
                ucSearchCD.HandleKeyDown(e);
            }
        }
    }
}
