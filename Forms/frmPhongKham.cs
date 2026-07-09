using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace NhaThuoc_BSPhong.Forms
{
    public partial class frmPhongKham : Form
    {
        public frmPhongKham()
        {
            InitializeComponent();
        }

        private LPsoft.Helpers.ucLookup ucSearchCD;
        private TextBox activeTextBox;

        string ma_thuoc = "";

        private void frmPhongKham_Load(object sender, EventArgs e)
        {

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
                if (activeTextBox == txtTimThuocUong)
                {
                    ma_thuoc = row["ma_thuoc"].ToString();
                    txtTimThuocUong.Text = row["ten_thuoc"].ToString();
                    ucSearchCD.Visible = false;

                    txtSoLuong.Focus();

                }
                else if (activeTextBox == txtCachDung)
                {
                    txtCachDung.Text = row["Cách dùng"].ToString();

                    ucSearchCD.Visible = false;

                    btnThemThuocUong.Focus();
                }
                ucSearchCD.Visible = false;
            };

            Helpers.DebounceManager.Execute("TimBenhNhan", 100, loadDanhSachBN);

        }

        private void loadDanhSachBN()
        {
            string ho_ten = "%" + txtTimHoTen.Text.Trim() + "%";

            string rdoFilter = rdoTatCa.Checked ? "" : (rdoDaKham.Checked ? "AND da_kham = '1'" : "AND (da_kham IS NULL OR da_kham = '0')");


            dgvTimBenhNhan.DataSource = Helpers.MySqlHelper.ExecuteDataTable($@"
SELECT 
    ma_bn,
    ho_ten,
    tuoi,
    phai,
    dia_chi,
    sdt,
    da_kham,
    khoa,
    date_in
FROM
    tbl_bn
WHERE
    date_in >= @TuNgay
        AND date_in < @DenNgay
        AND ho_ten LIKE @ho_ten
        AND delete_at IS NULL
        {rdoFilter} 
ORDER BY date_in , ma_bn ASC;",
new MySqlParameter("@ho_ten", ho_ten),
new MySqlParameter("@TuNgay", dtpTuNgay.Value.Date),
new MySqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1))
);
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("TimBenhNhan", 100, loadDanhSachBN);
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("TimBenhNhan", 100, loadDanhSachBN);
        }

        private void txtTimHoTen_TextChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("TimBenhNhan", 100, loadDanhSachBN);
        }

        private void rdoTatCa_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("TimBenhNhan", 100, loadDanhSachBN);
        }

        private void rdoDaKham_CheckedChanged(object sender, EventArgs e)
        {
            loadDanhSachBN();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            xoaThongTinTrenManHinh();
            taoBenhNhanMoi();
            themToaThuocUong();
            Helpers.DebounceManager.Execute("loadToaThuocUong", 100, loadToaThuocUongChiTiet);
        }
        private void loadToaThuocUongChiTiet()
        {
            dgvToaThuocUong.DataSource = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT 
                    ma_bn,
                    ma_toa,
                    ma_thuoc,
                    ten_thuoc,
                    ham_luong,
                    cach_dung,
                    so_luong,
                    don_gia,
                    thanh_tien
                FROM
                    tbl_tu_ct
                WHERE ma_bn = @ma_bn AND ma_toa = @ma_toa AND 
                    delete_at IS NULL;",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
                new MySqlParameter("@ma_toa", cboxToaThuocUong.SelectedValue)
            );
        }
        private void xoaThongTinTrenManHinh()
        {
            txtMaBN.Clear();
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtDiaChi.Clear();
            cbxGioiTinh.SelectedIndex = -1;
            txtSDT.Clear();
            txtChanDoan.Clear();
            txtGhiChu.Clear();
            dtpNgayHenTaiKham.Value = DateTime.Now;
        }

        private void taoBenhNhanMoi()
        {
            object? result =
                Helpers.MySqlHelper.ExecuteScalar(
                    @"SELECT IFNULL(MAX(ma_bn),0)
              FROM tbl_bn");

            int maBNMoi = Convert.ToInt32(result) + 1;

            Helpers.MySqlHelper.ExecuteNonQuery(
                @"INSERT INTO tbl_bn (ma_bn,date_in)
          VALUES (@ma_bn,now())",
                new MySqlParameter("@ma_bn", maBNMoi));

            txtMaBN.Text = maBNMoi.ToString();
            txtHoTen.Focus();
        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capNhatThongTinBN();
            Helpers.DebounceManager.Execute("TimBenhNhan", 100, loadDanhSachBN);
            MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void capNhatThongTinBN()
        {
            string sql = @"UPDATE tbl_bn set 
                ho_ten = @ho_ten,
                tuoi = @tuoi,
                phai = @phai,
                dia_chi = @dia_chi, SDT = @SDT 
            WHERE ma_bn = @ma_bn";

            Helpers.MySqlHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@ho_ten", txtHoTen.Text.Trim()),
                new MySqlParameter("@tuoi", txtNamSinh.Text.Trim()),
                new MySqlParameter("@phai", cbxGioiTinh.Text.Trim()),
                new MySqlParameter("@dia_chi", txtDiaChi.Text.Trim()),
                new MySqlParameter("@SDT", txtSDT.Text.Trim()),
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim())
            );
        }


        private void dgvTimBenhNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            loadThongTinBN();

            // load danh sách toa thuốc uống
            cboxToaThuocUong.DataSource = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT ma_toa from tbl_tu where ma_bn = @ma_bn order by ma_toa desc;",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()));

            cboxToaThuocUong.DisplayMember = "ma_toa";
            cboxToaThuocUong.ValueMember = "ma_toa";
            cboxToaThuocUong.SelectedIndex = 0;
        }

        private void loadThongTinBN()
        {
            txtMaBN.Text = dgvTimBenhNhan.CurrentRow.Cells["colMaBN"].Value.ToString();
            txtHoTen.Text = dgvTimBenhNhan.CurrentRow.Cells["colHoTen"].Value.ToString();
            txtNamSinh.Text = dgvTimBenhNhan.CurrentRow.Cells["colNamSinh"].Value.ToString();
            cbxGioiTinh.Text = dgvTimBenhNhan.CurrentRow.Cells["colPhai"].Value.ToString();
            txtDiaChi.Text = dgvTimBenhNhan.CurrentRow.Cells["colDiaChi"].Value.ToString();
            txtSDT.Text = dgvTimBenhNhan.CurrentRow.Cells["colsdt"].Value.ToString();

            chkDaKham.Checked =
                Convert.ToInt32(
                    dgvTimBenhNhan.CurrentRow.Cells["colDaKham"].Value ?? 0
                ) == 1;

            chkKhoaBenh.Checked =
                            Convert.ToInt32(
                                dgvTimBenhNhan.CurrentRow.Cells["colKhoa"].Value ?? 0
                            ) == 1;

            dtpNgayNhap.Value = Convert.ToDateTime(dgvTimBenhNhan.CurrentRow.Cells["colNgayNhap"].Value);

        }

        private void loadToaThuocUong()
        {

        }

        private void frmPhongKham_LocationChanged(object sender, EventArgs e)
        {

        }

        private void btnThemToaThuocUong_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân trước khi thêm toa thuốc uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            themToaThuocUong();
        }

        private void themToaThuocUong()
        {
            object? result =
                Helpers.MySqlHelper.ExecuteScalar(
                    @"SELECT IFNULL(MAX(ma_toa),0)
              FROM tbl_tu where ma_bn = @ma_bn",
                    new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()));

            int ma_toa_moi = Convert.ToInt32(result) + 1;

            Helpers.MySqlHelper.ExecuteNonQuery(
                @"INSERT INTO tbl_tu (ma_bn,ma_toa,date_in)
          VALUES (@ma_bn,@ma_toa_moi,now())",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
                new MySqlParameter("@ma_toa_moi", ma_toa_moi));

            cboxToaThuocUong.DataSource = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT ma_toa from tbl_tu where ma_bn = @ma_bn order by ma_toa desc;",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()));

            cboxToaThuocUong.DisplayMember = "ma_toa";
            cboxToaThuocUong.ValueMember = "ma_toa";
            cboxToaThuocUong.SelectedIndex = 0;
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNamSinh.Focus();
            }
        }

        private void txtNamSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxGioiTinh.DroppedDown = true;
                cbxGioiTinh.Focus();
            }
        }

        private void cbxGioiTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSDT.Focus();
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapNhat.Focus();
            }
        }

        private void txtTimThuocUong_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = txtTimThuocUong;
            string timThuocUong = "%" + txtTimThuocUong.Text.Trim() + "%";

            if (string.IsNullOrEmpty(txtTimThuocUong.Text.Trim()))
            {
                ucSearchCD.Visible = false;
                return;
            }

            DataTable dtTimThuocUong = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT
    ma_thuoc,
    ten_thuoc ,
    hoat_chat,
    ham_luong,
    gia_ban
