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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginSuccess();
        }

        private void LoginSuccess()
        {
            Cursor.Current = Cursors.WaitCursor;

            Helpers.MySqlHelper.WarmUp();
            this.Hide();

            using (frmMain f = new frmMain())
            {
                f.ShowDialog();
            }

            this.Close();
        }
    }
}
