using MySqlConnector;
using System.Data;

namespace PhongKham.Forms
{
    public partial class frmNhapKho : Form
    {
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private LPsoft.Helpers.ucLookup ucSearchCD;
        private TextBox activeTextBox;
        private string ma_thuoc = "";

        private void frmNhapKho_Load(object sender, EventArgs e)
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
                if (activeTextBox == txtTimThuoc)
                {
                    ma_thuoc = row["ma_thuoc"].ToString();
                    txtTimThuoc.Text = row["ten_thuoc"].ToString();
                    ucSearchCD.Visible = false;

                    txtLSX.Focus();

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

            loadDanhSachPhieuNhap();
        }

        private void loadDanhSachPhieuNhap()
        {
            string maPhieu = "%" + txtTimMaPhieu.Text.Trim() + "%";
            string lyDo = "%" + cboxTimLyDo.Text.Trim() + "%";
            string query = @"SELECT 
                                ma_phieu_nhap, 
    ly_do_nhap,
    dien_giai,
    tong_tien,
    ngay_nhap 
FROM 
tbl_nk 
where 
    ngay_nhap >= @TuNgay and ngay_nhap < @DenNgay and 
    ma_phieu_nhap like @MaPhieu and ly_do_nhap like @LyDo 
    and delete_at is null 
order by ngay_nhap asc";

            dgvTimPhieuNhap.DataSource = Helpers.MySqlHelper.ExecuteDataTable(query,
                new MySqlParameter("@MaPhieu", maPhieu),
                new MySqlParameter("@LyDo", lyDo),
                new MySqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                new MySqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1)));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDanhSachPhieuNhap();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            loadDanhSachPhieuNhap();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            loadDanhSachPhieuNhap();
        }

        private void btnThemPhieuNhapKho_Click(object sender, EventArgs e)
        {
            xoaThongTinPhieuNhap();

            if (!DangKyMaPhieuNhapKho())
                return;

            cboxLyDoNhap.Focus();
        }

        private void xoaThongTinPhieuNhap()
        {
            dtpNgayNhap.Value = DateTime.Now;
            txtMaPhieuNhap.Text = "";
            cboxLyDoNhap.Text = "";
            txtDienGiai.Text = "";
            txtTongTien.Text = "";
            checkBoxKhoaPhieuNhapKho.Checked = false;
        }

        private bool DangKyMaPhieuNhapKho()
        {
            object? obj = Helpers.MySqlHelper.ExecuteScalar(
                @"SELECT ma_phieu_nhap
          FROM tbl_nk
          WHERE delete_at IS NULL
          ORDER BY auto_id DESC
          LIMIT 1");

            string maPhieu = "NK001";

            if (obj != null)
            {
                int stt = int.Parse(obj.ToString()!.Substring(2));
                maPhieu = $"NK{stt + 1:000}";
            }
            int rows = Helpers.MySqlHelper.ExecuteNonQuery(
                @"INSERT INTO tbl_nk
        (
            ma_phieu_nhap,
            ngay_nhap,
            ly_do_nhap,
            dien_giai,
            tong_tien
        )
        VALUES
        (
            @ma,
            @ngay,
            '',
            '',
            0
        )",
                new MySqlParameter("@ma", maPhieu),
                new MySqlParameter("@ngay", DateTime.Now));

            if (rows > 0)
            {
                txtMaPhieuNhap.Text = maPhieu;
                return true;
            }

            MessageBox.Show(
                "Không thể tạo phiếu nhập mới!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }

        private void btnCapNhatPhieuNhapKho_Click(object sender, EventArgs e)
        {
            if (CapNhapPhieuNhapKho())
            {
                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu hoặc phiếu đã bị xóa.");
            }
            loadDanhSachPhieuNhap();
        }

        private bool CapNhapPhieuNhapKho()
        {
            int rows = Helpers.MySqlHelper.ExecuteNonQuery(
                @"UPDATE tbl_nk
          SET ly_do_nhap = @ly_do_nhap,
              dien_giai = @dien_giai,
              ngay_nhap = @ngay_nhap,
              khoa = @khoa
          WHERE ma_phieu_nhap = @ma_phieu_nhap
            AND delete_at IS NULL",
                new MySqlParameter("@ma_phieu_nhap", txtMaPhieuNhap.Text.Trim()),
                new MySqlParameter("@ly_do_nhap", cboxLyDoNhap.Text.Trim()),
                new MySqlParameter("@dien_giai", txtDienGiai.Text.Trim()),
                new MySqlParameter("@ngay_nhap", dtpNgayNhap.Value),
                new MySqlParameter("@khoa", checkBoxKhoaPhieuNhapKho.Checked)
            );

            return rows > 0;
        }

        private void dgvTimPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            { return; }
            loadThongTinPhieuNhap();
            loadNhapKhoChiTiet();
        }
        private void loadThongTinPhieuNhap()
        {
            txtMaPhieuNhap.Text = dgvTimPhieuNhap.CurrentRow.Cells["colMaPhieu"].Value.ToString();
            cboxLyDoNhap.Text = dgvTimPhieuNhap.CurrentRow.Cells["colLyDoNhap"].Value.ToString();
            txtDienGiai.Text = dgvTimPhieuNhap.CurrentRow.Cells["colDienGiai"].Value.ToString();
            txtTongTien.Text = dgvTimPhieuNhap.CurrentRow.Cells["colTongTien"].Value.ToString();
            dtpNgayNhap.Value = Convert.ToDateTime(dgvTimPhieuNhap.CurrentRow.Cells["colNgayNhap"].Value);


        }

        private void txtTimMaPhieu_TextChanged(object sender, EventArgs e)
        {
            loadDanhSachPhieuNhap();
        }

        private void txtTimThuoc_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = txtTimThuoc;
            string timThuoc = "%" + txtTimThuoc.Text.Trim() + "%";

            if (string.IsNullOrEmpty(txtTimThuoc.Text.Trim()))
            {
                ucSearchCD.Visible = false;
                return;
            }

            DataTable dtDiachi = Helpers.MySqlHelper.ExecuteDataTable(
                @"
SELECT 
    ma_thuoc, ten_thuoc, hoat_chat, don_vi_le, gia_nhap 
FROM
    dm_thuoc
WHERE
    (ten_thuoc LIKE @ten_thuoc
        OR hoat_chat LIKE @ten_thuoc)
        AND khoa = '0';",
                new MySqlParameter("@ten_thuoc", timThuoc)
            );

            if (dtDiachi != null && dtDiachi.Rows.Count > 0)
            {
                // 1. Điền dữ liệu và định dạng
                var widths = new Dictionary<string, int> { { "ma_thuoc", 100 }, { "ten_thuoc", 200 }, { "hoat_chat", 400 }, { "don_vi", 100 }, { "gia_nhap", 100 } };
                var formats = new Dictionary<string, string> { { "gia_nhap", "#,###" } };
                ucSearchCD.FillData(dtDiachi, widths, null);

                // 2. TÍNH TOÁN VỊ TRÍ ĐỂ VẼ NGAY DƯỚI TEXTBOX
                // Lấy tọa độ của TextBox so với Form chính (bất kể nó nằm trong Panel nào)
                Point locationOnForm = txtTimThuoc.Parent.PointToScreen(txtTimThuoc.Location);
                locationOnForm = this.PointToClient(locationOnForm);

                ucSearchCD.Left = locationOnForm.X;
                ucSearchCD.Top = locationOnForm.Y + txtTimThuoc.Height;
                ucSearchCD.Width = 920; // Độ rộng của bảng kết quả
                ucSearchCD.Height = 300; // Chiều cao của bảng kết quả

                ucSearchCD.Visible = true;
                ucSearchCD.BringToFront();
            }
            else
            {
                ucSearchCD.Visible = false;
            }
        }

        private void txtTimThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (ucSearchCD != null && ucSearchCD.Visible)
            {
                ucSearchCD.HandleKeyDown(e);
            }
        }

        private void btnThemThuocVaoPhieuNhapKho_Click(object sender, EventArgs e)
        {
            themThuocVaoPhieuNK();
            loadNhapKhoChiTiet();

            txtTimThuoc.Text = "";
            txtSoLuong.Text = "";
            dtpHSD.Value = DateTime.Now;
            txtTimThuoc.Focus();
        }

        private void themThuocVaoPhieuNK()
        {
            if (txtMaPhieuNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng tạo phiếu nhập trước khi thêm thuốc.");
                return;
            }

            decimal soLuong;

            if (!decimal.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                txtSoLuong.Focus();
                return;
            }

            string query = @"
    INSERT INTO tbl_nk_ct
    (
        ma_phieu_nhap,
        ma_thuoc,
        ten_thuoc,
        lsx,
        don_vi_le,
        so_luong,
        don_gia,
        thanh_tien,
        hsd 
    )
    SELECT
        @ma_phieu_nhap,
        dm.ma_thuoc,
        dm.ten_thuoc,
        @lsx,
        dm.don_vi_le,
        @so_luong,
        dm.gia_nhap,
        dm.gia_nhap * @so_luong,
        @hsd 
    FROM dm_thuoc dm
    WHERE dm.ma_thuoc=@ma_thuoc;";

            Helpers.MySqlHelper.ExecuteNonQuery(
                query,
                new MySqlParameter("@ma_phieu_nhap", txtMaPhieuNhap.Text.Trim()),
                new MySqlParameter("@ma_thuoc", ma_thuoc),
                new MySqlParameter("@lsx", txtLSX.Text.Trim()),
                new MySqlParameter("@so_luong", soLuong),
                new MySqlParameter("@hsd", dtpHSD.Value.Date)
            );
        }

        private void loadNhapKhoChiTiet()
        {
            dgvNhapKhoChiTiet.DataSource = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT 
                    auto_id,ma_phieu_nhap,ma_thuoc, ten_thuoc, don_vi_le, so_luong, don_gia , thanh_tien , hsd , lsx 
                FROM 
                    tbl_nk_ct 
                WHERE 
                    ma_phieu_nhap = @ma_phieu_nhap and delete_at is null order by date_in desc",
                new MySqlParameter("@ma_phieu_nhap", txtMaPhieuNhap.Text.Trim())
            );

        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpHSD.Focus();
            }
        }

        private void dtpHSD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemThuocVaoPhieuNhapKho.Focus();
            }
        }

        private void btnXoaThuocPhieuNhapKho_Click(object sender, EventArgs e)
        {
            xoaThuocNhapKho();
        }

        private void xoaThuocNhapKho()
        {
            try
            {
                List<(int AutoId, string MaPhieu, string MaThuoc)> dsCanXoa = new();

                foreach (DataGridViewRow row in dgvNhapKhoChiTiet.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    bool isChecked = false;

                    if (row.Cells["colSelect"].Value != null)
                        bool.TryParse(row.Cells["colSelect"].Value.ToString(), out isChecked);

                    if (!isChecked)
                        continue;

                    int autoId = Convert.ToInt32(row.Cells["colAuto_id"].Value);
                    string maPhieu = row.Cells["colMaPhieu1"].Value?.ToString();
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
                    $"Bạn có chắc muốn xóa {dsCanXoa.Count} thuốc khỏi phiếu nhập?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                foreach (var item in dsCanXoa)
                {
                    Helpers.MySqlHelper.ExecuteNonQuery(
                        @"UPDATE tbl_nk_ct
                  SET delete_at = NOW()
                  WHERE auto_id = @auto_id
                    AND ma_phieu_nhap = @ma_phieu_nhap
                    AND ma_thuoc = @ma_thuoc
                    AND delete_at IS NULL",
                        new MySqlParameter("@auto_id", item.AutoId),
                        new MySqlParameter("@ma_phieu_nhap", item.MaPhieu),
                        new MySqlParameter("@ma_thuoc", item.MaThuoc)
                    );
                }

                MessageBox.Show(
                    $"Đã xóa {dsCanXoa.Count} thuốc.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                loadNhapKhoChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLSX_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSoLuong.Focus();
            }
        }
    }
}
