namespace PhongKham.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            btnHome = new ToolStripMenuItem();
            btnNhapKho = new ToolStripMenuItem();
            btnPhongKham = new ToolStripMenuItem();
            btnNhapXuatTon = new ToolStripMenuItem();
            btnDanhMuc = new ToolStripMenuItem();
            btnThongKe = new ToolStripMenuItem();
            btnHoTro = new ToolStripMenuItem();
            btnCapNhat = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            pnlMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnHome, btnNhapKho, btnPhongKham, btnNhapXuatTon, btnDanhMuc, btnThongKe, btnHoTro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1295, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnHome
            // 
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(80, 28);
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(118, 28);
            btnNhapKho.Text = "Nhập kho";
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // btnPhongKham
            // 
            btnPhongKham.Name = "btnPhongKham";
            btnPhongKham.Size = new Size(150, 28);
            btnPhongKham.Text = "Phòng khám";
            btnPhongKham.Click += btnPhongKham_Click;
            // 
            // btnNhapXuatTon
            // 
            btnNhapXuatTon.Name = "btnNhapXuatTon";
            btnNhapXuatTon.Size = new Size(171, 28);
            btnNhapXuatTon.Text = "Nhập Xuất Tồn";
            btnNhapXuatTon.Click += btnNhapXuatTon_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(125, 28);
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(117, 28);
            btnThongKe.Text = "Thống kê";
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnHoTro
            // 
            btnHoTro.DropDownItems.AddRange(new ToolStripItem[] { btnCapNhat, hướngDẫnSửDụngToolStripMenuItem });
            btnHoTro.Name = "btnHoTro";
            btnHoTro.Size = new Size(85, 28);
            btnHoTro.Text = "Hỗ trợ";
            btnHoTro.Click += btnCapNhat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(322, 28);
            btnCapNhat.Text = "Cập nhật phiên bản mới";
            btnCapNhat.Click += btnCapNhat_Click_1;
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(322, 28);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 32);
            pnlMain.Margin = new Padding(4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1295, 555);
            pnlMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 587);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnHome;
        private ToolStripMenuItem btnNhapKho;
        private ToolStripMenuItem btnPhongKham;
        private ToolStripMenuItem btnNhapXuatTon;
        private ToolStripMenuItem btnThongKe;
        private ToolStripMenuItem btnHoTro;
        private Panel pnlMain;
        private ToolStripMenuItem btnDanhMuc;
        private ToolStripMenuItem btnCapNhat;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    }
}