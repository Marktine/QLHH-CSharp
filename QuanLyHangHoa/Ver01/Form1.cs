using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ver01
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            frmHangHoa a = new frmHangHoa();
            a.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mTHD_Click(object sender, EventArgs e)
        {
            frmHoaDon b = new frmHoaDon();
            b.ShowDialog();
        }

        private void mtNV_Click(object sender, EventArgs e)
        {
            frmNhanVien c = new frmNhanVien();
            c.ShowDialog();
        }

        private void mTKH_Click(object sender, EventArgs e)
        {
            frmKhachHang d = new frmKhachHang();
            d.ShowDialog();
        }
    }
}
