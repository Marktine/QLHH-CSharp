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
    
    public partial class HoaDon
    {
        public HoaDon()
        {
            this.CTHDs = new HashSet<CTHD>();
        }
    
        public string MaHD { get; set; }
        public string MaKhachHang { get; set; }
        public Nullable<double> TongTien { get; set; }
        public string NhanVienLap { get; set; }
        public string NgayLap { get; set; }
    
        public virtual ICollection<CTHD> CTHDs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}