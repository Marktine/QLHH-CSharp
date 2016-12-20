using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public interface INhanVienRepo
    {
        List<NhanVien> GetAll();
        NhanVien Insert(NhanVien obj);
        void Update(NhanVien obj);
        void Delete(NhanVien obj);
        int GetSLNV();
    }
}
