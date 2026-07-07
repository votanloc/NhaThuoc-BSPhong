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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            nhậpKhoToolStripMenuItem = new ToolStripMenuItem();
            phòngKhámToolStripMenuItem = new ToolStripMenuItem();
            nhậpXuấtTồnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            cậpNhậtPhiênBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, nhậpKhoToolStripMenuItem, phòngKhámToolStripMenuItem, nhậpXuấtTồnToolStripMenuItem, thốngKêToolStripMenuItem, cậpNhậtPhiênBảnMớiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(80, 28);
            homeToolStripMenuItem.Text = "Home";
            // 
            // nhậpKhoToolStripMenuItem
            // 
            nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            nhậpKhoToolStripMenuItem.Size = new Size(118, 28);
            nhậpKhoToolStripMenuItem.Text = "Nhập kho";
            // 
            // phòngKhámToolStripMenuItem
            // 
            phòngKhámToolStripMenuItem.Name = "phòngKhámToolStripMenuItem";
            phòngKhámToolStripMenuItem.Size = new Size(150, 28);
            phòngKhámToolStripMenuItem.Text = "Phòng khám";
            // 
            // nhậpXuấtTồnToolStripMenuItem
            // 
            nhậpXuấtTồnToolStripMenuItem.Name = "nhậpXuấtTồnToolStripMenuItem";
            nhậpXuấtTồnToolStripMenuItem.Size = new Size(171, 28);
            nhậpXuấtTồnToolStripMenuItem.Text = "Nhập Xuất Tồn";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(117, 28);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 508);
            panel1.TabIndex = 1;
            // 
            // cậpNhậtPhiênBảnMớiToolStripMenuItem
            // 
            cậpNhậtPhiênBảnMớiToolStripMenuItem.Name = "cậpNhậtPhiênBảnMớiToolStripMenuItem";
            cậpNhậtPhiênBảnMớiToolStripMenuItem.Size = new Size(264, 28);
            cậpNhậtPhiênBảnMớiToolStripMenuItem.Text = "Cập nhật phiên bản mới";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmHome";
            Text = "frmHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private ToolStripMenuItem phòngKhámToolStripMenuItem;
        private ToolStripMenuItem nhậpXuấtTồnToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem cậpNhậtPhiênBảnMớiToolStripMenuItem;
    }
}