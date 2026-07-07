using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LPsoft.Helpers
{
    public partial class ucLookup : UserControl
    {
        // Sự kiện trả về dòng dữ liệu được chọn
        public event Action<DataRow> OnRowSelected;


        public ucLookup()
        {
            InitializeComponent();
            // Thiết kế mặc định cho Grid
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;

            dgvData.RowHeadersVisible = false;
            dgvData.BackgroundColor = Color.White;
            dgvData.BorderStyle = BorderStyle.FixedSingle;

            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            dgvData.KeyDown += dgvData_KeyDown;
            // Đưa UC lên trên cùng khi hiển thị
            this.Visible = false;
        }

        // Nếu người dùng đang focus ở Grid mà nhấn Enter thì cũng chọn luôn
        private void dgvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItem();
                e.Handled = true;
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có click vào dòng dữ liệu không (tránh click vào tiêu đề)
            {
                SelectItem();
            }
        }


        public void FillData(DataTable dt, Dictionary<string, int> colWidths = null, Dictionary<string, string> colFormats = null)
        {
            dgvData.DataSource = dt;
            if (dt == null) return;

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                // 1. Xử lý độ rộng cột
                if (colWidths != null && colWidths.ContainsKey(col.Name))
                    col.Width = colWidths[col.Name];
                else
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // 2. Xử lý định dạng (QUAN TRỌNG: reset về mặc định nếu không có format)
                if (colFormats != null && colFormats.ContainsKey(col.Name))
                {
                    col.DefaultCellStyle.Format = colFormats[col.Name];
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else
                {
                    // Nếu không yêu cầu format, trả về mặc định để tránh dính định dạng của bảng trước
                    col.DefaultCellStyle.Format = "";
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }

            if (dgvData.Rows.Count > 0) dgvData.Rows[0].Selected = true;
        }

        // Hàm quan trọng để di chuyển Grid bằng phím
        public void HandleKeyDown(KeyEventArgs e)
        {
            if (dgvData.Rows.Count == 0) return;
            int currentIndex = dgvData.CurrentRow?.Index ?? 0;

            if (e.KeyCode == Keys.Down)
            {
                if (currentIndex < dgvData.Rows.Count - 1)
                    dgvData.CurrentCell = dgvData.Rows[currentIndex + 1].Cells[0];
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (currentIndex > 0)
                    dgvData.CurrentCell = dgvData.Rows[currentIndex - 1].Cells[0];
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SelectItem();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void SelectItem()
        {
            if (dgvData.CurrentRow != null)
            {
                // Lấy DataRow từ dòng đang chọn
                DataRow row = ((DataRowView)dgvData.CurrentRow.DataBoundItem).Row;

                // Kích hoạt sự kiện để Form cha nhận dữ liệu
                OnRowSelected?.Invoke(row);

                // Ẩn bảng sau khi chọn xong
                this.Visible = false;
            }
        }


        private void ucLookup_Load(object sender, EventArgs e)
        {

        }
    }
}