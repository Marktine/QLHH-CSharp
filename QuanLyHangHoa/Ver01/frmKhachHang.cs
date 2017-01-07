using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Ver01
{
    public partial class frmKhachHang : MetroFramework.Forms.MetroForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void loadKHData()
        {
            khachHangBindingSource.DataSource = KhachHangBUS.getAll();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadKHData();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.SelectedIndex = 0;
            cmbCate.Items.Add("Mã Khách hàng");
            cmbCate.Items.Add("Tên khách hàng");
            cmbCate.SelectedIndex = -1;
        }

        private void mtThem_Click(object sender, EventArgs e)
        {
            if(txtMaKhachHang.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bạn không được để trống mã khách hàng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                txtMaKhachHang.Focus();
                return;
            } 
            if(txtTenKhachHang.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bạn không được để trống tên khách hàng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                txtTenKhachHang.Focus();
                return;
            }
            if(txtCMND.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "CMND Khách hàng không được để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                txtCMND.Focus();
                return;
            }
            if(txtDiaChi.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Địa chỉ khách hàng không được để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                txtDiaChi.Focus();
                return; 
            }
            if(txtSDT.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Số điện thoại khách hàng không được để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                txtSDT.Focus();
                return;
            }
            KhachHang kh = new KhachHang()
            {
                MaKH = txtMaKhachHang.Text,
                TenKH = txtTenKhachHang.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cmbGioiTinh.SelectedItem.ToString(),
                SDT = txtSDT.Text,
                Cmnd = txtCMND.Text,
               
            };
            try
            {
                KhachHangBUS.Insert(kh);
                MetroFramework.MetroMessageBox.Show(this, "Thêm vào thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                dgvKhachHang.Rows.Clear();
                loadKHData();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình thêm sản phẩm, Vui lòng xem lại thông tin sản phẩm cần thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void mtXoa_Click(object sender, EventArgs e)
        {
            if (khachHangBindingSource.Current == null)
            {
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc là muốn xóa khách hàng này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dgvKhachHang.SelectedRows)
                {
                    KhachHang h = khachHangBindingSource.Current as KhachHang;
                    h.TinhTrang = false;
                    dgvKhachHang.Rows.RemoveAt(item.Index);
                    KhachHangBUS.Update(h);
                }
            }
        }

        private void mtSua_Click(object sender, EventArgs e)
        {
            if(khachHangBindingSource.Current == null)
            {
                return; 
            }
            KhachHangBUS.Update(khachHangBindingSource.Current as KhachHang);
            khachHangBindingSource.Clear();
            loadKHData();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                loadKHData();
                return;
            }
            switch(cmbCate.SelectedIndex)
            {
                case 0:
                    try
                    {
                        khachHangBindingSource.Clear();
                        khachHangBindingSource.DataSource = KhachHangBUS.searchById(txtSearch.Text);
                        break;
                    }catch(Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Dữ liệu tìm kiếm không hợp lệ, vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        loadKHData();
                        break;
                    }
               case 1:
                    try
                    {
                        khachHangBindingSource.Clear();
                        khachHangBindingSource.DataSource = KhachHangBUS.searchByName(txtSearch.Text);
                        break;
                    }
                    catch(Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Có lỗi xảy ra trong quá trình tìm kiếm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        loadKHData();
                        break;
                    }
                default:
                     MetroFramework.MetroMessageBox.Show(this, "Hãy chọn một mục để tìm kiếm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                     break; 

            }


        }


        
    }
}
