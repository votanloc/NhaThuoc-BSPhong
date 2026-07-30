namespace PhongKham.Forms
{
    partial class frmDanhMuc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabDanhMuc = new TabControl();
            tabDanhMucThuoc = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvDanhMucThuoc = new DataGridView();
            colMaThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc = new DataGridViewTextBoxColumn();
            colHoatChat = new DataGridViewTextBoxColumn();
            colHamLuong = new DataGridViewTextBoxColumn();
            colGiaNhap = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colDonViChan = new DataGridViewTextBoxColumn();
            colHeSo = new DataGridViewTextBoxColumn();
            colDonViLe = new DataGridViewTextBoxColumn();
            colNhom = new DataGridViewTextBoxColumn();
            colThuocTiem = new DataGridViewCheckBoxColumn();
            colCachDung = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewCheckBoxColumn();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            cboxDonViLe = new ComboBox();
            cboxCachDung = new ComboBox();
            cboxNhomThuoc = new ComboBox();
            btnThemMoi = new Button();
            checkBoxThuocTiem = new CheckBox();
            txtGiaBan = new TextBox();
            txtGiaNhap = new TextBox();
            txtHamLuong = new TextBox();
            txtHoatChat = new TextBox();
            txtTenThuoc = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtMaThuoc = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            txtTimThuoc = new TextBox();
            label3 = new Label();
            cboxTimNhomThuoc = new ComboBox();
            rdoTatCaThuoc = new RadioButton();
            rdoThuocUong = new RadioButton();
            rdoThuocTiem = new RadioButton();
            flowLayoutPanel6 = new FlowLayoutPanel();
            rdoTatCaThuocDanhMuc = new RadioButton();
            rdoThuocDangSuDung = new RadioButton();
            rdoThuocKhoa = new RadioButton();
            toolStrip1 = new ToolStrip();
            btnExportExcel = new ToolStripButton();
            tabNguoiDung = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label11 = new Label();
            textBox8 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dataGridView3 = new DataGridView();
            tabDanhSachReport = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label12 = new Label();
            txtReport_name = new TextBox();
            label16 = new Label();
            txtNhom_Report = new TextBox();
            btnThemReport = new Button();
            dgvReport = new DataGridView();
            colID_Report = new DataGridViewTextBoxColumn();
            colReport_name = new DataGridViewTextBoxColumn();
            colNhomReport = new DataGridViewTextBoxColumn();
            colTaiReport = new DataGridViewButtonColumn();
            colThayTheReport = new DataGridViewButtonColumn();
            colTrangThaiReport = new DataGridViewTextBoxColumn();
            colKhoaReport = new DataGridViewCheckBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabDanhMuc.SuspendLayout();
            tabDanhMucThuoc.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMucThuoc).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabNguoiDung.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabDanhSachReport.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // tabDanhMuc
            // 
            tabDanhMuc.Controls.Add(tabDanhMucThuoc);
            tabDanhMuc.Controls.Add(tabNguoiDung);
            tabDanhMuc.Controls.Add(tabDanhSachReport);
            tabDanhMuc.Dock = DockStyle.Fill;
            tabDanhMuc.Location = new Point(0, 0);
            tabDanhMuc.Name = "tabDanhMuc";
            tabDanhMuc.SelectedIndex = 0;
            tabDanhMuc.Size = new Size(1348, 728);
            tabDanhMuc.TabIndex = 0;
            tabDanhMuc.SelectedIndexChanged += tabDanhMuc_SelectedIndexChanged;
            // 
            // tabDanhMucThuoc
            // 
            tabDanhMucThuoc.Controls.Add(tableLayoutPanel2);
            tabDanhMucThuoc.Location = new Point(4, 27);
            tabDanhMucThuoc.Name = "tabDanhMucThuoc";
            tabDanhMucThuoc.Padding = new Padding(3);
            tabDanhMucThuoc.Size = new Size(1340, 697);
            tabDanhMucThuoc.TabIndex = 1;
            tabDanhMucThuoc.Text = "Danh mục thuốc";
            tabDanhMucThuoc.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvDanhMucThuoc, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel2.Controls.Add(toolStrip1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1334, 691);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvDanhMucThuoc
            // 
            dgvDanhMucThuoc.AllowUserToAddRows = false;
            dgvDanhMucThuoc.BackgroundColor = Color.White;
            dgvDanhMucThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMucThuoc.Columns.AddRange(new DataGridViewColumn[] { colMaThuoc, colTenThuoc, colHoatChat, colHamLuong, colGiaNhap, colGiaBan, colDonViChan, colHeSo, colDonViLe, colNhom, colThuocTiem, colCachDung, colKhoa });
            dgvDanhMucThuoc.Dock = DockStyle.Fill;
            dgvDanhMucThuoc.Location = new Point(3, 243);
            dgvDanhMucThuoc.Name = "dgvDanhMucThuoc";
            dgvDanhMucThuoc.Size = new Size(1328, 420);
            dgvDanhMucThuoc.TabIndex = 1;
            dgvDanhMucThuoc.CellEndEdit += dgvDanhMucThuoc_CellEndEdit;
            // 
            // colMaThuoc
            // 
            colMaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMaThuoc.DataPropertyName = "ma_thuoc";
            colMaThuoc.HeaderText = "Mã thuốc";
            colMaThuoc.Name = "colMaThuoc";
            colMaThuoc.ReadOnly = true;
            // 
            // colTenThuoc
            // 
            colTenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTenThuoc.DataPropertyName = "ten_thuoc";
            colTenThuoc.HeaderText = "Tên thuốc";
            colTenThuoc.Name = "colTenThuoc";
            colTenThuoc.Width = 300;
            // 
            // colHoatChat
            // 
            colHoatChat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHoatChat.DataPropertyName = "hoat_chat";
            colHoatChat.HeaderText = "Hoạt chất";
            colHoatChat.Name = "colHoatChat";
            colHoatChat.Width = 300;
            // 
            // colHamLuong
            // 
            colHamLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHamLuong.DataPropertyName = "ham_luong";
            colHamLuong.HeaderText = "Hàm lượng";
            colHamLuong.Name = "colHamLuong";
            colHamLuong.Width = 200;
            // 
            // colGiaNhap
            // 
            colGiaNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colGiaNhap.DataPropertyName = "gia_nhap";
            dataGridViewCellStyle1.Format = "#,###";
            colGiaNhap.DefaultCellStyle = dataGridViewCellStyle1;
            colGiaNhap.HeaderText = "Giá nhập";
            colGiaNhap.Name = "colGiaNhap";
            // 
            // colGiaBan
            // 
            colGiaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colGiaBan.DataPropertyName = "gia_ban";
            dataGridViewCellStyle2.Format = "#,###";
            colGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            colGiaBan.HeaderText = "Giá bán";
            colGiaBan.Name = "colGiaBan";
            // 
            // colDonViChan
            // 
            colDonViChan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDonViChan.DataPropertyName = "don_vi_chan";
            colDonViChan.HeaderText = "Đơn vị chẵn";
            colDonViChan.Name = "colDonViChan";
            colDonViChan.Width = 130;
            // 
            // colHeSo
            // 
            colHeSo.DataPropertyName = "he_so";
            colHeSo.HeaderText = "Hệ số";
            colHeSo.Name = "colHeSo";
            // 
            // colDonViLe
            // 
            colDonViLe.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDonViLe.DataPropertyName = "don_vi_le";
            colDonViLe.HeaderText = "Đơn vị";
            colDonViLe.Name = "colDonViLe";
            // 
            // colNhom
            // 
            colNhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNhom.DataPropertyName = "nhom_thuoc";
            colNhom.HeaderText = "Nhóm";
            colNhom.Name = "colNhom";
            colNhom.Width = 150;
            // 
            // colThuocTiem
            // 
            colThuocTiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colThuocTiem.DataPropertyName = "thuoc_tiem";
            colThuocTiem.HeaderText = "Thuốc tiêm";
            colThuocTiem.Name = "colThuocTiem";
            // 
            // colCachDung
            // 
            colCachDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCachDung.DataPropertyName = "cach_dung";
            colCachDung.HeaderText = "Cách dùng";
            colCachDung.Name = "colCachDung";
            colCachDung.Width = 200;
            // 
            // colKhoa
            // 
            colKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colKhoa.DataPropertyName = "khoa";
            colKhoa.HeaderText = "Khóa";
            colKhoa.Name = "colKhoa";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel6.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(1328, 234);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxDonViLe);
            groupBox1.Controls.Add(cboxCachDung);
            groupBox1.Controls.Add(cboxNhomThuoc);
            groupBox1.Controls.Add(btnThemMoi);
            groupBox1.Controls.Add(checkBoxThuocTiem);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtHamLuong);
            groupBox1.Controls.Add(txtHoatChat);
            groupBox1.Controls.Add(txtTenThuoc);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaThuoc);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1322, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thuốc";
            // 
            // cboxDonViLe
            // 
            cboxDonViLe.FormattingEnabled = true;
            cboxDonViLe.Location = new Point(294, 64);
            cboxDonViLe.Name = "cboxDonViLe";
            cboxDonViLe.Size = new Size(176, 26);
            cboxDonViLe.TabIndex = 20;
            cboxDonViLe.KeyDown += cboxDonViLe_KeyDown;
            // 
            // cboxCachDung
            // 
            cboxCachDung.FormattingEnabled = true;
            cboxCachDung.Location = new Point(958, 64);
            cboxCachDung.Name = "cboxCachDung";
            cboxCachDung.Size = new Size(283, 26);
            cboxCachDung.TabIndex = 19;
            cboxCachDung.KeyDown += cboxCachDung_KeyDown;
            // 
            // cboxNhomThuoc
            // 
            cboxNhomThuoc.FormattingEnabled = true;
            cboxNhomThuoc.Location = new Point(535, 64);
            cboxNhomThuoc.Name = "cboxNhomThuoc";
            cboxNhomThuoc.Size = new Size(148, 26);
            cboxNhomThuoc.TabIndex = 5;
            cboxNhomThuoc.KeyDown += cboxNhomThuoc_KeyDown;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Image = Properties.Resources.plus;
            btnThemMoi.Location = new Point(490, 103);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(100, 26);
            btnThemMoi.TabIndex = 10;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // checkBoxThuocTiem
            // 
            checkBoxThuocTiem.AutoSize = true;
            checkBoxThuocTiem.Location = new Point(689, 66);
            checkBoxThuocTiem.Name = "checkBoxThuocTiem";
            checkBoxThuocTiem.Size = new Size(103, 22);
            checkBoxThuocTiem.TabIndex = 6;
            checkBoxThuocTiem.Text = "Thuốc tiêm";
            checkBoxThuocTiem.UseVisualStyleBackColor = true;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(294, 103);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(176, 26);
            txtGiaBan.TabIndex = 9;
            txtGiaBan.KeyDown += txtGiaBan_KeyDown;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(103, 103);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(100, 26);
            txtGiaNhap.TabIndex = 8;
            txtGiaNhap.KeyDown += txtGiaNhap_KeyDown;
            // 
            // txtHamLuong
            // 
            txtHamLuong.Location = new Point(103, 62);
            txtHamLuong.Name = "txtHamLuong";
            txtHamLuong.Size = new Size(100, 26);
            txtHamLuong.TabIndex = 3;
            txtHamLuong.KeyDown += txtHamLuong_KeyDown;
            // 
            // txtHoatChat
            // 
            txtHoatChat.Location = new Point(773, 25);
            txtHoatChat.Name = "txtHoatChat";
            txtHoatChat.Size = new Size(468, 26);
            txtHoatChat.TabIndex = 2;
            txtHoatChat.KeyDown += txtHoatChat_KeyDown;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(294, 25);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(389, 26);
            txtTenThuoc.TabIndex = 1;
            txtTenThuoc.KeyDown += txtTenThuoc_KeyDown;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(798, 68);
            label15.Name = "label15";
            label15.Size = new Size(154, 18);
            label15.TabIndex = 18;
            label15.Text = "Cách dùng mặc định:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(209, 106);
            label14.Name = "label14";
            label14.Size = new Size(67, 18);
            label14.TabIndex = 16;
            label14.Text = "Giá bán:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 103);
            label13.Name = "label13";
            label13.Size = new Size(75, 18);
            label13.TabIndex = 14;
            label13.Text = "Giá nhập:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(476, 68);
            label9.Name = "label9";
            label9.Size = new Size(53, 18);
            label9.TabIndex = 12;
            label9.Text = "Nhóm:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 65);
            label8.Name = "label8";
            label8.Size = new Size(58, 18);
            label8.TabIndex = 10;
            label8.Text = "Đơn vị:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 65);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(91, 18);
            label7.TabIndex = 8;
            label7.Text = "Hàm lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(689, 28);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 6;
            label6.Text = "Hoạt chất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 28);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 4;
            label5.Text = "Tên thuốc:";
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Enabled = false;
            txtMaThuoc.Location = new Point(103, 25);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.Size = new Size(100, 26);
            txtMaThuoc.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 0;
            label4.Text = "Mã thuốc:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1322, 70);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm thuốc";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel7.Controls.Add(flowLayoutPanel6, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 22);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(1316, 45);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(txtTimThuoc);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(cboxTimNhomThuoc);
            flowLayoutPanel2.Controls.Add(rdoTatCaThuoc);
            flowLayoutPanel2.Controls.Add(rdoThuocUong);
            flowLayoutPanel2.Controls.Add(rdoThuocTiem);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(837, 36);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 0;
            label2.Text = "Tìm tên/hoạt chất:";
            // 
            // txtTimThuoc
            // 
            txtTimThuoc.Location = new Point(138, 3);
            txtTimThuoc.Name = "txtTimThuoc";
            txtTimThuoc.Size = new Size(185, 26);
            txtTimThuoc.TabIndex = 22;
            txtTimThuoc.TextChanged += txtTimThuoc_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(329, 7);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 5;
            label3.Text = "Nhóm:";
            // 
            // cboxTimNhomThuoc
            // 
            cboxTimNhomThuoc.FormattingEnabled = true;
            cboxTimNhomThuoc.Location = new Point(388, 3);
            cboxTimNhomThuoc.Name = "cboxTimNhomThuoc";
            cboxTimNhomThuoc.Size = new Size(121, 26);
            cboxTimNhomThuoc.TabIndex = 26;
            cboxTimNhomThuoc.SelectionChangeCommitted += cboxTimNhomThuoc_SelectionChangeCommitted;
            cboxTimNhomThuoc.TextChanged += cboxTimNhomThuoc_TextChanged;
            // 
            // rdoTatCaThuoc
            // 
            rdoTatCaThuoc.Anchor = AnchorStyles.None;
            rdoTatCaThuoc.AutoSize = true;
            rdoTatCaThuoc.Checked = true;
            rdoTatCaThuoc.Location = new Point(515, 5);
            rdoTatCaThuoc.Name = "rdoTatCaThuoc";
            rdoTatCaThuoc.Size = new Size(69, 22);
            rdoTatCaThuoc.TabIndex = 24;
            rdoTatCaThuoc.TabStop = true;
            rdoTatCaThuoc.Text = "Tất cả";
            rdoTatCaThuoc.UseVisualStyleBackColor = true;
            rdoTatCaThuoc.CheckedChanged += rdoTatCaThuoc_CheckedChanged;
            // 
            // rdoThuocUong
            // 
            rdoThuocUong.Anchor = AnchorStyles.None;
            rdoThuocUong.AutoSize = true;
            rdoThuocUong.Location = new Point(590, 5);
            rdoThuocUong.Name = "rdoThuocUong";
            rdoThuocUong.Size = new Size(106, 22);
            rdoThuocUong.TabIndex = 25;
            rdoThuocUong.Text = "Thuốc uống";
            rdoThuocUong.UseVisualStyleBackColor = true;
            rdoThuocUong.CheckedChanged += rdoThuocUong_CheckedChanged;
            // 
            // rdoThuocTiem
            // 
            rdoThuocTiem.Anchor = AnchorStyles.None;
            rdoThuocTiem.AutoSize = true;
            rdoThuocTiem.Location = new Point(702, 5);
            rdoThuocTiem.Name = "rdoThuocTiem";
            rdoThuocTiem.Size = new Size(102, 22);
            rdoThuocTiem.TabIndex = 4;
            rdoThuocTiem.Text = "Thuốc tiêm";
            rdoThuocTiem.UseVisualStyleBackColor = true;
            rdoThuocTiem.CheckedChanged += rdoThuocTiem_CheckedChanged;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(rdoTatCaThuocDanhMuc);
            flowLayoutPanel6.Controls.Add(rdoThuocDangSuDung);
            flowLayoutPanel6.Controls.Add(rdoThuocKhoa);
            flowLayoutPanel6.Location = new Point(846, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(329, 36);
            flowLayoutPanel6.TabIndex = 1;
            // 
            // rdoTatCaThuocDanhMuc
            // 
            rdoTatCaThuocDanhMuc.AutoSize = true;
            rdoTatCaThuocDanhMuc.Checked = true;
            rdoTatCaThuocDanhMuc.Location = new Point(3, 3);
            rdoTatCaThuocDanhMuc.Name = "rdoTatCaThuocDanhMuc";
            rdoTatCaThuocDanhMuc.Size = new Size(69, 22);
            rdoTatCaThuocDanhMuc.TabIndex = 0;
            rdoTatCaThuocDanhMuc.TabStop = true;
            rdoTatCaThuocDanhMuc.Text = "Tất cả";
            rdoTatCaThuocDanhMuc.UseVisualStyleBackColor = true;
            rdoTatCaThuocDanhMuc.CheckedChanged += rdoTatCaThuocDanhMuc_CheckedChanged;
            // 
            // rdoThuocDangSuDung
            // 
            rdoThuocDangSuDung.AutoSize = true;
            rdoThuocDangSuDung.Location = new Point(78, 3);
            rdoThuocDangSuDung.Name = "rdoThuocDangSuDung";
            rdoThuocDangSuDung.Size = new Size(125, 22);
            rdoThuocDangSuDung.TabIndex = 2;
            rdoThuocDangSuDung.Text = "Đang sử dụng";
            rdoThuocDangSuDung.UseVisualStyleBackColor = true;
            rdoThuocDangSuDung.CheckedChanged += rdoThuocDangSuDung_CheckedChanged;
            // 
            // rdoThuocKhoa
            // 
            rdoThuocKhoa.AutoSize = true;
            rdoThuocKhoa.Location = new Point(209, 3);
            rdoThuocKhoa.Name = "rdoThuocKhoa";
            rdoThuocKhoa.Size = new Size(85, 22);
            rdoThuocKhoa.TabIndex = 1;
            rdoThuocKhoa.Text = "Đã khóa";
            rdoThuocKhoa.UseVisualStyleBackColor = true;
            rdoThuocKhoa.CheckedChanged += rdoThuocKhoa_CheckedChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExportExcel });
            toolStrip1.Location = new Point(0, 666);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1334, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Image = Properties.Resources.excel;
            btnExportExcel.ImageTransparentColor = Color.Magenta;
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(113, 22);
            btnExportExcel.Text = "Export excel";
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // tabNguoiDung
            // 
            tabNguoiDung.Controls.Add(tableLayoutPanel4);
            tabNguoiDung.Location = new Point(4, 24);
            tabNguoiDung.Name = "tabNguoiDung";
            tabNguoiDung.Size = new Size(1340, 700);
            tabNguoiDung.TabIndex = 2;
            tabNguoiDung.Text = "Danh mục người dùng";
            tabNguoiDung.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel4.Controls.Add(dataGridView3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1340, 700);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label11);
            flowLayoutPanel4.Controls.Add(textBox8);
            flowLayoutPanel4.Controls.Add(button4);
            flowLayoutPanel4.Controls.Add(button5);
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(429, 50);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(80, 18);
            label11.TabIndex = 1;
            label11.Text = "Tên nhóm:";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.Location = new Point(89, 6);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(116, 26);
            textBox8.TabIndex = 2;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(211, 3);
            button4.Name = "button4";
            button4.Size = new Size(105, 33);
            button4.TabIndex = 0;
            button4.Text = "Thêm nhóm";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(322, 4);
            button5.Name = "button5";
            button5.Size = new Size(103, 31);
            button5.TabIndex = 3;
            button5.Text = "Xóa nhóm";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Left;
            dataGridView3.Location = new Point(3, 59);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(429, 618);
            dataGridView3.TabIndex = 1;
            // 
            // tabDanhSachReport
            // 
            tabDanhSachReport.Controls.Add(tableLayoutPanel5);
            tabDanhSachReport.Location = new Point(4, 24);
            tabDanhSachReport.Name = "tabDanhSachReport";
            tabDanhSachReport.Padding = new Padding(3);
            tabDanhSachReport.Size = new Size(1340, 700);
            tabDanhSachReport.TabIndex = 4;
            tabDanhSachReport.Text = "Danh sách report";
            tabDanhSachReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(flowLayoutPanel5, 0, 0);
            tableLayoutPanel5.Controls.Add(dgvReport, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1334, 694);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label12);
            flowLayoutPanel5.Controls.Add(txtReport_name);
            flowLayoutPanel5.Controls.Add(label16);
            flowLayoutPanel5.Controls.Add(txtNhom_Report);
            flowLayoutPanel5.Controls.Add(btnThemReport);
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(835, 41);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(3, 8);
            label12.Name = "label12";
            label12.Size = new Size(83, 18);
            label12.TabIndex = 1;
            label12.Text = "Tên report:";
            // 
            // txtReport_name
            // 
            txtReport_name.Anchor = AnchorStyles.None;
            txtReport_name.Location = new Point(92, 4);
            txtReport_name.Name = "txtReport_name";
            txtReport_name.Size = new Size(222, 26);
            txtReport_name.TabIndex = 2;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Location = new Point(320, 8);
            label16.Name = "label16";
            label16.Size = new Size(53, 18);
            label16.TabIndex = 3;
            label16.Text = "Nhóm:";
            // 
            // txtNhom_Report
            // 
            txtNhom_Report.Anchor = AnchorStyles.None;
            txtNhom_Report.Location = new Point(379, 4);
            txtNhom_Report.Name = "txtNhom_Report";
            txtNhom_Report.Size = new Size(116, 26);
            txtNhom_Report.TabIndex = 4;
            // 
            // btnThemReport
            // 
            btnThemReport.Anchor = AnchorStyles.None;
            btnThemReport.Location = new Point(501, 3);
            btnThemReport.Name = "btnThemReport";
            btnThemReport.Size = new Size(105, 29);
            btnThemReport.TabIndex = 0;
            btnThemReport.Text = "Thêm";
            btnThemReport.UseVisualStyleBackColor = true;
            btnThemReport.Click += btnThemReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { colID_Report, colReport_name, colNhomReport, colTaiReport, colThayTheReport, colTrangThaiReport, colKhoaReport });
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(3, 50);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(1328, 621);
            dgvReport.TabIndex = 1;
            dgvReport.CellContentClick += dgvReport_CellContentClick;
            // 
            // colID_Report
            // 
            colID_Report.DataPropertyName = "id_report";
            colID_Report.HeaderText = "ID_Report";
            colID_Report.Name = "colID_Report";
            // 
            // colReport_name
            // 
            colReport_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colReport_name.DataPropertyName = "report_name";
            colReport_name.HeaderText = "Tên report";
            colReport_name.Name = "colReport_name";
            colReport_name.Width = 200;
            // 
            // colNhomReport
            // 
            colNhomReport.DataPropertyName = "nhom";
            colNhomReport.HeaderText = "Nhóm";
            colNhomReport.Name = "colNhomReport";
            // 
            // colTaiReport
            // 
            colTaiReport.HeaderText = "Tải report";
            colTaiReport.Name = "colTaiReport";
            colTaiReport.Resizable = DataGridViewTriState.True;
            colTaiReport.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colThayTheReport
            // 
            colThayTheReport.HeaderText = "Thay thế";
            colThayTheReport.Name = "colThayTheReport";
            colThayTheReport.Resizable = DataGridViewTriState.True;
            colThayTheReport.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colTrangThaiReport
            // 
            colTrangThaiReport.DataPropertyName = "trang_thai";
            colTrangThaiReport.HeaderText = "Trạng thái";
            colTrangThaiReport.Name = "colTrangThaiReport";
            // 
            // colKhoaReport
            // 
            colKhoaReport.DataPropertyName = "khoa";
            colKhoaReport.HeaderText = "Khóa";
            colKhoaReport.Name = "colKhoaReport";
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 728);
            Controls.Add(tabDanhMuc);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục";
            WindowState = FormWindowState.Maximized;
            Load += frmDanhMuc_Load;
            tabDanhMuc.ResumeLayout(false);
            tabDanhMucThuoc.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMucThuoc).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabNguoiDung.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabDanhSachReport.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabDanhMuc;
        private TabPage tabDanhMucThuoc;
        private TabPage tabNguoiDung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tabDanhSachReport;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label11;
        private TextBox textBox8;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView3;
        private TableLayoutPanel tableLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label12;
        private TextBox txtReport_name;
        private Button btnThemReport;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvDanhMucThuoc;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton rdoThuocTiem;
        private FlowLayoutPanel flowLayoutPanel6;
        private RadioButton rdoTatCaThuocDanhMuc;
        private RadioButton rdoThuocKhoa;
        private RadioButton rdoThuocDangSuDung;
        private TextBox textBox13;
        private Label label14;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox11;
        private Label label9;
        private TextBox textBox10;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private Button btnThemMoi;
        private CheckBox checkBox1;
        private TextBox txtMaThuoc;
        private Label label4;
        private Label label15;
        private CheckBox checkBoxThuocTiem;
        private TextBox txtGiaBan;
        private TextBox txtGiaNhap;
        private TextBox txtHamLuong;
        private TextBox txtHoatChat;
        private TextBox txtTenThuoc;
        private TextBox txtTimThuoc;
        private RadioButton rdoTatCaThuoc;
        private RadioButton rdoThuocUong;
        private Label label16;
        private TextBox txtNhom_Report;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn colID_Report;
        private DataGridViewTextBoxColumn colReport_name;
        private DataGridViewTextBoxColumn colNhomReport;
        private DataGridViewButtonColumn colTaiReport;
        private DataGridViewButtonColumn colThayTheReport;
        private DataGridViewTextBoxColumn colTrangThaiReport;
        private DataGridViewCheckBoxColumn colKhoaReport;
        private ComboBox cboxTimNhomThuoc;
        private ComboBox cboxNhomThuoc;
        private DataGridViewTextBoxColumn colMaThuoc;
        private DataGridViewTextBoxColumn colTenThuoc;
        private DataGridViewTextBoxColumn colHoatChat;
        private DataGridViewTextBoxColumn colHamLuong;
        private DataGridViewTextBoxColumn colGiaNhap;
        private DataGridViewTextBoxColumn colGiaBan;
        private DataGridViewTextBoxColumn colDonViChan;
        private DataGridViewTextBoxColumn colHeSo;
        private DataGridViewTextBoxColumn colDonViLe;
        private DataGridViewTextBoxColumn colNhom;
        private DataGridViewCheckBoxColumn colThuocTiem;
        private DataGridViewTextBoxColumn colCachDung;
        private DataGridViewCheckBoxColumn colKhoa;
        private ToolStrip toolStrip1;
        private ToolStripButton btnExportExcel;
        private ComboBox cboxCachDung;
        private ComboBox cboxDonViLe;
    }
}