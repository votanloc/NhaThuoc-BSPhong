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
            
        }

        private void loadTabDoanhThu()
        {
            string query = @"
SELECT 
    t1.ma_bn,
    t1.ho_ten,
    t1.tuoi,
    t1.phai,
    t1.dia_chi,
    t1.sdt,
    t1.date_in,
    t2.bac_si,
    t2.tong_tien
FROM
    tbl_bn t1
        JOIN
    tbl_tu t2 ON t1.ma_bn = t2.ma_bn
        JOIN
    tbl_tu_ct t3 ON t2.ma_toa = t3.ma_toa
WHERE
    t2.date_in >= @tungay
        AND t2.date_in < @denngay 
        AND t1.delete_at IS NULL
        AND t2.delete_at IS NULL
GROUP BY t1.ma_bn, t1.ho_ten , t1.tuoi , t1.phai , t1.dia_chi , t1.sdt , t1.date_in , t2.bac_si , t2.tong_tien
ORDER BY t1.date_in ASC;";

            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(query,
                new MySqlParameter("@tungay", dtpTuNgay.Value.Date),
                new MySqlParameter("@denngay", dtpDenNgay.Value.Date.AddDays(1))
                );

            dgvDoanhThu.DataSource = dt;

            decimal tongThanhTien = 0;

            foreach (DataRow row in dt.Rows)
            {
                //tongSoLuong += Convert.ToInt32(row["so_luong"]);

                tongThanhTien += Convert.ToDecimal(
                    row["tong_tien"] == DBNull.Value
                    ? 0
                    : row["tong_tien"]);
            }

            //toolStripChiTietBenhNhan_TongSoLuong.Text =
            //    tongSoLuong.ToString("#,##0");

            txtTongTienDoanhThu.Text =
                tongThanhTien.ToString("#,##0");
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

            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(query,
                new MySqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                new MySqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1)));

            dgvChanDoan.DataSource = dt;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Export.ExportExcel(dgvChanDoan);
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            loadTabDoanhThu();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export.ExportExcel(dgvDoanhThu);
        }

        private void btnThongKeThuoc_Click(object sender, EventArgs e)
        {
            loadThongKeDoanhThuThuoc();
        }

        private void loadThongKeDoanhThuThuoc()
        {
            string sql = @"
SELECT 
    t1.ma_thuoc,
    t1.ten_thuoc,
    t1.hoat_chat,
    t2.nhom_thuoc,
    t1.so_luong,
    t1.don_gia,
    t1.thanh_tien,
    t1.date_in
FROM
    tbl_tu_ct t1
        JOIN
    dm_thuoc t2 ON t1.ma_thuoc = t2.ma_thuoc
WHERE
    t1.date_in >= @TuNgay
        AND t1.date_in < @DenNgay 
        AND delete_at IS NULL
        AND khong_lay = '0';";

            DataTable dt = Helpers.MySqlHelper.ExecuteDataTable(sql,
                new MySqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                new MySqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1))

                );

            dgvDoanhThuThoc.DataSource = dt;

            decimal tongThanhTien = 0;

            foreach (DataRow row in dt.Rows)
            {
                //tongSoLuong += Convert.ToInt32(row["so_luong"]);

                tongThanhTien += Convert.ToDecimal(
                    row["thanh_tien"] == DBNull.Value
                    ? 0
                    : row["thanh_tien"]);
            }

            //toolStripChiTietBenhNhan_TongSoLuong.Text =
            //    tongSoLuong.ToString("#,##0");

            txtTongTienDoanhThuThuoc.Text =
                tongThanhTien.ToString("#,##0");
        }

        private void btnXuatExcelThuoc_Click(object sender, EventArgs e)
        {
            Export.ExportExcel(dgvDoanhThuThoc);
        }

        private void btnThongKeChanDoan_Click(object sender, EventArgs e)
        {
            loadTabChanDoan();
        }
    }
}
