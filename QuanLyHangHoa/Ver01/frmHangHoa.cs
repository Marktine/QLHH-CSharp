using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using BUS;
using DTO;
namespace Ver01
{
    public partial class frmHangHoa : MetroFramework.Forms.MetroForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void clearData()
        {
            txtGiaNhap.Clear();
            txtLoaiHang.Clear();
            txtMaHH.Clear();
            txtNguoiNhap.Clear();
            txtSearch.Clear();
            txtSoLuong.Clear();
            txtTenHH.Clear();
            txtTenNSX.Clear();
            dtpNgayNhap.Value = DateTime.Now;
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            hangHoaBindingSource.DataSource = HangHoaBUS.GetAll();
            txtLoiNhuan.Text = Properties.Settings.Default.LoiNhuan.ToString();
            cmbSearch.Items.Add("Mã hàng hóa");
            cmbSearch.Items.Add("Tên hàng hóa");
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            double Thue, Lai;
            long GiaBan;
            int soLuongNhanVien = NhanVienBUS.GetSLVN();
            float GiaNhap = float.Parse(txtGiaNhap.Text);
            Thue = GiaNhap * 0.1;
            Lai = float.Parse(txtLoiNhuan.Text)/100;
            GiaBan = Convert.ToInt64(GiaNhap + Thue + GiaNhap * Lai + GiaNhap * (soLuongNhanVien * 0.012));
            try
            {
                HangHoa h = new HangHoa()
                {
                    MaHang = txtMaHH.Text,
                    TenHang = txtTenHH.Text,
                    LoaiHH = txtLoaiHang.Text,
                    TenNSX = txtTenNSX.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    NgNhapHang = txtNguoiNhap.Text,
                    GiaNhap = float.Parse(txtGiaNhap.Text),
                    NgayNhap = dtpNgayNhap.Value,
                    SoLuongMin = 0,
                    LoiNhuan = GiaNhap * Lai,
                    DonGia = GiaBan,
                    TinhTrang = true,
                };
                HangHoaBUS.Insert(h);
                //clearData();
            }
            catch(DbUpdateException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Có lỗi xảy ra trong quá trình nhập sản phẩm, vui lòng xem lại thông tin sản phẩm cần thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (hangHoaBindingSource.Current == null)
                return;
            if(MetroFramework.MetroMessageBox.Show(this,"Bạn có chắc là muốn xóa sản phẩm này ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) == DialogResult.Yes)
            {
                foreach(DataGridViewRow item in this.dtgHangHoa.SelectedRows)
                {
                    HangHoa h = hangHoaBindingSource.Current as HangHoa;
                           h.TinhTrang = false;
                    dtgHangHoa.Rows.RemoveAt(item.Index);
                    HangHoaBUS.Update(h);
                }
                //dtgHangHoa.Rows.Clear();
                //foreach (HangHoa h in HangHoaBUS.GetAll())
                //{
                //    dtgHangHoa.Rows.Add(h.MaHang, h.TenHang, h.LoaiHH, h.TenNSX, h.GiaNhap, 0, h.SoLuong, h.NgayNhap, h.NgNhapHang);
                //}
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (hangHoaBindingSource.Current == null)
                return;
            HangHoaBUS.Update(hangHoaBindingSource.Current as HangHoa);
            hangHoaBindingSource.Clear();
            hangHoaBindingSource.DataSource = HangHoaBUS.GetAll();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            hangHoaBindingSource.Clear();
            hangHoaBindingSource.DataSource = HangHoaBUS.GetAll();
            cmbSearch.SelectedIndex = -1;
            //clearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this,"Hãy nhập một thứ để tìm kiếm.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
            else if(cmbSearch.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this,"Chọn mục mà bạn muốn tìm kiếm.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
            else if(cmbSearch.SelectedItem == "Mã hàng hóa")
            {
                try
                {
                    hangHoaBindingSource.Clear();
                    hangHoaBindingSource.DataSource = HangHoaBUS.GetById(txtSearch.Text);
                }
                catch(System.ArgumentException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Dữ liệu tìm kiếm không đúng yêu cầu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    hangHoaBindingSource.DataSource = HangHoaBUS.GetAll();
                }

            }
            else if (cmbSearch.SelectedItem == "Tên hàng hóa")
            {
                try
                {
                    hangHoaBindingSource.Clear();
                    hangHoaBindingSource.DataSource = HangHoaBUS.GetByName(txtSearch.Text);
                }
                catch(System.ArgumentException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Dữ liệu tìm kiếm không đúng yêu cầu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    hangHoaBindingSource.DataSource = HangHoaBUS.GetAll();
                }
            }
        }

        private bool isContainsCharacter(string str)
        {
            int parsedValue;
            if(!int.TryParse(str, out parsedValue))
            {
                return true;
            }
            return false;
        }



        private void btnCapNhatLoiNhuan_Click(object sender, EventArgs e)
        {
            if(isContainsCharacter(txtLoiNhuan.Text) == false)
            {
                Properties.Settings.Default.LoiNhuan = float.Parse(txtLoiNhuan.Text);
                Properties.Settings.Default.Save();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Lợi nhuận nhập vào không hợp lệ, xin vui lòng kiểm tra lại.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                txtLoiNhuan.Focus();
            }
        }


    }
}
