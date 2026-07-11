using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Export.PdfSimple;
using FastReport;
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
                    labelSoLuongTon.Text = row["ton_kho"].ToString();
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
                    hoat_chat,
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
            loadDanhSachToaThuocUong();
            loadChiTietToaThuocUong();
        }

        private void loadDanhSachToaThuocUong()
        {
            cboxToaThuocUong.DataSource = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT ma_toa from tbl_tu where ma_bn = @ma_bn order by ma_toa desc;",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()));

            cboxToaThuocUong.DisplayMember = "ma_toa";
            cboxToaThuocUong.ValueMember = "ma_toa";
            cboxToaThuocUong.SelectedIndex = 0;
        }

        private void loadChiTietToaThuocUong()
        {
            dgvToaThuocUong.DataSource = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT 
                    auto_id,
                    ma_bn,
                    ma_toa,
                    ma_thuoc,
                    ten_thuoc,
                    hoat_chat, 
                    ham_luong,
                    don_vi, 
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
            loadChiTietToaThuocUong();
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
    ten_thuoc,
    hoat_chat,
    ton_kho 
FROM vw_ton_kho 
WHERE
    (ten_thuoc like @ten_thuoc
     OR hoat_chat like @ten_thuoc) AND ton_kho > 0 
ORDER BY ten_thuoc ASC;",
                new MySqlParameter("@ten_thuoc", timThuocUong)
            );

            if (dtTimThuocUong != null && dtTimThuocUong.Rows.Count > 0)
            {
                // 1. Điền dữ liệu và định dạng
                var widths = new Dictionary<string, int> { { "ma_thuoc", 100 }, { "ten_thuoc", 400 }, { "hoat_chat", 400 }, { "ton_kho", 100 } };
                //var formats = new Dictionary<string, string> { { "Gia", "#,###" } };
                ucSearchCD.FillData(dtTimThuocUong, widths, null);

                // 2. TÍNH TOÁN VỊ TRÍ ĐỂ VẼ NGAY DƯỚI TEXTBOX
                // Lấy tọa độ của TextBox so với Form chính (bất kể nó nằm trong Panel nào)
                Point locationOnForm = txtTimThuocUong.Parent.PointToScreen(txtTimThuocUong.Location);
                locationOnForm = this.PointToClient(locationOnForm);

                ucSearchCD.Left = locationOnForm.X;
                ucSearchCD.Top = locationOnForm.Y + txtTimThuocUong.Height;
                ucSearchCD.Width = 1020; // Độ rộng của bảng kết quả
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
                ucSearchCD.Width = 520; // Độ rộng của bảng kết quả
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
            themThuocUong();
            txtTimThuocUong.Clear();
            labelSoLuongTon.Text = "0";
            txtSoLuong.Clear();
            loadChiTietToaThuocUong();
        }

        private void themThuocUong()
        {
            if (string.IsNullOrWhiteSpace(txtTimThuocUong.Text))
            {
                MessageBox.Show("Vui lòng chọn thuốc uống trước khi thêm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTimThuocUong.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoLuong.Focus();
                return;
            }

            string sql = @"
    INSERT INTO tbl_tu_ct
    (
        ma_bn,
        ma_toa,
        ma_thuoc,
        ten_thuoc,
        hoat_chat,
        ham_luong,
        don_vi,
        cach_dung,
        so_luong,
        don_gia,
        thanh_tien
    )
    SELECT
        @ma_bn,
        @ma_toa,
        dm.ma_thuoc,
        dm.ten_thuoc,
        dm.hoat_chat,
        dm.ham_luong,
        dm.don_vi,
        @cach_dung,
        @so_luong,
        dm.gia_ban,
        dm.gia_ban * @so_luong
    FROM dm_thuoc dm
    WHERE dm.ma_thuoc = @ma_thuoc;";

            Helpers.MySqlHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
                new MySqlParameter("@ma_toa", cboxToaThuocUong.SelectedValue),
                new MySqlParameter("@ma_thuoc", ma_thuoc),
                new MySqlParameter("@cach_dung", txtCachDung.Text.Trim()),
                new MySqlParameter("@so_luong", soLuong)
            );
        }

        private void txtNgayHenTaiKham_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNgayHenTaiKham.Text.Trim(), out int ngayHen))
            {
                dtpNgayHenTaiKham.Value = DateTime.Today.AddDays(ngayHen);
            }
        }

        private void cboxToaThuocUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadToaThuocUongChiTiet();
        }

        private void cboxToaThuocUong_TextUpdate(object sender, EventArgs e)
        {
        }

        private void cboxToaThuocUong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadToaThuocUongChiTiet();
        }

        private void btnInToaThuocUong_Click(object sender, EventArgs e)
        {
            inToaThuocUong();
        }

        private void inToaThuocUong()
        {
            Helpers.MySqlHelper.DownloadReportFile(
                1,
                @"report.frx");

            Report report = new Report();
            report.Load(@"report.frx");

            report.SetParameterValue("paraHoTen", txtHoTen.Text.Trim());
            report.SetParameterValue("paraTuoi", txtNamSinh.Text.Trim());
            report.SetParameterValue("paraDiaChi", txtDiaChi.Text.Trim());
            report.SetParameterValue("paraGioiTinh", cbxGioiTinh.Text.Trim());
            report.SetParameterValue("paraChanDoan", txtChanDoan.Text.Trim());
            report.SetParameterValue("paraGhiChu", txtGhiChu.Text.Trim());


            report.SetParameterValue("paraHenTaiKham",
                dtpNgayHenTaiKham.Value.ToString("dd/MM/yyyy"));

            DataTable dt = taoDataInToaThuocUong();
            dt.TableName = "ToaThuocUong";

            report.RegisterData(dt, "ToaThuocUong");

            DataBand data = report.FindObject("Data1") as DataBand;
            if (data != null)
            {
                data.DataSource =
                    report.GetDataSource("ToaThuocUong");
            }

            report.GetDataSource("ToaThuocUong").Enabled = true;

            report.Prepare();

            string tenFile = $"ToaThuoc.pdf";
            string filePdf = Path.Combine(
                Application.StartupPath,
                "temp",
                tenFile);

            Directory.CreateDirectory(
                Path.GetDirectoryName(filePdf));

            PDFSimpleExport pdf = new PDFSimpleExport();

            report.Export(pdf, filePdf);

            Process.Start(new ProcessStartInfo
            {
                FileName = filePdf,
                UseShellExecute = true
            });
        }
        private DataTable taoDataInToaThuocUong()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("stt");
            dt.Columns.Add("ten_thuoc");
            dt.Columns.Add("ham_luong");
            dt.Columns.Add("cach_dung");
            dt.Columns.Add("so_luong");

            int stt = 1;

            foreach (DataGridViewRow row in dgvToaThuocUong.Rows)
            {
                if (row.IsNewRow) continue;

                dt.Rows.Add(
                    stt++,
                    row.Cells["colTenThuoc"].Value,
                    row.Cells["colHamLuong"].Value,
                    row.Cells["colCachDung"].Value,
                    row.Cells["colSoLuong"].Value
                );
            }
            return dt;
        }

        private void btnXoaThuocUong_Click(object sender, EventArgs e)
        {
            xoaThuocToaUong();
        }

        private void xoaThuocToaUong()
        {
            try
            {
                List<(int AutoId, string MaPhieu, string MaThuoc)> dsCanXoa = new();

                foreach (DataGridViewRow row in dgvToaThuocUong.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    bool isChecked = false;

                    if (row.Cells["colSelect"].Value != null)
                        bool.TryParse(row.Cells["colSelect"].Value.ToString(), out isChecked);

                    if (!isChecked)
                        continue;

                    int autoId = Convert.ToInt32(row.Cells["colAuto_id"].Value);
                    string maPhieu = row.Cells["colMaToa"].Value?.ToString();
                    string maThuoc = row.Cells["colMaThuoc"].Value?.ToString();

                    dsCanXoa.Add((autoId, maPhieu, maThuoc));
                }

                if (dsCanXoa.Count == 0)
                {
                    MessageBox.Show(
                        "Vui lòng chọn thuốc cần xóa.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show(
                    $"Bạn có chắc muốn xóa {dsCanXoa.Count} thuốc khỏi toa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                foreach (var item in dsCanXoa)
                {
                    Helpers.MySqlHelper.ExecuteNonQuery(
                        @"UPDATE tbl_tu_ct
                  SET delete_at = NOW()
                  WHERE auto_id = @auto_id
                    AND ma_toa = @ma_toa
                    AND ma_thuoc = @ma_thuoc
                    AND delete_at IS NULL",
                        new MySqlParameter("@auto_id", item.AutoId),
                        new MySqlParameter("@ma_toa", item.MaPhieu),
                        new MySqlParameter("@ma_thuoc", item.MaThuoc)
                    );
                }

                MessageBox.Show(
                    $"Đã xóa {dsCanXoa.Count} thuốc.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                loadChiTietToaThuocUong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaToa_Click(object sender, EventArgs e)
        {
            xoaToaThuocUong();
        }

        private void xoaToaThuocUong()
        {
            if (string.IsNullOrWhiteSpace(cboxToaThuocUong.Text))
            {
                MessageBox.Show(
                    "Chưa chọn toa cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                $"Bạn có chắc muốn xóa toa {cboxToaThuocUong.Text} ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // Xóa mềm chi tiết toa
                Helpers.MySqlHelper.ExecuteNonQuery(
                    @"UPDATE tbl_tu_ct
              SET delete_at = NOW()
              WHERE ma_toa = @ma_toa
                AND delete_at IS NULL",
                    new MySqlParameter("@ma_toa", cboxToaThuocUong.Text.Trim()));

                // Xóa mềm toa
                int rows = Helpers.MySqlHelper.ExecuteNonQuery(
                    @"UPDATE tbl_tu
              SET delete_at = NOW()
              WHERE ma_toa = @ma_toa
                AND delete_at IS NULL",
                    new MySqlParameter("@ma_toa", cboxToaThuocUong.Text.Trim()));

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Đã xóa toa thuốc.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Load lại danh sách
                    loadDanhSachToaThuocUong();
                    loadChiTietToaThuocUong();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy toa hoặc toa đã bị xóa.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCachDung.Focus();
            }
        }
    }
}