FROM dm_thuoc
WHERE
    (ten_thuoc like @ten_thuoc
     OR hoat_chat like @ten_thuoc)
    AND nhom_thuoc <> 'Thuốc tiêm '
ORDER BY ten_thuoc ASC;",
                new MySqlParameter("@ten_thuoc", timThuocUong)
            );

            if (dtTimThuocUong != null && dtTimThuocUong.Rows.Count > 0)
            {
                // 1. Điền dữ liệu và định dạng
                var widths = new Dictionary<string, int> { { "ten_thuoc", 100 }, { "hoat_chat", 400 } };
                //var formats = new Dictionary<string, string> { { "Gia", "#,###" } };
                ucSearchCD.FillData(dtTimThuocUong, widths, null);

                // 2. TÍNH TOÁN VỊ TRÍ ĐỂ VẼ NGAY DƯỚI TEXTBOX
                // Lấy tọa độ của TextBox so với Form chính (bất kể nó nằm trong Panel nào)
                Point locationOnForm = txtTimThuocUong.Parent.PointToScreen(txtTimThuocUong.Location);
                locationOnForm = this.PointToClient(locationOnForm);

                ucSearchCD.Left = locationOnForm.X;
                ucSearchCD.Top = locationOnForm.Y + txtTimThuocUong.Height;
                ucSearchCD.Width = 500; // Độ rộng của bảng kết quả
                ucSearchCD.Height = 150; // Chiều cao của bảng kết quả

                ucSearchCD.Visible = true;
                ucSearchCD.BringToFront();
            }
            else
            {
                ucSearchCD.Visible = false;
            }
        }

        private void txtTimThuocUong_KeyDown(object sender, KeyEventArgs e)
        {
            if (ucSearchCD != null && ucSearchCD.Visible)
            {
                ucSearchCD.HandleKeyDown(e);
            }
        }

        private void txtCachDung_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = txtCachDung;
            string cachDung = "%" + txtCachDung.Text.Trim() + "%";

            if (string.IsNullOrEmpty(txtCachDung.Text.Trim()))
            {
                ucSearchCD.Visible = false;
                return;
            }

            DataTable dtCachDung = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT cach_dung as 'Cách dùng' from dm_cach_dung where cach_dung like @cach_dung",
                new MySqlParameter("@cach_dung", cachDung)
            );

            if (dtCachDung != null && dtCachDung.Rows.Count > 0)
            {
                // 1. Điền dữ liệu và định dạng
                var widths = new Dictionary<string, int> { { "Cách dùng", 500 } };
                //var formats = new Dictionary<string, string> { { "Gia", "#,###" } };
                ucSearchCD.FillData(dtCachDung, widths, null);

                // 2. TÍNH TOÁN VỊ TRÍ ĐỂ VẼ NGAY DƯỚI TEXTBOX
                // Lấy tọa độ của TextBox so với Form chính (bất kể nó nằm trong Panel nào)
                Point locationOnForm = txtCachDung.Parent.PointToScreen(txtCachDung.Location);
                locationOnForm = this.PointToClient(locationOnForm);

                ucSearchCD.Left = locationOnForm.X;
                ucSearchCD.Top = locationOnForm.Y + txtCachDung.Height;
                ucSearchCD.Width = 500; // Độ rộng của bảng kết quả
                ucSearchCD.Height = 150; // Chiều cao của bảng kết quả

                ucSearchCD.Visible = true;
                ucSearchCD.BringToFront();
            }
            else
            {
                ucSearchCD.Visible = false;
            }
        }

        private void txtCachDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (ucSearchCD != null && ucSearchCD.Visible)
            {
                ucSearchCD.HandleKeyDown(e);
            }
        }

        private void btnThemThuocUong_Click(object sender, EventArgs e)
        {

        }
    }
}
