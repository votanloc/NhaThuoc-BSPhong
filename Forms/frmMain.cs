using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace NhaThuoc_BSPhong.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenForm(new frmHome(this));
        }

        private Form currentForm;

        public void OpenForm(Form frm)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = frm;

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);

            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHome(this));
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNhapKho());
        }

        private void btnPhongKham_Click(object sender, EventArgs e)
        {
            OpenForm(new frmPhongKham());
        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string updateExe = Path.Combine(
                    Application.StartupPath,
                    "update.exe");

                if (!File.Exists(updateExe))
                {
                    MessageBox.Show(
                        "Không tìm thấy update.exe",
                        "Thông báo");
                    return;
                }

                Process.Start(updateExe);

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapXuatTon_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNhapXuatTon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenForm(new frmThongKe());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenForm(new frmDanhMuc());
        }
    }
}
