//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangHoa
    {
        public HangHoa()
        {
            this.CTHDs = new HashSet<CTHD>();
        }
    
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string LoaiHH { get; set; }
        public string TenNSX { get; set; }
        public Nullable<double> GiaNhap { get; set; }
        public Nullable<double> LoiNhuan { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> SoLuongMin { get; set; }
        public string NgNhapHang { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
    
        public virtual ICollection<CTHD> CTHDs { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
