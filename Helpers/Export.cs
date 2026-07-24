using ClosedXML.Excel;
using FastReport.Export.PdfSimple;
using FastReport;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace PhongKham
{
    public class Export
    {
        public static void ExportExcel(DataGridView dgv)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible)
                        dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataRow dr = dt.NewRow();

                    int i = 0;
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (col.Visible)
                        {
                            dr[i] = row.Cells[col.Index].Value?.ToString() ?? "";
                            i++;
                        }
                    }

                    dt.Rows.Add(dr);
                }

                string fileName = Path.Combine(
                    Path.GetTempPath(),
                    "Book1.xlsx");

                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add(dt, "Data");

                    ws.Row(1).Style.Font.Bold = true;
                    ws.Columns().AdjustToContents();

                    wb.SaveAs(fileName);
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Pdf(
    string frxFile,
    DataGridView dgv,
    Dictionary<string, object> parameters)
        {
            Report report = new Report();

            report.Load(frxFile);

            // Chuyển DataGridView -> DataTable
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                    dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                DataRow dr = dt.NewRow();

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible)
                        dr[col.Name] = row.Cells[col.Index].Value ?? DBNull.Value;
                }

                dt.Rows.Add(dr);
            }

            report.RegisterData(dt, "Data");
            DataBand data = report.FindObject("Data") as DataBand;
            if (data != null)
            {
                data.DataSource = report.GetDataSource("Data");
            }
            report.GetDataSource("Data").Enabled = true;

            foreach (var item in parameters)
            {
                report.SetParameterValue(item.Key, item.Value);
            }

            report.Prepare();

            string fileName = Path.Combine(
                Path.GetTempPath(),
                $"BookLPsoft_{DateTime.Now:yyyyMMddHHmmss}.pdf");

            PDFSimpleExport pdf = new PDFSimpleExport();

            report.Export(pdf, fileName);

            Process.Start(new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true
            });

            report.Dispose();
        }
    }
}