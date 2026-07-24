namespace PhongKham.Forms
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            tabThongke = new TabControl();
            tabDoanhThu = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            colMaBN = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNamSinh = new DataGridViewTextBoxColumn();
            colPhai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colChanDoan = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            toolStrip2 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            tabChanDoan = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvChanDoan = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            btnXuatExcel = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            colMaBN1 = new DataGridViewTextBoxColumn();
            colHoTen1 = new DataGridViewTextBoxColumn();
            colNamSinh1 = new DataGridViewTextBoxColumn();
            colPhai1 = new DataGridViewTextBoxColumn();
            colDiaChi1 = new DataGridViewTextBoxColumn();
            colSDT1 = new DataGridViewTextBoxColumn();
            colChanDoan1 = new DataGridViewTextBoxColumn();
            colGhiChu1 = new DataGridViewTextBoxColumn();
            colNgayNhap1 = new DataGridViewTextBoxColumn();
            colBacSi1 = new DataGridViewTextBoxColumn();
            colTaiKham1 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabThongke.SuspendLayout();
            tabDoanhThu.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip2.SuspendLayout();
            tabChanDoan.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChanDoan).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 661);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tabThongke, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1284, 661);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 102);
            panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(dtpTuNgay);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(dtpDenNgay);
            flowLayoutPanel1.Location = new Point(20, 20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(437, 35);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.None;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(78, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(125, 26);
            dtpTuNgay.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(209, 7);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 5;
            label2.Text = "Đến  ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.None;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(297, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(125, 26);
            dtpDenNgay.TabIndex = 6;
            // 
            // tabThongke
            // 
            tabThongke.Controls.Add(tabDoanhThu);
            tabThongke.Controls.Add(tabChanDoan);
            tabThongke.Dock = DockStyle.Fill;
            tabThongke.Location = new Point(4, 114);
            tabThongke.Margin = new Padding(4);
            tabThongke.Name = "tabThongke";
            tabThongke.SelectedIndex = 0;
            tabThongke.Size = new Size(1276, 543);
            tabThongke.TabIndex = 1;
            tabThongke.SelectedIndexChanged += tabThongke_SelectedIndexChanged;
            // 
            // tabDoanhThu
            // 
            tabDoanhThu.Controls.Add(tableLayoutPanel3);
            tabDoanhThu.Location = new Point(4, 27);
            tabDoanhThu.Margin = new Padding(4);
            tabDoanhThu.Name = "tabDoanhThu";
            tabDoanhThu.Padding = new Padding(4);
            tabDoanhThu.Size = new Size(1268, 512);
            tabDoanhThu.TabIndex = 1;
            tabDoanhThu.Text = "Doanh Thu";
            tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Controls.Add(toolStrip2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1260, 504);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaBN, colHoTen, colNamSinh, colPhai, colDiaChi, colSDT, colChanDoan, colGhiChu });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1254, 473);
            dataGridView1.TabIndex = 0;
            // 
            // colMaBN
            // 
            colMaBN.HeaderText = "Mã BN";
            colMaBN.Name = "colMaBN";
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ tên";
            colHoTen.Name = "colHoTen";
            // 
            // colNamSinh
            // 
            colNamSinh.HeaderText = "Năm sinh";
            colNamSinh.Name = "colNamSinh";
            // 
            // colPhai
            // 
            colPhai.HeaderText = "Phái";
            colPhai.Name = "colPhai";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.Name = "colDiaChi";
            // 
            // colSDT
            // 
            colSDT.HeaderText = "SĐT";
            colSDT.Name = "colSDT";
            // 
            // colChanDoan
            // 
            colChanDoan.HeaderText = "Chẩn đoán";
            colChanDoan.Name = "colChanDoan";
            // 
            // colGhiChu
            // 
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.Name = "colGhiChu";
            // 
            // toolStrip2
            // 
            toolStrip2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel2 });
            toolStrip2.Location = new Point(0, 479);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1260, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(98, 22);
            toolStripLabel2.Text = "Thống kê";
            // 
            // tabChanDoan
            // 
            tabChanDoan.Controls.Add(tableLayoutPanel2);
            tabChanDoan.Location = new Point(4, 27);
            tabChanDoan.Margin = new Padding(4);
            tabChanDoan.Name = "tabChanDoan";
            tabChanDoan.Padding = new Padding(4);
            tabChanDoan.Size = new Size(1268, 512);
            tabChanDoan.TabIndex = 0;
            tabChanDoan.Text = "Chẩn đoán";
            tabChanDoan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvChanDoan, 0, 0);
            tableLayoutPanel2.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1260, 504);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvChanDoan
            // 
            dgvChanDoan.AllowUserToAddRows = false;
            dgvChanDoan.BackgroundColor = Color.White;
            dgvChanDoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChanDoan.Columns.AddRange(new DataGridViewColumn[] { colMaBN1, colHoTen1, colNamSinh1, colPhai1, colDiaChi1, colSDT1, colChanDoan1, colGhiChu1, colNgayNhap1, colBacSi1, colTaiKham1 });
            dgvChanDoan.Dock = DockStyle.Fill;
            dgvChanDoan.Location = new Point(3, 3);
            dgvChanDoan.Name = "dgvChanDoan";
            dgvChanDoan.Size = new Size(1254, 473);
            dgvChanDoan.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, btnXuatExcel, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 479);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1260, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(98, 22);
            toolStripLabel1.Text = "Thống kê";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(106, 22);
            btnXuatExcel.Text = "Xuất excel";
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // colMaBN1
            // 
            colMaBN1.DataPropertyName = "ma_bn";
            colMaBN1.HeaderText = "Mã BN";
            colMaBN1.Name = "colMaBN1";
            // 
            // colHoTen1
            // 
            colHoTen1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHoTen1.DataPropertyName = "ho_ten";
            colHoTen1.HeaderText = "Họ tên";
            colHoTen1.Name = "colHoTen1";
            colHoTen1.Width = 150;
            // 
            // colNamSinh1
            // 
            colNamSinh1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNamSinh1.DataPropertyName = "tuoi";
            colNamSinh1.HeaderText = "Năm sinh";
            colNamSinh1.Name = "colNamSinh1";
            // 
            // colPhai1
            // 
            colPhai1.DataPropertyName = "phai";
            colPhai1.HeaderText = "Phái";
            colPhai1.Name = "colPhai1";
            // 
            // colDiaChi1
            // 
            colDiaChi1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDiaChi1.DataPropertyName = "dia_chi";
            colDiaChi1.HeaderText = "Địa chỉ";
            colDiaChi1.Name = "colDiaChi1";
            colDiaChi1.Width = 200;
            // 
            // colSDT1
            // 
            colSDT1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSDT1.DataPropertyName = "sdt";
            colSDT1.HeaderText = "SĐT";
            colSDT1.Name = "colSDT1";
            // 
            // colChanDoan1
            // 
            colChanDoan1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colChanDoan1.DataPropertyName = "chan_doan";
            colChanDoan1.HeaderText = "Chẩn đoán";
            colChanDoan1.Name = "colChanDoan1";
            colChanDoan1.Width = 150;
            // 
            // colGhiChu1
            // 
            colGhiChu1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colGhiChu1.DataPropertyName = "ghi_chu";
            colGhiChu1.HeaderText = "Ghi chú";
            colGhiChu1.Name = "colGhiChu1";
            colGhiChu1.Width = 150;
            // 
            // colNgayNhap1
            // 
            colNgayNhap1.DataPropertyName = "date_in";
            colNgayNhap1.HeaderText = "Ngày nhập";
            colNgayNhap1.Name = "colNgayNhap1";
            // 
            // colBacSi1
            // 
            colBacSi1.DataPropertyName = "bac_si";
            colBacSi1.HeaderText = "Bác sĩ";
            colBacSi1.Name = "colBacSi1";
            // 
            // colTaiKham1
            // 
            colTaiKham1.DataPropertyName = "tai_kham";
            colTaiKham1.HeaderText = "Tái khám";
            colTaiKham1.Name = "colTaiKham1";
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 661);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmThongKe";
            StartPosition = FormStartPosition.Manual;
            Text = "frmThongKe";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabThongke.ResumeLayout(false);
            tabDoanhThu.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tabChanDoan.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChanDoan).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private TabControl tabThongke;
        private TabPage tabChanDoan;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvChanDoan;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private TabPage tabDoanhThu;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel btnXuatExcel;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridViewTextBoxColumn colMaBN;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNamSinh;
        private DataGridViewTextBoxColumn colPhai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colChanDoan;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colMaBN1;
        private DataGridViewTextBoxColumn colHoTen1;
        private DataGridViewTextBoxColumn colNamSinh1;
        private DataGridViewTextBoxColumn colPhai1;
        private DataGridViewTextBoxColumn colDiaChi1;
        private DataGridViewTextBoxColumn colSDT1;
        private DataGridViewTextBoxColumn colChanDoan1;
        private DataGridViewTextBoxColumn colGhiChu1;
        private DataGridViewTextBoxColumn colNgayNhap1;
        private DataGridViewTextBoxColumn colBacSi1;
        private DataGridViewTextBoxColumn colTaiKham1;
    }
}