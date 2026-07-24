using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace PhongKham.Helpers
{
    internal class MySqlHelper
    {
        //private const string MYSQL_CONN = "Server= 100.118.186.37;Port=3306;Database=lpsoft_qclab;Uid=root;Pwd=lpsoft708;SslMode=None;";
        private const string MYSQL_CONN = "Server= 100.118.186.37;Port=3306;Database=nhathuoc_bsphong;Uid=lpsoft;Pwd=lpsoft708;SslMode=None;";

        //private const string MYSQL_CONN = "Server= 100.69.254.19;Port=3306;Database=xetnghiem;Uid=xetnghiem;Pwd=xetnghiem@123;SslMode=None;";

        private static void AddParameters(MySqlCommand cmd, MySqlParameter[] parameters)
        {
            if (parameters?.Length > 0)
                cmd.Parameters.AddRange(parameters);
        }

        public static int ExecuteNonQuery(string sql, params MySqlParameter[] prms)
        {
            using var conn = new MySqlConnection(MYSQL_CONN);
            using var cmd = new MySqlCommand(sql, conn);

            if (prms != null)
            {
                cmd.Parameters.AddRange(prms);

                foreach (MySqlParameter p in cmd.Parameters)
                {
                    Debug.WriteLine($"{p.ParameterName} = [{p.Value}] ({p.Value?.GetType().Name})");
                }
            }

            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        /*
        CÁCH DÙNG:

        int rows = SqlHelper.ExecuteNonQuery(
            "UPDATE dm_danhmuc SET TenHoaChat = @ten WHERE MaHoaChat = @ma",
            new MySqlParameter("@ten", "Hóa chất A"),
            new MySqlParameter("@ma", "HC01")
        );
        */
        public static void WarmUp()
        {
            using (var conn = new MySqlConnection(MYSQL_CONN))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("SELECT 1", conn))
                {
                    cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql, params MySqlParameter[] parameters)
        {
            var table = new DataTable();

            using var conn = new MySqlConnection(MYSQL_CONN);
            using var cmd = new MySqlCommand(sql, conn);
            using var adapter = new MySqlDataAdapter(cmd);

            AddParameters(cmd, parameters);
            adapter.Fill(table);

            return table;
        }

        /*
        CÁCH DÙNG:

        DataTable dt = SqlHelper.ExecuteDataTable(
            "SELECT * FROM dm_danhmuc WHERE MaNhom = @nhom",
            new MySqlParameter("@nhom", "NHOM1")
        );
        dgv.DataSource = dt;
        */


        public static DataSet ExecuteDataSet(string sql, params MySqlParameter[] parameters)
        {
            var ds = new DataSet();

            using var conn = new MySqlConnection(MYSQL_CONN);
            using var cmd = new MySqlCommand(sql, conn);
            using var adapter = new MySqlDataAdapter(cmd);

            AddParameters(cmd, parameters);
            adapter.Fill(ds);

            return ds;
        }

        /*
        CÁCH DÙNG:

        DataSet ds = SqlHelper.ExecuteDataSet(
            "SELECT * FROM dm_danhmuc; SELECT * FROM dm_donvi;"
        );

        var table1 = ds.Tables[0];
        var table2 = ds.Tables[1];
        */

        public static async Task<DataTable> ExecuteDataTableAsync(
        string sql,
        params MySqlParameter[] parameters)
        {
            var table = new DataTable();

            using var conn = new MySqlConnection(MYSQL_CONN);
            using var cmd = new MySqlCommand(sql, conn);

            AddParameters(cmd, parameters);

            await conn.OpenAsync();

            using var reader = await cmd.ExecuteReaderAsync();
            table.Load(reader);

            return table;
        }

        /*
         Cách dùng
        private async void LoadDanhMuc()
            {
                DataTable dt = await AppHelper.ExecuteDataTableAsync(
                    "SELECT * FROM dm_danhmuc WHERE MaNhom = @nhom",
                    new MySqlParameter("@nhom", "NHOM1")
                );

                dgvDanhMuc.DataSource = dt;
            }
         */

        // hàm đồng bộ
        public static object? ExecuteScalar(
            string sql,
            params MySqlParameter[] parameters)
        {
            using var conn = new MySqlConnection(MYSQL_CONN);
            using var cmd = new MySqlCommand(sql, conn);

            AddParameters(cmd, parameters);

            conn.Open();
            return cmd.ExecuteScalar();
        }
        // cách dùng
        //int total = Convert.ToInt32(
        //AppHelper.ExecuteScalar("SELECT COUNT(*) FROM dm_nhanvien")
        //);



        // hàm bất đồng bộ
        public static async Task<object?> ExecuteScalarAsync(
        string sql,
        params MySqlParameter[] parameters)
        {
            using var conn = new MySqlConnection(MYSQL_CONN);
            using var cmd = new MySqlCommand(sql, conn);

            AddParameters(cmd, parameters);

            await conn.OpenAsync();
            return await cmd.ExecuteScalarAsync();
        }


        //    cách dùng
        //            int total = Convert.ToInt32(
        //    await AppHelper.ExecuteScalarAsync(
        //        "SELECT COUNT(*) FROM dm_danhmuc WHERE MaNhom = @nhom",
        //        new MySqlParameter("@nhom", "NHOM1")
        //    )
        //);


        public static int UpdateWordFile(string formName, string filePath)
        {
            byte[] fileData = File.ReadAllBytes(filePath);

            string sql = "UPDATE tbl_form SET file = @file WHERE form_name = @form_name";

            return ExecuteNonQuery(
                sql,
                new MySqlParameter("@file", fileData),
                new MySqlParameter("@form_name", formName)
            );
        }
        // cách dùng int kq = RunMySQL.UpdateWordFile("Inketqua", filePath);


        public static bool DownloadWordFile(string formName, string savePath)
        {
            string sql = "SELECT file FROM tbl_form WHERE form_name = @form_name LIMIT 1";

            object? result = ExecuteScalar(
                sql,
                new MySqlParameter("@form_name", formName)
            );

            if (result == null || result == DBNull.Value)
                return false;

            byte[] fileData = (byte[])result;

            File.WriteAllBytes(savePath, fileData);

            return true;
        }

        public static void DownloadReportFile(
            int idReport,
            string localFile)
        {
            DataTable dt = ExecuteDataTable(
                @"SELECT file
          FROM dm_report
          WHERE id_report=@ID",
                new MySqlParameter("@ID", idReport));

            if (dt.Rows.Count == 0)
                throw new Exception("Không tìm thấy report.");

            if (dt.Rows[0]["file"] == DBNull.Value)
                throw new Exception("Report chưa được upload.");

            byte[] data = (byte[])dt.Rows[0]["file"];

            File.WriteAllBytes(localFile, data);
        }
    }
}
