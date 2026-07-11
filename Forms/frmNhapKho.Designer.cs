namespace NhaThuoc_BSPhong.Forms
{
    partial class frmNhapKho
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            label12 = new Label();
            cboxTimLyDo = new ComboBox();
            txtTimMaPhieu = new TextBox();
            label11 = new Label();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            dgvTimPhieuNhap = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colLyDoNhap = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colDienGiai = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            txtDienGiai = new TextBox();
            label13 = new Label();
            label9 = new Label();
            txtTongTien = new TextBox();
            label8 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label7 = new Label();
            cboxLyDoNhap = new ComboBox();
            txtMaPhieuNhap = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnThemPhieuNhapKho = new Button();
            btnCapNhatPhieuNhapKho = new Button();
            btnXoaPhieuNhapKho = new Button();
            checkBoxKhoaPhieuNhapKho = new CheckBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvNhapKhoChiTiet = new DataGridView();
            colSelect = new DataGridViewCheckBoxColumn();
            colAuto_id = new DataGridViewTextBoxColumn();
            colMaPhieu1 = new DataGridViewTextBoxColumn();
            colMaThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc = new DataGridViewTextBoxColumn();
            colDonVi = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            colHSD = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            txtTimThuoc = new TextBox();
            label5 = new Label();
            txtSoLuong = new TextBox();
            label10 = new Label();
            dtpHSD = new DateTimePicker();
            btnThemThuocVaoPhieuNhapKho = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnXoaThuocPhieuNhapKho = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimPhieuNhap).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapKhoChiTiet).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1399, 730);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Controls.Add(dgvTimPhieuNhap, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(444, 724);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cboxTimLyDo);
            panel1.Controls.Add(txtTimMaPhieu);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 125);
            panel1.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 85);
            label12.Name = "label12";
            label12.Size = new Size(88, 18);
            label12.TabIndex = 7;
            label12.Text = "Lý do nhập:";
            // 
            // cboxTimLyDo
            // 
            cboxTimLyDo.FormattingEnabled = true;
            cboxTimLyDo.Items.AddRange(new object[] { "Nhập kho", "Nhập điều chỉnh" });
            cboxTimLyDo.Location = new Point(102, 82);
            cboxTimLyDo.Name = "cboxTimLyDo";
            cboxTimLyDo.Size = new Size(301, 26);
            cboxTimLyDo.TabIndex = 6;
            cboxTimLyDo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtTimMaPhieu
            // 
            txtTimMaPhieu.Location = new Point(81, 45);
            txtTimMaPhieu.Name = "txtTimMaPhieu";
            txtTimMaPhieu.Size = new Size(322, 26);
            txtTimMaPhieu.TabIndex = 5;
            txtTimMaPhieu.TextChanged += txtTimMaPhieu_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 52);
            label11.Name = "label11";
            label11.Size = new Size(76, 18);
            label11.TabIndex = 4;
            label11.Text = "Mã phiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 15);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(287, 13);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(116, 26);
            dtpDenNgay.TabIndex = 3;
            dtpDenNgay.ValueChanged += dtpDenNgay_ValueChanged;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(81, 13);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(116, 26);
            dtpTuNgay.TabIndex = 1;
            dtpTuNgay.ValueChanged += dtpTuNgay_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // dgvTimPhieuNhap
            // 
            dgvTimPhieuNhap.AllowUserToAddRows = false;
            dgvTimPhieuNhap.BackgroundColor = Color.White;
            dgvTimPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colLyDoNhap, colTongTien, colDienGiai, colNgayNhap });
            dgvTimPhieuNhap.Dock = DockStyle.Fill;
            dgvTimPhieuNhap.Location = new Point(3, 134);
            dgvTimPhieuNhap.Name = "dgvTimPhieuNhap";
            dgvTimPhieuNhap.ReadOnly = true;
            dgvTimPhieuNhap.Size = new Size(438, 587);
            dgvTimPhieuNhap.TabIndex = 1;
            dgvTimPhieuNhap.CellMouseClick += dgvTimPhieuNhap_CellMouseClick;
            // 
            // colMaPhieu
            // 
            colMaPhieu.DataPropertyName = "ma_phieu_nhap";
            colMaPhieu.HeaderText = "Mã phiếu";
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.ReadOnly = true;
            // 
            // colLyDoNhap
            // 
            colLyDoNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLyDoNhap.DataPropertyName = "ly_do_nhap";
            colLyDoNhap.HeaderText = "Lý do nhập";
            colLyDoNhap.Name = "colLyDoNhap";
            colLyDoNhap.ReadOnly = true;
            colLyDoNhap.Width = 150;
            // 
            // colTongTien
            // 
            colTongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTongTien.DataPropertyName = "tong_tien";
            dataGridViewCellStyle1.Format = "#,###";
            colTongTien.DefaultCellStyle = dataGridViewCellStyle1;
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // colDienGiai
            // 
            colDienGiai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDienGiai.DataPropertyName = "dien_giai";
            colDienGiai.HeaderText = "Diễn giải";
            colDienGiai.Name = "colDienGiai";
            colDienGiai.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            colNgayNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNgayNhap.DataPropertyName = "ngay_nhap";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm:ss";
            colNgayNhap.DefaultCellStyle = dataGridViewCellStyle2;
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.ReadOnly = true;
            colNgayNhap.Width = 200;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(453, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(943, 724);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDienGiai);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpNgayNhap);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboxLyDoNhap);
            groupBox2.Controls.Add(txtMaPhieuNhap);
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(937, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtDienGiai
            // 
            txtDienGiai.Location = new Point(97, 104);
            txtDienGiai.Name = "txtDienGiai";
            txtDienGiai.Size = new Size(420, 26);
            txtDienGiai.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 107);
            label13.Name = "label13";
            label13.Size = new Size(75, 18);
            label13.TabIndex = 10;
            label13.Text = "Diễn giải:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(528, 111);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 8;
            label9.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(606, 107);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(135, 26);
            txtTongTien.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 22);
            label8.Name = "label8";
            label8.Size = new Size(86, 18);
            label8.TabIndex = 6;
            label8.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.Enabled = false;
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(97, 16);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(190, 26);
            dtpNgayNhap.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 71);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 5;
            label7.Text = "Lý do nhập:";
            // 
            // cboxLyDoNhap
            // 
            cboxLyDoNhap.FormattingEnabled = true;
            cboxLyDoNhap.Items.AddRange(new object[] { "Nhập kho", "Nhập điều chỉnh" });
            cboxLyDoNhap.Location = new Point(305, 65);
            cboxLyDoNhap.Name = "cboxLyDoNhap";
            cboxLyDoNhap.Size = new Size(212, 26);
            cboxLyDoNhap.TabIndex = 4;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Enabled = false;
            txtMaPhieuNhap.Location = new Point(98, 65);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(100, 26);
            txtMaPhieuNhap.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnThemPhieuNhapKho);
            flowLayoutPanel2.Controls.Add(btnCapNhatPhieuNhapKho);
            flowLayoutPanel2.Controls.Add(btnXoaPhieuNhapKho);
            flowLayoutPanel2.Controls.Add(checkBoxKhoaPhieuNhapKho);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 149);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(931, 30);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnThemPhieuNhapKho
            // 
            btnThemPhieuNhapKho.Anchor = AnchorStyles.None;
            btnThemPhieuNhapKho.Location = new Point(3, 3);
            btnThemPhieuNhapKho.Name = "btnThemPhieuNhapKho";
            btnThemPhieuNhapKho.Size = new Size(119, 25);
            btnThemPhieuNhapKho.TabIndex = 0;
            btnThemPhieuNhapKho.Text = "Thêm phiếu mới";
            btnThemPhieuNhapKho.UseVisualStyleBackColor = true;
            btnThemPhieuNhapKho.Click += btnThemPhieuNhapKho_Click;
            // 
            // btnCapNhatPhieuNhapKho
            // 
            btnCapNhatPhieuNhapKho.Anchor = AnchorStyles.None;
            btnCapNhatPhieuNhapKho.Location = new Point(128, 3);
            btnCapNhatPhieuNhapKho.Name = "btnCapNhatPhieuNhapKho";
            btnCapNhatPhieuNhapKho.Size = new Size(119, 25);
            btnCapNhatPhieuNhapKho.TabIndex = 1;
            btnCapNhatPhieuNhapKho.Text = "Lưu/Cập nhật";
            btnCapNhatPhieuNhapKho.UseVisualStyleBackColor = true;
            btnCapNhatPhieuNhapKho.Click += btnCapNhatPhieuNhapKho_Click;
            // 
            // btnXoaPhieuNhapKho
            // 
            btnXoaPhieuNhapKho.Anchor = AnchorStyles.None;
            btnXoaPhieuNhapKho.Location = new Point(253, 3);
            btnXoaPhieuNhapKho.Name = "btnXoaPhieuNhapKho";
            btnXoaPhieuNhapKho.Size = new Size(119, 25);
            btnXoaPhieuNhapKho.TabIndex = 3;
            btnXoaPhieuNhapKho.Text = "Xóa phiếu";
            btnXoaPhieuNhapKho.UseVisualStyleBackColor = true;
            // 
            // checkBoxKhoaPhieuNhapKho
            // 
            checkBoxKhoaPhieuNhapKho.AutoSize = true;
            checkBoxKhoaPhieuNhapKho.Location = new Point(378, 3);
            checkBoxKhoaPhieuNhapKho.Name = "checkBoxKhoaPhieuNhapKho";
            checkBoxKhoaPhieuNhapKho.Size = new Size(106, 22);
            checkBoxKhoaPhieuNhapKho.TabIndex = 4;
            checkBoxKhoaPhieuNhapKho.Text = "Khóa phiếu";
            checkBoxKhoaPhieuNhapKho.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 68);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 2;
            label4.Text = "Mã phiếu:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dgvNhapKhoChiTiet, 0, 1);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 191);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(937, 530);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // dgvNhapKhoChiTiet
            // 
            dgvNhapKhoChiTiet.AllowUserToAddRows = false;
            dgvNhapKhoChiTiet.BackgroundColor = Color.White;
            dgvNhapKhoChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapKhoChiTiet.Columns.AddRange(new DataGridViewColumn[] { colSelect, colAuto_id, colMaPhieu1, colMaThuoc, colTenThuoc, colDonVi, colSoLuong, colGia, colThanhTien, colHSD });
            dgvNhapKhoChiTiet.Dock = DockStyle.Fill;
            dgvNhapKhoChiTiet.Location = new Point(3, 45);
            dgvNhapKhoChiTiet.Name = "dgvNhapKhoChiTiet";
            dgvNhapKhoChiTiet.RowHeadersVisible = false;
            dgvNhapKhoChiTiet.Size = new Size(931, 442);
            dgvNhapKhoChiTiet.TabIndex = 2;
            // 
            // colSelect
            // 
            colSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSelect.HeaderText = "Chọn";
            colSelect.Name = "colSelect";
            colSelect.Resizable = DataGridViewTriState.True;
            colSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            colSelect.Width = 70;
            // 
            // colAuto_id
            // 
            colAuto_id.DataPropertyName = "auto_id";
            colAuto_id.HeaderText = "auto_id";
            colAuto_id.Name = "colAuto_id";
            colAuto_id.Visible = false;
            // 
            // colMaPhieu1
            // 
            colMaPhieu1.DataPropertyName = "ma_phieu_nhap";
            colMaPhieu1.HeaderText = "Mã Phiếu";
            colMaPhieu1.Name = "colMaPhieu1";
            colMaPhieu1.ReadOnly = true;
            // 
            // colMaThuoc
            // 
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
            colTenThuoc.Width = 200;
            // 
            // colDonVi
            // 
            colDonVi.DataPropertyName = "don_vi";
            colDonVi.HeaderText = "Đơn vị";
            colDonVi.Name = "colDonVi";
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "so_luong";
            dataGridViewCellStyle3.Format = "#,###";
            colSoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.Name = "colSoLuong";
            // 
            // colGia
            // 
            colGia.DataPropertyName = "don_gia";
            dataGridViewCellStyle4.Format = "#,###";
            colGia.DefaultCellStyle = dataGridViewCellStyle4;
            colGia.HeaderText = "Đơn giá";
            colGia.Name = "colGia";
            // 
            // colThanhTien
            // 
            colThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colThanhTien.DataPropertyName = "thanh_tien";
            dataGridViewCellStyle5.Format = "#,###";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle5;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.Width = 120;
            // 
            // colHSD
            // 
            colHSD.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHSD.DataPropertyName = "hsd";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            colHSD.DefaultCellStyle = dataGridViewCellStyle6;
            colHSD.HeaderText = "HSD";
            colHSD.Name = "colHSD";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(txtTimThuoc);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(txtSoLuong);
            flowLayoutPanel3.Controls.Add(label10);
            flowLayoutPanel3.Controls.Add(dtpHSD);
            flowLayoutPanel3.Controls.Add(btnThemThuocVaoPhieuNhapKho);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(931, 36);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 0;
            label3.Text = "Thuốc";
            // 
            // txtTimThuoc
            // 
            txtTimThuoc.Anchor = AnchorStyles.None;
            txtTimThuoc.Location = new Point(59, 3);
            txtTimThuoc.Name = "txtTimThuoc";
            txtTimThuoc.Size = new Size(178, 26);
            txtTimThuoc.TabIndex = 1;
            txtTimThuoc.TextChanged += txtTimThuoc_TextChanged;
            txtTimThuoc.KeyDown += txtTimThuoc_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(243, 7);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 2;
            label5.Text = "Số lượng nhập";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.None;
            txtSoLuong.Location = new Point(361, 3);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(60, 26);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.KeyDown += txtSoLuong_KeyDown;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(427, 7);
            label10.Name = "label10";
            label10.Size = new Size(46, 18);
            label10.TabIndex = 8;
            label10.Text = "HSD:";
            // 
            // dtpHSD
            // 
            dtpHSD.Anchor = AnchorStyles.None;
            dtpHSD.CustomFormat = "dd/MM/yyyy";
            dtpHSD.Format = DateTimePickerFormat.Custom;
            dtpHSD.Location = new Point(479, 3);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(101, 26);
            dtpHSD.TabIndex = 9;
            dtpHSD.KeyDown += dtpHSD_KeyDown;
            // 
            // btnThemThuocVaoPhieuNhapKho
            // 
            btnThemThuocVaoPhieuNhapKho.Anchor = AnchorStyles.None;
            btnThemThuocVaoPhieuNhapKho.Location = new Point(586, 3);
            btnThemThuocVaoPhieuNhapKho.Name = "btnThemThuocVaoPhieuNhapKho";
            btnThemThuocVaoPhieuNhapKho.Size = new Size(119, 25);
            btnThemThuocVaoPhieuNhapKho.TabIndex = 4;
            btnThemThuocVaoPhieuNhapKho.Text = "Thêm";
            btnThemThuocVaoPhieuNhapKho.UseVisualStyleBackColor = true;
            btnThemThuocVaoPhieuNhapKho.Click += btnThemThuocVaoPhieuNhapKho_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(btnXoaThuocPhieuNhapKho);
            flowLayoutPanel4.Location = new Point(3, 493);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(806, 34);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // btnXoaThuocPhieuNhapKho
            // 
            btnXoaThuocPhieuNhapKho.Anchor = AnchorStyles.None;
            btnXoaThuocPhieuNhapKho.Location = new Point(3, 3);
            btnXoaThuocPhieuNhapKho.Name = "btnXoaThuocPhieuNhapKho";
            btnXoaThuocPhieuNhapKho.Size = new Size(107, 28);
            btnXoaThuocPhieuNhapKho.TabIndex = 0;
            btnXoaThuocPhieuNhapKho.Text = "Xóa thuốc";
            btnXoaThuocPhieuNhapKho.UseVisualStyleBackColor = true;
            btnXoaThuocPhieuNhapKho.Click += btnXoaThuocPhieuNhapKho_Click;
            // 
            // frmNhapKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 730);
            Controls.Add(tableLayoutPanel1);
            Name = "frmNhapKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhapKho";
            WindowState = FormWindowState.Maximized;
            Load += frmNhapKho_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimPhieuNhap).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhapKhoChiTiet).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnThemPhieuNhapKho;
        private DataGridView dgvTimPhieuNhap;
        private TextBox txtMaPhieuNhap;
        private Button btnCapNhatPhieuNhapKho;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private TextBox txtTimThuoc;
        private Label label5;
        private TextBox txtSoLuong;
        private Button btnThemThuocVaoPhieuNhapKho;
        private Button btnXoaPhieuNhapKho;
        private CheckBox checkBoxKhoaPhieuNhapKho;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dgvNhapKhoChiTiet;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btnXoaThuocPhieuNhapKho;
        private Label label9;
        private TextBox txtTongTien;
        private Label label8;
        private DateTimePicker dtpNgayNhap;
        private Label label7;
        private ComboBox cboxLyDoNhap;
        private Label label10;
        private DateTimePicker dtpHSD;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private Label label12;
        private ComboBox cboxTimLyDo;
        private TextBox txtTimMaPhieu;
        private Label label11;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colLyDoNhap;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colDienGiai;
        private DataGridViewTextBoxColumn colNgayNhap;
        private TextBox txtDienGiai;
        private Label label13;
        private DataGridViewCheckBoxColumn colSelect;
        private DataGridViewTextBoxColumn colAuto_id;
        private DataGridViewTextBoxColumn colMaPhieu1;
        private DataGridViewTextBoxColumn colMaThuoc;
        private DataGridViewTextBoxColumn colTenThuoc;
        private DataGridViewTextBoxColumn colDonVi;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private DataGridViewTextBoxColumn colHSD;
    }
}