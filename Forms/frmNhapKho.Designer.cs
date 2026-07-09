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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            dgvTimPhieuNhap = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colLyDoNhap = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            checkBox1 = new CheckBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            colMaPhieu1 = new DataGridViewTextBoxColumn();
            colMaThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            colHSD = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            dateTimePicker4 = new DateTimePicker();
            button4 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button5 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimPhieuNhap).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox6);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 125);
            panel1.TabIndex = 6;
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
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(287, 13);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(116, 26);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(81, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(116, 26);
            dateTimePicker1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 58);
            label11.Name = "label11";
            label11.Size = new Size(77, 18);
            label11.TabIndex = 4;
            label11.Text = "Họ và tên:";
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
            // textBox6
            // 
            textBox6.Location = new Point(89, 54);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(314, 26);
            textBox6.TabIndex = 5;
            // 
            // dgvTimPhieuNhap
            // 
            dgvTimPhieuNhap.BackgroundColor = Color.White;
            dgvTimPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colLyDoNhap, colTongTien, colNgayNhap });
            dgvTimPhieuNhap.Dock = DockStyle.Fill;
            dgvTimPhieuNhap.Location = new Point(3, 134);
            dgvTimPhieuNhap.Name = "dgvTimPhieuNhap";
            dgvTimPhieuNhap.Size = new Size(438, 587);
            dgvTimPhieuNhap.TabIndex = 1;
            // 
            // colMaPhieu
            // 
            colMaPhieu.HeaderText = "Mã phiếu";
            colMaPhieu.Name = "colMaPhieu";
            // 
            // colLyDoNhap
            // 
            colLyDoNhap.HeaderText = "Lý do nhập";
            colLyDoNhap.Name = "colLyDoNhap";
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.Name = "colTongTien";
            // 
            // colNgayNhap
            // 
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.Name = "colNgayNhap";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(453, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.10687F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 73.89313F));
            tableLayoutPanel2.Size = new Size(943, 724);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(937, 183);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(521, 69);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 8;
            label9.Text = "Tổng tiền";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(599, 65);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 26);
            textBox5.TabIndex = 9;
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
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(97, 16);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(101, 26);
            dateTimePicker3.TabIndex = 7;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nhập kho", "Nhập điều chỉnh" });
            comboBox1.Location = new Point(305, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 26);
            comboBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Controls.Add(checkBox1);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 150);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(931, 30);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 25);
            button1.TabIndex = 0;
            button1.Text = "Thêm phiếu mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(128, 3);
            button2.Name = "button2";
            button2.Size = new Size(119, 25);
            button2.TabIndex = 1;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(253, 3);
            button6.Name = "button6";
            button6.Size = new Size(119, 25);
            button6.TabIndex = 3;
            button6.Text = "Xóa phiếu";
            button6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(378, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 22);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Khóa phiếu";
            checkBox1.UseVisualStyleBackColor = true;
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
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 192);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(937, 529);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu1, colMaThuoc, colTenThuoc, colSoLuong, colGia, colThanhTien, colHSD });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(931, 441);
            dataGridView1.TabIndex = 2;
            // 
            // colMaPhieu1
            // 
            colMaPhieu1.HeaderText = "Mã Phiếu";
            colMaPhieu1.Name = "colMaPhieu1";
            colMaPhieu1.ReadOnly = true;
            // 
            // colMaThuoc
            // 
            colMaThuoc.HeaderText = "Mã thuốc";
            colMaThuoc.Name = "colMaThuoc";
            // 
            // colTenThuoc
            // 
            colTenThuoc.HeaderText = "Tên thuốc";
            colTenThuoc.Name = "colTenThuoc";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.Name = "colSoLuong";
            // 
            // colGia
            // 
            colGia.HeaderText = "Giá";
            colGia.Name = "colGia";
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            // 
            // colHSD
            // 
            colHSD.HeaderText = "HSD";
            colHSD.Name = "colHSD";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(textBox1);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(textBox3);
            flowLayoutPanel3.Controls.Add(label10);
            flowLayoutPanel3.Controls.Add(dateTimePicker4);
            flowLayoutPanel3.Controls.Add(button4);
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(59, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 26);
            textBox1.TabIndex = 1;
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
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(361, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 26);
            textBox3.TabIndex = 3;
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
            // dateTimePicker4
            // 
            dateTimePicker4.Anchor = AnchorStyles.None;
            dateTimePicker4.CustomFormat = "dd/MM/yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(479, 3);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(101, 26);
            dateTimePicker4.TabIndex = 9;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(586, 3);
            button4.Name = "button4";
            button4.Size = new Size(119, 25);
            button4.TabIndex = 4;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button5);
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Controls.Add(textBox4);
            flowLayoutPanel4.Location = new Point(3, 492);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(806, 34);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(107, 28);
            button5.TabIndex = 0;
            button5.Text = "Xóa thuốc";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(116, 8);
            label6.Name = "label6";
            label6.Size = new Size(72, 18);
            label6.TabIndex = 1;
            label6.Text = "Tổng tiền";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(194, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 26);
            textBox4.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private DataGridView dgvTimPhieuNhap;
        private TextBox textBox2;
        private Button button2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private Button button4;
        private Button button6;
        private CheckBox checkBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button5;
        private Label label6;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn colMaPhieu1;
        private DataGridViewTextBoxColumn colMaThuoc;
        private DataGridViewTextBoxColumn colTenThuoc;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private DataGridViewTextBoxColumn colHSD;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colLyDoNhap;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colNgayNhap;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private ComboBox comboBox1;
        private Label label10;
        private DateTimePicker dateTimePicker4;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label11;
        private TextBox textBox6;
        private Panel panel1;
    }
}