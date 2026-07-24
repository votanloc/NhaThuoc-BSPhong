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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void tabThongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabThongke.SelectedTab == tabChanDoan)
            {
                loadTabChanDoan();
            }
            else if (tabThongke.SelectedTab == tabThongke.TabPages["tabBenhNhan"])
            {
                // Load data for Benh Nhan tab
            }
        }

        private void loadTabChanDoan()
        {
            string query =
@"
SELECT
    t1.ma_bn,
    t1.ho_ten,
    t1.tuoi,
    t1.phai,
    t1.dia_chi,
    t1.sdt,
    t2.date_in,
    t2.chan_doan,
    t2.ghi_chu,
    t2.tai_kham,
    t2.bac_si
FROM tbl_bn t1
JOIN tbl_tu t2 ON t1.ma_bn = t2.ma_bn
WHERE
    t2.date_in >= @TuNgay
    AND t2.date_in < @DenNgay
    AND t1.delete_at IS NULL
    AND t2.delete_at IS NULL;";
            dgvChanDoan.DataSource = Helpers.MySqlHelper.ExecuteDataTable(query,
                new MySqlParameter("@TuNgay", dtpDenNgay.Value.Date),
                new MySqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1)));
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Export.ExportExcel(dgvChanDoan);
        }
    }
}
