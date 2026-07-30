using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKham.Forms
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);
            loadDonViLe();
            loadNhomThuoc();
            loadCachDung();
        }

        private void loadDonViLe()
        {
            var dt = Helpers.MySqlHelper.ExecuteDataTable(@"
                SELECT DISTINCT don_vi_le 
                FROM dm_thuoc 
                WHERE don_vi_le IS NOT NULL AND don_vi_le <> ''
                ORDER BY don_vi_le;");

            cboxDonViLe.DropDownWidth = 200;
            cboxDonViLe.DropDownHeight = 200;
            cboxDonViLe.DataSource = dt;
            cboxDonViLe.DisplayMember = "don_vi_le";
            cboxDonViLe.ValueMember = "don_vi_le";
            cboxDonViLe.SelectedIndex = -1;
        }

        private void loadCachDung()
        {
            var dt = Helpers.MySqlHelper.ExecuteDataTable(@"
                SELECT DISTINCT cach_dung
                FROM dm_thuoc 
                WHERE cach_dung IS NOT NULL AND cach_dung <> ''
                ORDER BY cach_dung;");

            cboxCachDung.DropDownWidth = 200;
            cboxCachDung.DropDownHeight = 200;
            cboxCachDung.DataSource = dt;
            cboxCachDung.DisplayMember = "cach_dung";
            cboxCachDung.ValueMember = "cach_dung";
            cboxCachDung.SelectedIndex = -1;
        }

        private void tabDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDanhMuc.SelectedTab == tabDanhMucThuoc)
            {
                Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);
                //loadNhomThuoc();
            }
            else if (tabDanhMuc.SelectedTab == tabDanhSachReport)
            {
                loadDanhSachReportTabReport();
            }
        }

        private void loadNhomThuoc()
        {
            var dt = Helpers.MySqlHelper.ExecuteDataTable(@"
                SELECT DISTINCT nhom_thuoc
                FROM dm_thuoc 
                WHERE nhom_thuoc IS NOT NULL AND nhom_thuoc <> ''
                ORDER BY nhom_thuoc;");

            // cbox tìm kiếm
            cboxTimNhomThuoc.DropDownWidth = 200;
            cboxTimNhomThuoc.DropDownHeight = 200;
            cboxTimNhomThuoc.DataSource = dt.Copy();
            cboxTimNhomThuoc.DisplayMember = "nhom_thuoc";
            cboxTimNhomThuoc.ValueMember = "nhom_thuoc";
            cboxTimNhomThuoc.SelectedIndex = -1;

            // cbox Nhóm thuốc
            cboxNhomThuoc.DropDownWidth = 200;
            cboxNhomThuoc.DropDownHeight = 200;
            cboxNhomThuoc.DataSource = dt;
            cboxNhomThuoc.DisplayMember = "nhom_thuoc";
            cboxNhomThuoc.ValueMember = "nhom_thuoc";
            cboxNhomThuoc.SelectedIndex = -1;

        }

        private void loadDanhMucThuoc()
        {
            string timtenThuoc = "%" + txtTimThuoc.Text.Trim() + "%";
            string timNhomThuoc = "%" + cboxTimNhomThuoc.Text.Trim() + "%";

            string rdoTUFilter = rdoTatCaThuoc.Checked ? "" : (rdoThuocTiem.Checked ? "AND thuoc_tiem = '1'" : "AND (thuoc_tiem IS NULL OR thuoc_tiem = '0')");

            string rdoKhoaFilter = rdoTatCaThuocDanhMuc.Checked ? "" : (rdoThuocKhoa.Checked ? "AND khoa = '1'" : "AND (khoa IS NULL OR khoa = '0')");

            dgvDanhMucThuoc.DataSource = Helpers.MySqlHelper.ExecuteDataTable($@"
                SELECT 
                    ma_thuoc,
                    ten_thuoc,
                    hoat_chat,
                    ham_luong,
                    don_vi_chan,
                    he_so,
                    don_vi_le,
                    nhom_thuoc,
                    thuoc_tiem,
                    gia_nhap,
                    gia_ban,
                    cach_dung,
                    khoa 
                FROM dm_thuoc
                where 
                (ten_thuoc LIKE @ten_thuoc or hoat_chat LIKE @ten_thuoc) 
                    AND nhom_thuoc LIKE @nhom_thuoc
                    {rdoTUFilter}
                    {rdoKhoaFilter}
                ORDER BY ma_thuoc;",
                new MySqlParameter("@ten_thuoc", timtenThuoc),
                new MySqlParameter("@nhom_thuoc", timNhomThuoc));
        }


        private void btnThemReport_Click(object sender, EventArgs e)
        {
            Helpers.MySqlHelper.ExecuteNonQuery(
                @"INSERT INTO dm_report (report_name,nhom) VALUES (@report_name,@nhom)",
                new MySqlParameter("@report_name", txtReport_name.Text.Trim()),
                new MySqlParameter("@nhom", txtNhom_Report.Text.Trim())
            );
            loadDanhSachReportTabReport();
        }

        private void loadDanhSachReportTabReport()
        {
            string reportName = "%" + txtReport_name.Text.Trim() + "%";

            dgvReport.DataSource = Helpers.MySqlHelper.ExecuteDataTable(@"
                    SELECT 
                        id_report,
                        report_name,
                        nhom,
                        trang_thai,
                        khoa
                    FROM dm_report
                    WHERE report_name LIKE @report_name
                    ORDER BY report_name",
                            new MySqlParameter("@report_name", reportName)
                        );
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idReport = Convert.ToInt32(
                dgvReport.Rows[e.RowIndex].Cells["colID_Report"].Value);

            string reportName =
                dgvReport.Rows[e.RowIndex].Cells["colReport_name"].Value.ToString();

            string colName = dgvReport.Columns[e.ColumnIndex].Name;

            if (colName == "colTaiReport")
            {
                TaiReport(idReport, reportName);

                BeginInvoke(new Action(() =>
                {
                    loadDanhSachReportTabReport();
                }));
            }
            else if (colName == "colThayTheReport")
            {
                ThayTheReport(idReport);

                BeginInvoke(new Action(() =>
                {
                    loadDanhSachReportTabReport();
                }));
            }
        }

        private void TaiReport(int idReport, string reportName)
        {
            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(
                @"SELECT file
          FROM dm_report
          WHERE id_report=@ID",
                new MySqlParameter("@ID", idReport));

            if (dt.Rows.Count == 0)
                return;

            if (dt.Rows[0]["file"] == DBNull.Value)
            {
                MessageBox.Show("Report chưa được upload.");
                return;
            }

            byte[] fileData = (byte[])dt.Rows[0]["file"];

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = reportName + ".frx";
            sfd.Filter = "FastReport (*.frx)|*.frx";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            // cập nhật trạng thái để người khác biết đang có người tải về chỉnh sửa
            Helpers.MySqlHelper.ExecuteNonQuery(
                @"UPDATE dm_report
                  SET trang_thai='Đang chỉnh sửa'
                  WHERE id_report=@id_report",
                new MySqlParameter("@id_report", idReport));

            File.WriteAllBytes(sfd.FileName, fileData);

            MessageBox.Show("Tải report thành công.");
        }

        private void ThayTheReport(int idReport)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "FastReport (*.frx)|*.frx";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                byte[] fileData = File.ReadAllBytes(ofd.FileName);

                Helpers.MySqlHelper.ExecuteNonQuery(
                    @"UPDATE dm_report
                          SET file=@file, trang_thai = 'Có thể sửa'
                          WHERE id_report=@ID",
                    new MySqlParameter("@file", fileData),
                    new MySqlParameter("@ID", idReport));

                MessageBox.Show("Cập nhật report thành công.");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void rdoTatCaThuoc_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);

        }

        private void rdoThuocUong_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);

        }

        private void rdoThuocTiem_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);

        }

        private void rdoTatCaThuocDanhMuc_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);

        }

        private void rdoThuocDangSuDung_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);

        }

        private void rdoThuocKhoa_CheckedChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);

        }

        private void txtTimThuoc_TextChanged(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);
        }

        private void txtTimNhom_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnXuatExcel_dgvDanhMucThuoc_Click(object sender, EventArgs e)
        {
        }

        private void cboxTimNhomThuoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);
        }

        private void cboxTimNhomThuoc_TextChanged(object sender, EventArgs e)
        {
            if (cboxTimNhomThuoc.SelectedIndex == -1)
            {
                Helpers.DebounceManager.Execute("loadDanhMucThuoc", 100, loadDanhMucThuoc);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemThuocMoi();
            xoaThongTinTrenNhapMoi();
            txtTenThuoc.Focus();
            MessageBox.Show("Thêm thuốc mới thành công.");
        }

        private void ThemThuocMoi()
        {
            string query = @"
        INSERT INTO dm_thuoc
        (
            ten_thuoc,
            hoat_chat,
            ham_luong,
            don_vi_le,
            nhom_thuoc,
            thuoc_tiem,
            gia_nhap,
            gia_ban,
            cach_dung
        )
        VALUES
        (
            @ten_thuoc,
            @hoat_chat,
            @ham_luong,
            @don_vi_le,
            @nhom_thuoc,
            @thuoc_tiem,
            @gia_nhap,
            @gia_ban,
            @cach_dung
        );";

            Helpers.MySqlHelper.ExecuteNonQuery(query,
                new MySqlParameter("@ten_thuoc", txtTenThuoc.Text.Trim()),
                new MySqlParameter("@hoat_chat", txtHoatChat.Text.Trim()),
                new MySqlParameter("@ham_luong", txtHamLuong.Text.Trim()),
                new MySqlParameter("@don_vi_le", cboxDonViLe.Text.Trim()),
                new MySqlParameter("@nhom_thuoc", cboxNhomThuoc.Text.Trim()),
                new MySqlParameter("@thuoc_tiem", checkBoxThuocTiem.Checked ? 1 : 0),
                new MySqlParameter("@gia_nhap", decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) ? giaNhap : 0),
                new MySqlParameter("@gia_ban", decimal.TryParse(txtGiaBan.Text, out decimal giaBan) ? giaBan : 0),
                new MySqlParameter("@cach_dung", cboxCachDung.Text.Trim())
            );
        }

        private void xoaThongTinTrenNhapMoi()
        {
            txtTenThuoc.Clear();
            txtHoatChat.Clear();
            txtHamLuong.Clear();
            cboxDonViLe.Text = "";
            cboxNhomThuoc.SelectedIndex = -1;
            checkBoxThuocTiem.Checked = false;
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            cboxCachDung.Text = "";
        }

        private void dgvDanhMucThuoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvDanhMucThuoc.Rows[e.RowIndex];

                string ma_thuoc = row.Cells["colMaThuoc"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(ma_thuoc))
                    return;

                string columnName = dgvDanhMucThuoc.Columns[e.ColumnIndex].DataPropertyName;

                object value = row.Cells[e.ColumnIndex].Value ?? DBNull.Value;

                string sql = $"UPDATE dm_thuoc SET {columnName}=@value WHERE ma_thuoc=@ma_thuoc";

                Helpers.MySqlHelper.ExecuteNonQuery(
                    sql,
                    new MySqlParameter("@value", value),
                    new MySqlParameter("@ma_thuoc", ma_thuoc)
                );

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Export.ExportExcel(dgvDanhMucThuoc);
        }

        private void txtTenThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHoatChat.Focus();
            }
        }

        private void txtHoatChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHamLuong.Focus();
            }
        }

        private void txtHamLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboxDonViLe.Focus();
                cboxDonViLe.DroppedDown = true;
            }
        }

        private void txtDonVi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboxNhomThuoc.Focus();
                cboxNhomThuoc.DroppedDown = true;
            }
        }

        private void cboxNhomThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboxCachDung.Focus();
            }
        }

        private void cboxCachDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGiaNhap.Focus();
            }
        }

        private void txtGiaNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGiaBan.Focus();
            }
        }

        private void txtGiaBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemMoi.Focus();
            }
        }

        private void cboxDonViLe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboxNhomThuoc.Focus();
                cboxNhomThuoc.DroppedDown = true;
            }
        }
    }
}
