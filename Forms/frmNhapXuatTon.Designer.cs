namespace PhongKham.Forms
{
    partial class frmNhapXuatTon
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvNhapXuatTon = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnExport = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            label3 = new Label();
            txtTenThuoc = new TextBox();
            label4 = new Label();
            cboxNhomThuoc = new ComboBox();
            btnDieuChinh = new Button();
            toolTip1 = new ToolTip(components);
            colMaThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc = new DataGridViewTextBoxColumn();
            colHoatChat = new DataGridViewTextBoxColumn();
            colNhomThuoc = new DataGridViewTextBoxColumn();
            colDonViLe = new DataGridViewTextBoxColumn();
            colLSX = new DataGridViewTextBoxColumn();
            colHSD = new DataGridViewTextBoxColumn();
            colSoNhap = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colSoXuat = new DataGridViewTextBoxColumn();
            colNgayXuat = new DataGridViewTextBoxColumn();
            colTonKho = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuatTon).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvNhapXuatTon, 0, 1);
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1284, 661);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvNhapXuatTon
            // 
            dgvNhapXuatTon.AllowUserToAddRows = false;
            dgvNhapXuatTon.BackgroundColor = Color.White;
            dgvNhapXuatTon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapXuatTon.Columns.AddRange(new DataGridViewColumn[] { colMaThuoc, colTenThuoc, colHoatChat, colNhomThuoc, colDonViLe, colLSX, colHSD, colSoNhap, colNgayNhap, colSoXuat, colNgayXuat, colTonKho });
            dgvNhapXuatTon.Dock = DockStyle.Fill;
            dgvNhapXuatTon.Location = new Point(3, 54);
            dgvNhapXuatTon.Name = "dgvNhapXuatTon";
            dgvNhapXuatTon.Size = new Size(1278, 579);
            dgvNhapXuatTon.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExport, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 636);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1284, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnExport
            // 
            btnExport.Image = Properties.Resources.excel;
            btnExport.ImageTransparentColor = Color.Magenta;
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 22);
            btnExport.Text = "Xuất excel";
            btnExport.Click += btnExport_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 45);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(dtpTuNgay);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(dtpDenNgay);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtTenThuoc);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(cboxNhomThuoc);
            flowLayoutPanel1.Controls.Add(btnDieuChinh);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1240, 38);
            flowLayoutPanel1.TabIndex = 0;
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
            dtpTuNgay.Size = new Size(119, 26);
            dtpTuNgay.TabIndex = 5;
            dtpTuNgay.Value = new DateTime(2026, 1, 1, 21, 45, 0, 0);
            dtpTuNgay.ValueChanged += dtpTuNgay_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(203, 7);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 4;
            label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.None;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(287, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(118, 26);
            dtpDenNgay.TabIndex = 2;
            dtpDenNgay.ValueChanged += dtpDenNgay_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(411, 7);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 6;
            label3.Text = "Tên thuốc:";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Anchor = AnchorStyles.None;
            txtTenThuoc.Location = new Point(496, 3);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(306, 26);
            txtTenThuoc.TabIndex = 1;
            txtTenThuoc.TextChanged += txtTenThuoc_TextChanged;
            txtTenThuoc.KeyDown += txtTenThuoc_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(808, 7);
            label4.Name = "label4";
            label4.Size = new Size(94, 18);
            label4.TabIndex = 8;
            label4.Text = "Nhóm thuốc:";
            // 
            // cboxNhomThuoc
            // 
            cboxNhomThuoc.FormattingEnabled = true;
            cboxNhomThuoc.Location = new Point(908, 3);
            cboxNhomThuoc.Name = "cboxNhomThuoc";
            cboxNhomThuoc.Size = new Size(121, 26);
            cboxNhomThuoc.TabIndex = 9;
            cboxNhomThuoc.SelectionChangeCommitted += cboxNhomThuoc_SelectionChangeCommitted_1;
            cboxNhomThuoc.TextChanged += cboxNhomThuoc_TextChanged;
            // 
            // btnDieuChinh
            // 
            btnDieuChinh.Location = new Point(1035, 3);
            btnDieuChinh.Name = "btnDieuChinh";
            btnDieuChinh.Size = new Size(105, 26);
            btnDieuChinh.TabIndex = 10;
            btnDieuChinh.Text = "Điều chỉnh";
            btnDieuChinh.UseVisualStyleBackColor = true;
            // 
            // colMaThuoc
            // 
            colMaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMaThuoc.DataPropertyName = "ma_thuoc";
            colMaThuoc.HeaderText = "Mã thuốc";
            colMaThuoc.Name = "colMaThuoc";
            // 
            // colTenThuoc
            // 
            colTenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTenThuoc.DataPropertyName = "ten_thuoc";
            colTenThuoc.HeaderText = "Tên thuốc";
            colTenThuoc.Name = "colTenThuoc";
            colTenThuoc.Width = 400;
            // 
            // colHoatChat
            // 
            colHoatChat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHoatChat.DataPropertyName = "hoat_chat";
            colHoatChat.HeaderText = "Hoạt chất";
            colHoatChat.Name = "colHoatChat";
            colHoatChat.Width = 200;
            // 
            // colNhomThuoc
            // 
            colNhomThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNhomThuoc.DataPropertyName = "nhom_thuoc";
            colNhomThuoc.HeaderText = "Nhóm thuốc";
            colNhomThuoc.Name = "colNhomThuoc";
            colNhomThuoc.Width = 150;
            // 
            // colDonViLe
            // 
            colDonViLe.DataPropertyName = "don_vi_le";
            colDonViLe.HeaderText = "Đơn vị";
            colDonViLe.Name = "colDonViLe";
            // 
            // colLSX
            // 
            colLSX.DataPropertyName = "lsx";
            colLSX.HeaderText = "LSX";
            colLSX.Name = "colLSX";
            // 
            // colHSD
            // 
            colHSD.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHSD.DataPropertyName = "hsd";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colHSD.DefaultCellStyle = dataGridViewCellStyle1;
            colHSD.HeaderText = "HSD";
            colHSD.Name = "colHSD";
            colHSD.Width = 130;
            // 
            // colSoNhap
            // 
            colSoNhap.DataPropertyName = "so_nhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "###,#";
            colSoNhap.DefaultCellStyle = dataGridViewCellStyle2;
            colSoNhap.HeaderText = "Số Nhập";
            colSoNhap.Name = "colSoNhap";
            // 
            // colNgayNhap
            // 
            colNgayNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgayNhap.DataPropertyName = "ngay_nhap";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            colNgayNhap.DefaultCellStyle = dataGridViewCellStyle3;
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.Width = 130;
            // 
            // colSoXuat
            // 
            colSoXuat.DataPropertyName = "so_xuat";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "###,#";
            colSoXuat.DefaultCellStyle = dataGridViewCellStyle4;
            colSoXuat.HeaderText = "Số xuất";
            colSoXuat.Name = "colSoXuat";
            // 
            // colNgayXuat
            // 
            colNgayXuat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgayXuat.DataPropertyName = "ngay_xuat";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            colNgayXuat.DefaultCellStyle = dataGridViewCellStyle5;
            colNgayXuat.HeaderText = "Ngày xuất";
            colNgayXuat.Name = "colNgayXuat";
            colNgayXuat.Width = 130;
            // 
            // colTonKho
            // 
            colTonKho.DataPropertyName = "ton_kho";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "###,#";
            colTonKho.DefaultCellStyle = dataGridViewCellStyle6;
            colTonKho.HeaderText = "Tồn kho";
            colTonKho.Name = "colTonKho";
            // 
            // frmNhapXuatTon
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 661);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmNhapXuatTon";
            Text = "frmNhapXuatTon";
            Load += frmNhapXuatTon_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuatTon).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvNhapXuatTon;
        private ToolStrip toolStrip1;
        private ToolStripButton btnExport;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtTenThuoc;
        private DateTimePicker dtpDenNgay;
        private ToolTip toolTip1;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboxNhomThuoc;
        private Button btnDieuChinh;
        private DataGridViewTextBoxColumn colMaThuoc;
        private DataGridViewTextBoxColumn colTenThuoc;
        private DataGridViewTextBoxColumn colHoatChat;
        private DataGridViewTextBoxColumn colNhomThuoc;
        private DataGridViewTextBoxColumn colDonViLe;
        private DataGridViewTextBoxColumn colLSX;
        private DataGridViewTextBoxColumn colHSD;
        private DataGridViewTextBoxColumn colSoNhap;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colSoXuat;
        private DataGridViewTextBoxColumn colNgayXuat;
        private DataGridViewTextBoxColumn colTonKho;
    }
}