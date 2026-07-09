using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaThuoc_BSPhong.Forms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private frmMain _main;

        public frmHome(frmMain main)
        {
            InitializeComponent();
            _main = main;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmHome());
        }
        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmNhapKho());
        }

        private void btnPhongKham1_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmPhongKham());
        }

        private void btnNhapKho1_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmNhapKho());
        }

        private void btnNhapXuatTon1_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmNhapXuatTon());
        }

        private void btnThongKe1_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmThongKe());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            _main.OpenForm(new frmDanhMuc());
        }
    }
}
