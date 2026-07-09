namespace NhaThuoc_BSPhong.Forms
{
    partial class frmHome
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
            pnlMain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnThongKe1 = new Button();
            btnNhapXuatTon1 = new Button();
            btnNhapKho1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnPhongKham1 = new Button();
            btnDanhMuc = new Button();
            pnlMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1373, 650);
            pnlMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1373, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(196, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(980, 157);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 110);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 117);
            label4.Name = "label4";
            label4.Size = new Size(195, 24);
            label4.TabIndex = 3;
            label4.Text = "SĐT: 0929 369 699";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 86);
            label5.Name = "label5";
            label5.Size = new Size(778, 24);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ: 17 Đường Huỳnh Thị Hương, KP An Quới, P. Trảng Bàng, T. Tây Ninh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Green;
            label2.Location = new Point(171, 28);
            label2.Name = "label2";
            label2.Size = new Size(151, 24);
            label2.TabIndex = 0;
            label2.Text = "PHÒNG KHÁM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(170, 52);
            label3.Name = "label3";
            label3.Size = new Size(152, 34);
            label3.TabIndex = 1;
            label3.Text = "AN THỊNH";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(btnDanhMuc);
            groupBox1.Controls.Add(btnThongKe1);
            groupBox1.Controls.Add(btnNhapXuatTon1);
            groupBox1.Controls.Add(btnNhapKho1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnPhongKham1);
            groupBox1.Location = new Point(399, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnThongKe1
            // 
            btnThongKe1.Location = new Point(34, 153);
            btnThongKe1.Name = "btnThongKe1";
            btnThongKe1.Size = new Size(158, 62);
            btnThongKe1.TabIndex = 5;
            btnThongKe1.Text = "Thống kê";
            btnThongKe1.UseVisualStyleBackColor = true;
            btnThongKe1.Click += btnThongKe1_Click;
            // 
            // btnNhapXuatTon1
            // 
            btnNhapXuatTon1.Location = new Point(399, 56);
            btnNhapXuatTon1.Name = "btnNhapXuatTon1";
            btnNhapXuatTon1.Size = new Size(158, 62);
            btnNhapXuatTon1.TabIndex = 4;
            btnNhapXuatTon1.Text = "Nhập xuất tồn";
            btnNhapXuatTon1.UseVisualStyleBackColor = true;
            btnNhapXuatTon1.Click += btnNhapXuatTon1_Click;
            // 
            // btnNhapKho1
            // 
            btnNhapKho1.Location = new Point(216, 56);
            btnNhapKho1.Name = "btnNhapKho1";
            btnNhapKho1.Size = new Size(158, 62);
            btnNhapKho1.TabIndex = 3;
            btnNhapKho1.Text = "Nhập kho";
            btnNhapKho1.UseVisualStyleBackColor = true;
            btnNhapKho1.Click += btnNhapKho1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Arial", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(452, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 26);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(337, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 18);
            label1.TabIndex = 1;
            label1.Text = "Ngày làm việc:";
            // 
            // btnPhongKham1
            // 
            btnPhongKham1.Location = new Point(34, 56);
            btnPhongKham1.Name = "btnPhongKham1";
            btnPhongKham1.Size = new Size(158, 62);
            btnPhongKham1.TabIndex = 0;
            btnPhongKham1.Text = "Phòng khám";
            btnPhongKham1.UseVisualStyleBackColor = true;
            btnPhongKham1.Click += btnPhongKham1_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Location = new Point(216, 153);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(158, 62);
            btnDanhMuc.TabIndex = 6;
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 650);
            Controls.Add(pnlMain);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmHome";
            Text = "frmHome";
            WindowState = FormWindowState.Maximized;
            Load += frmHome_Load;
            pnlMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button btnThongKe1;
        private Button btnNhapXuatTon1;
        private Button btnNhapKho1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnPhongKham1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnDanhMuc;
    }
}