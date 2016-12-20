using BUS;
using DTO;
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
    public partial class frmNhanVien : MetroFramework.Forms.MetroForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            foreach (NhanVien nv in NhanVienBUS.GetAll())
            {
                dtgNhanVien.Rows.Add(nv.MaNV, nv.TenNV, nv.GioiTinh, nv.NgaySinh.Value.Date, nv.DiaChi, nv.SDT);
            }
        }

        private void mTThem_Click(object sender, EventArgs e)
        {
            
        }

        private void mTXoa_Click(object sender, EventArgs e)
        {

        }

        private void mTSua_Click(object sender, EventArgs e)
        {

        }
    }
}
