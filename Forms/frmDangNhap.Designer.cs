namespace PhongKham.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            checkboxSavePass = new CheckBox();
            txtPW = new TextBox();
            texUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(452, 248);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(checkboxSavePass);
            groupBox1.Controls.Add(txtPW);
            groupBox1.Controls.Add(texUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(97, 36);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(258, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(141, 121);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 28);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(22, 121);
            btnDangNhap.Margin = new Padding(4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(111, 28);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // checkboxSavePass
            // 
            checkboxSavePass.AutoSize = true;
            checkboxSavePass.Checked = true;
            checkboxSavePass.CheckState = CheckState.Checked;
            checkboxSavePass.Location = new Point(22, 91);
            checkboxSavePass.Margin = new Padding(4);
            checkboxSavePass.Name = "checkboxSavePass";
            checkboxSavePass.Size = new Size(122, 22);
            checkboxSavePass.TabIndex = 4;
            checkboxSavePass.Text = "Lưu mật khẩu";
            checkboxSavePass.UseVisualStyleBackColor = true;
            checkboxSavePass.KeyDown += checkboxSavePass_KeyDown;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(110, 57);
            txtPW.Margin = new Padding(4);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(127, 26);
            txtPW.TabIndex = 3;
            txtPW.Text = "lpsoft.com";
            txtPW.UseSystemPasswordChar = true;
            txtPW.KeyDown += txtPW_KeyDown;
            // 
            // texUser
            // 
            texUser.Location = new Point(110, 20);
            texUser.Margin = new Padding(4);
            texUser.Name = "texUser";
            texUser.Size = new Size(127, 26);
            texUser.TabIndex = 2;
            texUser.Text = "admin";
            texUser.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 248);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnDangNhap;
        private CheckBox checkboxSavePass;
        private TextBox txtPW;
        private TextBox texUser;
        private Label label2;
        private Label label1;
    }
}