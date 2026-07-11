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

namespace NhaThuoc_BSPhong.Forms
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void tabDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDanhMuc.SelectedTab == tabNhomThuoc)
            {
                loadNhomThuoc();
            }
            else if (tabDanhMuc.SelectedTab == tabDanhMucThuoc)
            {
                loadDanhMucThuoc();
            }
            else if (tabDanhMuc.SelectedTab == tabCachDung)
            {
                loadCachDung();
            }
            else if (tabDanhMuc.SelectedTab == tabDanhSachReport)
            {
                loadDanhSachReportTabReport();
            }
        }

        private void loadNhomThuoc() 
        { 
            
        }

        private void loadDanhMucThuoc() 
        {
            
        }

        private void loadCachDung() 
        { 
            
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
    }
}
