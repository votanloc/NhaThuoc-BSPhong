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
using System.Globalization;

namespace PhongKham.Forms
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
        DateTime? hsd = null;
        string lsx = "";

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
                    txtTimThuocUong.Text = row["Tên thuốc"].ToString();
                    labelSoLuongTon.Text = row["Tồn kho"].ToString();
                    txtDonVi.Text = row["Đơn vị"].ToString();
                    txtCachDung.Text = row["cach_dung"].ToString();
                    if (row["HSD"] != DBNull.Value)
                        hsd = Convert.ToDateTime(row["HSD"]);
                    lsx = row["LSX"].ToString();
                    ucSearchCD.Visible = false;

                    txtNgayDung.Focus();

                }
                //else if (activeTextBox == txtCachDung)
                //{
                //    txtCachDung.Text = row["Cách dùng"].ToString();

                //    ucSearchCD.Visible = false;

                //    txtSoLuong.Focus();
                //}
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
            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(
    @"SELECT
        auto_id,
        ma_bn,
        ma_toa,
        ma_thuoc,
        ten_thuoc,
        hoat_chat,
        ham_luong,
        ngay_dung,
        sang,
        trua,
        chieu,
        toi,
        don_vi_le,
        cach_dung,
        so_luong,
        don_gia,
        thanh_tien,
        khong_lay,
        date_in 
      FROM tbl_tu_ct
      WHERE ma_bn=@ma_bn
        AND ma_toa=@ma_toa
        AND delete_at IS NULL",
    new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
    new MySqlParameter("@ma_toa", cboxToaThuocUong.Text.Trim())
);

            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show(
            //        $"Ngày dùng = {dt.Rows[0]["ngay_dung"]}\n" +
            //        $"Sáng = {dt.Rows[0]["sang"]}\n" +
            //        $"SL = {dt.Rows[0]["so_luong"]}");
            //}

            dgvToaThuocUong.DataSource = dt;
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
            loadThongTinToaThuocUong();
            loadToaThuocUongChiTiet();
            loadTongTienThuocUong();
        }

        private void loadTongTienThuocUong()
        {
            string maBN = txtMaBN.Text.Trim();
            string maToa = cboxToaThuocUong.Text.Trim();

            // Guard: thiếu thông tin thì set 0 và thoát
            if (string.IsNullOrEmpty(maBN) || string.IsNullOrEmpty(maToa))
            {
                txtTongTienThuocUong.Text = "0";
                return;
            }

            string sql = @"
        SELECT tong_tien
        FROM tbl_tu
        WHERE ma_bn = @ma_bn AND ma_toa = @ma_toa
        LIMIT 1;";

            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(
                sql,
                new MySqlParameter("@ma_bn", maBN),
                new MySqlParameter("@ma_toa", maToa)
            );

            decimal tongTien = 0m;

            if (dt.Rows.Count > 0 && dt.Rows[0]["tong_tien"] != DBNull.Value)
            {
                decimal.TryParse(
                    dt.Rows[0]["tong_tien"].ToString(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out tongTien
                );
            }

            // Hiển thị có phân tách hàng nghìn
            txtTongTienThuocUong.Text = tongTien.ToString("#,##0");
            //MessageBox.Show($"Tổng tiền thuốc uống: {tongTien.ToString("#,##0")} VND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal tinhTongTienThuocUong()
        {
            string maBN = txtMaBN.Text.Trim();
            string maToa = cboxToaThuocUong.Text.Trim();

            if (string.IsNullOrEmpty(maBN) || string.IsNullOrEmpty(maToa))
                return 0m;

            // 1) Tính tổng từ chi tiết toa uống
            string sqlSum = @"
        SELECT COALESCE(SUM(thanh_tien), 0) AS tong_tien
        FROM tbl_tu_ct
        WHERE ma_bn = @ma_bn
          AND ma_toa = @ma_toa
          AND delete_at IS NULL
          AND khong_lay = 0;";

            object objTongTien = Helpers.MySqlHelper.ExecuteScalar(
                sqlSum,
                new MySqlParameter("@ma_bn", maBN),
                new MySqlParameter("@ma_toa", maToa)
            );

            decimal tongTien = 0m;
            if (objTongTien != null && objTongTien != DBNull.Value)
            {
                decimal.TryParse(
                    objTongTien.ToString(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out tongTien
                );
            }

            // 2) Cập nhật lại tổng tiền vào bảng header tbl_tu
            string sqlUpdate = @"
        UPDATE tbl_tu
        SET tong_tien = @tong_tien
        WHERE ma_bn = @ma_bn AND ma_toa = @ma_toa;";

            Helpers.MySqlHelper.ExecuteNonQuery(
                sqlUpdate,
                new MySqlParameter("@tong_tien", tongTien),
                new MySqlParameter("@ma_bn", maBN),
                new MySqlParameter("@ma_toa", maToa)
            );

            return tongTien;
        }

        string auto_id_toa_uong = "";

        private void loadThongTinToaThuocUong()
        {
            string sql = @"
        SELECT 
            auto_id,
            chan_doan,
            ghi_chu,
            bac_si,
            tai_kham 
        FROM tbl_tu
        WHERE ma_bn = @ma_bn
          AND ma_toa = @ma_toa
          AND delete_at IS NULL
        LIMIT 1;";

            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(
                sql,
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
                new MySqlParameter("@ma_toa", cboxToaThuocUong.Text.Trim())
            );

            if (dt.Rows.Count == 0)
            {
                auto_id_toa_uong = "";

                txtChanDoan.Clear();
                txtGhiChu.Clear();
                cboxBacSi.SelectedIndex = -1;
                dtpNgayHenTaiKham.Value = DateTime.Now;
                return;
            }

            DataRow row = dt.Rows[0];

            auto_id_toa_uong = row["auto_id"].ToString();

            txtChanDoan.Text = row["chan_doan"]?.ToString() ?? "";
            txtGhiChu.Text = row["ghi_chu"]?.ToString() ?? "";
            cboxBacSi.Text = row["bac_si"]?.ToString() ?? "";

            if (row["tai_kham"] != DBNull.Value)
                dtpNgayHenTaiKham.Value = Convert.ToDateTime(row["tai_kham"]);
            else
                dtpNgayHenTaiKham.Value = DateTime.Now;
        }

        private void capNhatThongTinToaUong()
        {

            Helpers.MySqlHelper.ExecuteNonQuery(
                @"UPDATE tbl_tu
          SET
              chan_doan = @chan_doan,
              ghi_chu = @ghi_chu,
              bac_si = @bac_si,
              tai_kham = @tai_kham,
              date_in = NOW()
          WHERE auto_id = @auto_id",

                new MySqlParameter("@chan_doan", txtChanDoan.Text.Trim()),
                new MySqlParameter("@ghi_chu", txtGhiChu.Text.Trim()),
                new MySqlParameter("@bac_si", cboxBacSi.Text.Trim()),
                new MySqlParameter("@tai_kham", dtpNgayHenTaiKham.Value),
                new MySqlParameter("@auto_id", auto_id_toa_uong)
            );
        }

        // ===== PHƯƠNG PHÁP 1: Tính toán Local (NHANH NHẤT) =====
        private decimal TinhTongTienThuocUongLocal()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvToaThuocUong.Rows)
            {
                if (row.IsNewRow)
                    continue;

                // Kiểm tra không phải hàng xóa
                if (row.Cells["colKhongLay"].Value != null &&
                    Convert.ToBoolean(row.Cells["colKhongLay"].Value))
                    continue;

                if (decimal.TryParse(row.Cells["colThanhTien"].Value?.ToString() ?? "0", out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }

            txtTongTienThuocUong.Text = tongTien.ToString("#,##0");
            return tongTien;
        }

        // ===== PHƯƠNG PHÁP 2: Database (AN TOÀN HƠN) =====
        private bool CapNhatTongTienVaoDB(string maBN, string maToaUong)
        {
            try
            {
                // Tính tổng từ database
                object result = Helpers.MySqlHelper.ExecuteScalar(
                    @"SELECT COALESCE(SUM(thanh_tien), 0) 
              FROM tbl_tu_ct 
              WHERE ma_bn = @ma_bn 
                AND ma_toa = @ma_toa 
                AND delete_at IS NULL 
                AND khong_lay = 0",
                    new MySqlParameter("@ma_bn", maBN.Trim()),
                    new MySqlParameter("@ma_toa", maToaUong.Trim())
                );

                if (!decimal.TryParse(result?.ToString() ?? "0", out decimal tongTien))
                    tongTien = 0;

                // Cập nhật vào DB
                int rowsAffected = Helpers.MySqlHelper.ExecuteNonQuery(
                    @"UPDATE tbl_tu
              SET tong_tien = @tong_tien
              WHERE ma_bn = @ma_bn
                AND ma_toa = @ma_toa
                AND delete_at IS NULL",
                    new MySqlParameter("@tong_tien", tongTien),
                    new MySqlParameter("@ma_bn", maBN.Trim()),
                    new MySqlParameter("@ma_toa", maToaUong.Trim())
                );

                // Cập nhật UI
                txtTongTienThuocUong.Text = tongTien.ToString("#,##0");

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật tổng tiền: {ex.Message}", "Lỗi");
                return false;
            }
        }

        // ===== PHƯƠNG PHÁP 3: Batch Update (CHO NHIỀU TRECORD) =====
        private void CapNhatTongTienBatch(DataTable dtToaUong)
        {
            try
            {
                string sql = @"
            UPDATE tbl_tu t
            INNER JOIN (
                SELECT ma_bn, ma_toa, SUM(thanh_tien) as tong_tien
                FROM tbl_tu_ct
                WHERE delete_at IS NULL AND khong_lay = 0
                GROUP BY ma_bn, ma_toa
            ) ct ON t.ma_bn = ct.ma_bn AND t.ma_toa = ct.ma_toa
            SET t.tong_tien = ct.tong_tien
            WHERE t.ma_bn = @ma_bn AND t.ma_toa = @ma_toa";

                foreach (DataRow row in dtToaUong.Rows)
                {
                    Helpers.MySqlHelper.ExecuteNonQuery(sql,
                        new MySqlParameter("@ma_bn", row["ma_bn"]),
                        new MySqlParameter("@ma_toa", row["ma_toa"])
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật batch: {ex.Message}", "Lỗi");
            }
        }
        private void dgvToaThuocUong_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvToaThuocUong.IsCurrentCellDirty)
                dgvToaThuocUong.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvToaThuocUong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvToaThuocUong.Columns[e.ColumnIndex].Name != "colKhongLay")
                return;

            DataGridViewRow row = dgvToaThuocUong.Rows[e.RowIndex];

            Helpers.MySqlHelper.ExecuteNonQuery(
            @"UPDATE tbl_tu_ct
      SET
          khong_lay = @khong_lay,
          date_in = NOW()
      WHERE auto_id = @auto_id",

                new MySqlParameter("@khong_lay",
                    Convert.ToBoolean(row.Cells["colKhongLay"].Value ?? false)),

                new MySqlParameter("@auto_id",
                    row.Cells["colAuto_id"].Value)
            );

            capNhatThongTinToaUong();
        }


        private void loadDanhSachToaThuocUong()
        {
            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT ma_toa from tbl_tu where ma_bn = @ma_bn and delete_at is null order by ma_toa desc;",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()));

            cboxToaThuocUong.ComboBox.DisplayMember = "ma_toa";
            cboxToaThuocUong.ComboBox.ValueMember = "ma_toa";
            cboxToaThuocUong.ComboBox.DataSource = dt;
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
              FROM tbl_tu where ma_bn = @ma_bn and delete_at is null ",
                    new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()));

            int ma_toa_moi = Convert.ToInt32(result) + 1;

            Helpers.MySqlHelper.ExecuteNonQuery(
                @"INSERT INTO tbl_tu (ma_bn,ma_toa,date_in)
          VALUES (@ma_bn,@ma_toa_moi,now())",
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
                new MySqlParameter("@ma_toa_moi", ma_toa_moi));

            loadDanhSachToaThuocUong();
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
                @"
SELECT 
    t1.ma_thuoc,
    t1.ten_thuoc as 'Tên thuốc',
    t1.hoat_chat as 'Hoạt chất',
    t1.don_vi_le as 'Đơn vị',
    ROUND(t2.ton_kho, 0) AS 'Tồn kho',
    t1.cach_dung,
    t2.hsd as 'HSD',
    t2.lsx as 'LSX'
FROM
    dm_thuoc t1
        LEFT JOIN
    tbl_ton_kho t2 ON t1.ma_thuoc = t2.ma_thuoc
WHERE
    (ten_thuoc LIKE @ten_thuoc
        OR hoat_chat LIKE @ten_thuoc)
        AND t1.khoa = '0'
        AND t2.ton_kho > 0
ORDER BY t2.hsd ASC;",
                new MySqlParameter("@ten_thuoc", timThuocUong)
            );


            if (dtTimThuocUong != null && dtTimThuocUong.Rows.Count > 0)
            {
                var widths = new Dictionary<string, int> { { "ma_thuoc", 0 }, { "Tên thuốc", 300 }, { "Hoạt chất", 300 }, { "Đơn vị", 70 }, { "Tồn kho", 100 }, { "cach_dung", 0 }, { "HSD", 100 }, { "LSX", 0 } };

                var formats = new Dictionary<string, string> { { "HSD", "dd/MM/yyyy" } };

                ucSearchCD.FillData(dtTimThuocUong, widths, formats);

                Point locationOnForm = txtTimThuocUong.Parent.PointToScreen(txtTimThuocUong.Location);
                locationOnForm = this.PointToClient(locationOnForm);

                ucSearchCD.Left = locationOnForm.X;
                ucSearchCD.Top = locationOnForm.Y + txtTimThuocUong.Height;
                ucSearchCD.Width = 900; // Độ rộng của bảng kết quả
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
            //activeTextBox = txtCachDung;
            //string cachDung = "%" + txtCachDung.Text.Trim() + "%";

            //if (string.IsNullOrEmpty(txtCachDung.Text.Trim()))
            //{
            //    ucSearchCD.Visible = false;
            //    return;
            //}

            //DataTable dtCachDung = Helpers.MySqlHelper.ExecuteDataTable(
            //    @"SELECT cach_dung as 'Cách dùng' from dm_cach_dung where cach_dung like @cach_dung",
            //    new MySqlParameter("@cach_dung", cachDung)
            //);

            //if (dtCachDung != null && dtCachDung.Rows.Count > 0)
            //{
            //    // 1. Điền dữ liệu và định dạng
            //    var widths = new Dictionary<string, int> { { "Cách dùng", 500 } };
            //    //var formats = new Dictionary<string, string> { { "Gia", "#,###" } };
            //    ucSearchCD.FillData(dtCachDung, widths, null);

            //    // 2. TÍNH TOÁN VỊ TRÍ ĐỂ VẼ NGAY DƯỚI TEXTBOX
            //    // Lấy tọa độ của TextBox so với Form chính (bất kể nó nằm trong Panel nào)
            //    Point locationOnForm = txtCachDung.Parent.PointToScreen(txtCachDung.Location);
            //    locationOnForm = this.PointToClient(locationOnForm);

            //    ucSearchCD.Left = locationOnForm.X;
            //    ucSearchCD.Top = locationOnForm.Y + txtCachDung.Height;
            //    ucSearchCD.Width = 520; // Độ rộng của bảng kết quả
            //    ucSearchCD.Height = 150; // Chiều cao của bảng kết quả

            //    ucSearchCD.Visible = true;
            //    ucSearchCD.BringToFront();
            //}
            //else
            //{
            //    ucSearchCD.Visible = false;
            //}
        }

        private void txtCachDung_KeyDown(object sender, KeyEventArgs e)
        {
            //if (ucSearchCD != null && ucSearchCD.Visible)
            //{
            //    ucSearchCD.HandleKeyDown(e);
            //}

            if (e.KeyCode == Keys.Enter)
            {
                txtSoLuong.Focus();
            }
        }

        private void btnThemThuocUong_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimThuocUong.Text))
                {
                    MessageBox.Show("Vui lòng chọn thuốc uống!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double soLuong = ParseSoLuong(txtSoLuong.Text);
                double soLuongTon = ParseSoLuong(labelSoLuongTon.Text);

                if (soLuong <= 0 || soLuong > soLuongTon)
                {
                    MessageBox.Show("Số lượng không hợp lệ!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                themThuocUong();
                capNhatThongTinToaUong();
                loadToaThuocUongChiTiet();


                tinhTongTienThuocUong();
                loadTongTienThuocUong();
                txtTimThuocUong.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }
        private double ParseSoLuong(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            input = input.Trim().Replace(',', '.');

            // Hỗ trợ phân số: 1/2, 1/3...
            if (input.Contains("/"))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 2 &&
                    double.TryParse(parts[0], out double tu) &&
                    double.TryParse(parts[1], out double mau) &&
                    mau != 0)
                {
                    return tu / mau;
                }
            }

            // Hỗ trợ số thập phân
            if (double.TryParse(
                input,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double value))
            {
                return value;
            }

            return 0;
        }

        private void tinhToanSoLuongThuocXuat()
        {
            double soNgayDung = ParseSoLuong(txtNgayDung.Text);

            double soLuongSang = ParseSoLuong(txtSang.Text);
            double soLuongTrua = ParseSoLuong(txtTrua.Text);
            double soLuongChieu = ParseSoLuong(txtChieu.Text);
            double soLuongToi = ParseSoLuong(txtToi.Text);

            double tongSoLuong =
                (soLuongSang + soLuongTrua + soLuongChieu + soLuongToi) * soNgayDung;

            txtSoLuong.Text = tongSoLuong.ToString("0.##");
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
        ngay_dung,
        sang,
        trua,
        chieu,
        toi,
        don_vi_le,
        cach_dung,
        so_luong,
        don_gia,
        thanh_tien,
        hsd,
        lsx 
    )
    SELECT
        @ma_bn,
        @ma_toa,
        dm.ma_thuoc,
        dm.ten_thuoc,
        dm.hoat_chat,
        dm.ham_luong,
        @ngay_dung,
        @sang,
        @trua,
        @chieu,
        @toi,
        dm.don_vi_le,
        @cach_dung,
        @so_luong,
        dm.gia_ban,
        dm.gia_ban * @so_luong,
        @hsd,
        @lsx 
    FROM dm_thuoc dm
    WHERE dm.ma_thuoc = @ma_thuoc;";

            Helpers.MySqlHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@ma_bn", txtMaBN.Text.Trim()),
                new MySqlParameter("@ma_toa", cboxToaThuocUong.Text.Trim()),
                new MySqlParameter("@ma_thuoc", ma_thuoc),
                new MySqlParameter("@ngay_dung", txtNgayDung.Text.Trim()),
                new MySqlParameter("@sang", DecimalOrNull(txtSang.Text)),
                new MySqlParameter("@trua", DecimalOrNull(txtTrua.Text)),
                new MySqlParameter("@chieu", DecimalOrNull(txtChieu.Text)),
                new MySqlParameter("@toi", DecimalOrNull(txtToi.Text)),
                new MySqlParameter("@cach_dung", txtCachDung.Text.Trim()),
                new MySqlParameter("@so_luong", soLuong),
                new MySqlParameter("@hsd", hsd.HasValue ? hsd.Value : DBNull.Value),
                new MySqlParameter("@lsx", lsx)
            );
        }

        private object DecimalOrNull(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return DBNull.Value;

            return decimal.Parse(text);
        }

        private void txtNgayHenTaiKham_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNgayHenTaiKham.Text.Trim(), out int ngayHen))
            {
                dtpNgayHenTaiKham.Value = DateTime.Today.AddDays(ngayHen);
                txtNgayDung.Text = txtNgayHenTaiKham.Text.Trim();
            }
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
            report.SetParameterValue("paraBacSi", cboxBacSi.Text.Trim());
            DateTime ngay = DateTime.Now;

            report.SetParameterValue(
                "paraNgayInToa",
                $"Ngày {ngay:dd} tháng {ngay:MM} năm {ngay:yyyy}"
            );


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
            dt.Columns.Add("ngay_dung");
            dt.Columns.Add("lieu_dung");
            dt.Columns.Add("don_vi_le");
            dt.Columns.Add("so_luong");

            int stt = 1;

            foreach (DataGridViewRow row in dgvToaThuocUong.Rows)
            {
                if (row.IsNewRow) continue;

                // Không in thuốc đã check "Không lấy"
                bool khongLay = Convert.ToBoolean(row.Cells["colKhongLay"].Value ?? false);
                if (khongLay)
                    continue;

                string lieuDung = "";

                void ThemLieu(string ten, object value)
                {
                    if (decimal.TryParse(Convert.ToString(value), out decimal sl) && sl > 0)
                    {
                        if (lieuDung != "")
                            lieuDung += "   ";

                        lieuDung += $"{ten}: {sl:0.###}";
                    }
                }

                ThemLieu("Sáng", row.Cells["colSang"].Value);
                ThemLieu("Trưa", row.Cells["colTrua"].Value);
                ThemLieu("Chiều", row.Cells["colChieu"].Value);
                ThemLieu("Tối", row.Cells["colToi"].Value);


                string cachDung = Convert.ToString(row.Cells["colCachDung"].Value);

                if (!string.IsNullOrWhiteSpace(cachDung))
                {
                    if (!string.IsNullOrWhiteSpace(lieuDung))
                        lieuDung += "   ";

                    lieuDung += cachDung;
                }

                dt.Rows.Add(
                stt++,
                row.Cells["colTenThuoc"].Value,
                row.Cells["colHamLuong"].Value,
                row.Cells["colNgayDung"].Value,
                lieuDung,
                row.Cells["colDonViLe"].Value,
                FormatSoLuong(row.Cells["colSoLuong"].Value)
            );
            }

            return dt;
        }
        private string FormatSoLuong(object value)
        {
            if (!decimal.TryParse(Convert.ToString(value), out decimal sl))
                return "";

            return sl % 1 == 0
                ? sl.ToString("0")
                : sl.ToString("0.##");
        }
        private void btnXoaThuocUong_Click(object sender, EventArgs e)
        {
            xoaThuocToaUong();
            capNhatThongTinToaUong();

            tinhTongTienThuocUong();
            loadTongTienThuocUong();
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
                  WHERE auto_id = @auto_id",
                        new MySqlParameter("@auto_id", item.AutoId)
                    );
                }

                MessageBox.Show(
                    $"Đã xóa {dsCanXoa.Count} thuốc.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CapNhatTongTienVaoDB(txtMaBN.Text.Trim(), cboxToaThuocUong.Text.Trim());

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
                btnThemThuocUong.Focus();
            }
        }

        private void dgvToaThuocUong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvToaThuocUong.Rows[e.RowIndex];
            string colName = dgvToaThuocUong.Columns[e.ColumnIndex].Name;

            // Tính lại số lượng nếu sửa liều dùng
            if (colName == "colNgayDung" ||
                colName == "colSang" ||
                colName == "colTrua" ||
                colName == "colChieu" ||
                colName == "colToi")
            {
                double ngayDung = ParseSoLuong(row.Cells["colNgayDung"].Value?.ToString());
                double sang = ParseSoLuong(row.Cells["colSang"].Value?.ToString());
                double trua = ParseSoLuong(row.Cells["colTrua"].Value?.ToString());
                double chieu = ParseSoLuong(row.Cells["colChieu"].Value?.ToString());
                double toi = ParseSoLuong(row.Cells["colToi"].Value?.ToString());

                double soLuong = (sang + trua + chieu + toi) * ngayDung;

                row.Cells["colSoLuong"].Value = soLuong % 1 == 0
                    ? soLuong.ToString("0")
                    : soLuong.ToString("0.##");
            }

            // Lấy dữ liệu hiện tại
            double ngay_dung = ParseSoLuong(row.Cells["colNgayDung"].Value?.ToString());
            double sang1 = ParseSoLuong(row.Cells["colSang"].Value?.ToString());
            double trua1 = ParseSoLuong(row.Cells["colTrua"].Value?.ToString());
            double chieu1 = ParseSoLuong(row.Cells["colChieu"].Value?.ToString());
            double toi1 = ParseSoLuong(row.Cells["colToi"].Value?.ToString());
            double soLuong1 = ParseSoLuong(row.Cells["colSoLuong"].Value?.ToString());

            decimal.TryParse(Convert.ToString(row.Cells["colDonGia"].Value), out decimal donGia);
            decimal thanhTien = (decimal)soLuong1 * donGia;

            row.Cells["colThanhTien"].Value = thanhTien;

            Helpers.MySqlHelper.ExecuteNonQuery(
            @"UPDATE tbl_tu_ct
      SET
          ngay_dung = @ngay_dung,
          sang       = @sang,
          trua       = @trua,
          chieu      = @chieu,
          toi        = @toi,
          so_luong   = @so_luong,
          thanh_tien = @thanh_tien,
          cach_dung  = @cach_dung,
          khong_lay  = @khong_lay,
          date_in    = NOW()
      WHERE auto_id = @auto_id",

                new MySqlParameter("@ngay_dung", ngay_dung),
                new MySqlParameter("@sang", sang1),
                new MySqlParameter("@trua", trua1),
                new MySqlParameter("@chieu", chieu1),
                new MySqlParameter("@toi", toi1),
                new MySqlParameter("@so_luong", soLuong1),
                new MySqlParameter("@thanh_tien", thanhTien),
                new MySqlParameter("@cach_dung", row.Cells["colCachDung"].Value?.ToString() ?? ""),
                new MySqlParameter("@khong_lay", Convert.ToBoolean(row.Cells["colKhongLay"].Value ?? false)),
                new MySqlParameter("@auto_id", row.Cells["colAuto_id"].Value)
            );
            tinhTongTienThuocUong();
            loadTongTienThuocUong();
        }


        private void txtNgayDung_TextChanged(object sender, EventArgs e)
        {
            tinhToanSoLuongThuocXuat();
        }

        private void txtSang_TextChanged(object sender, EventArgs e)
        {
            tinhToanSoLuongThuocXuat();
        }

        private void txtTrua_TextChanged(object sender, EventArgs e)
        {
            tinhToanSoLuongThuocXuat();

        }

        private void txtChieu_TextChanged(object sender, EventArgs e)
        {
            tinhToanSoLuongThuocXuat();

        }

        private void txtToi_TextChanged(object sender, EventArgs e)
        {
            tinhToanSoLuongThuocXuat();

        }

        private void txtNgayDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSang.Focus();
            }
        }

        private void txtSang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTrua.Focus();
            }
        }

        private void txtTrua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtChieu.Focus();
            }
        }

        private void txtChieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtToi.Focus();
            }
        }

        private void txtToi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCachDung.Focus();
            }
        }

        private void txtChanDoan_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpNgayHenTaiKham_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboxBacSi_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void btnCapNhatToaUong_Click(object sender, EventArgs e)
        {
            capNhatThongTinToaUong();
            MessageBox.Show("Cập nhật thông tin toa thuốc uống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemToaThuocUong_Click_1(object sender, EventArgs e)
        {
            themToaThuocUong();
        }

        private void cboxToaThuocUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadToaThuocUongChiTiet();
        }

        private void btnCapNhatToaUong_Click_1(object sender, EventArgs e)
        {
            capNhatThongTinToaUong();
            MessageBox.Show("Cập nhật thông tin toa thuốc uống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInToaThuocUong_Click_1(object sender, EventArgs e)
        {
            inToaThuocUong();
        }

        private void btnXoaThuocUong_Click_1(object sender, EventArgs e)
        {
            xoaThuocToaUong();
            loadToaThuocUongChiTiet();
            loadTongTienThuocUong();
        }

        private void btnXoaToa_Click_1(object sender, EventArgs e)
        {
            xoaToaThuocUong();
            loadTongTienThuocUong();
        }
    }
}
