using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public static class NhanVienBUS
    {
        static INhanVienRepo repo;
        static NhanVienBUS()
        {
            repo = new NhanVienRepo();
        }

        public static int GetSLVN()
        {
            return repo.GetSLNV();
        }

        public static List<NhanVien> GetAll()
        {
            return repo.GetAll();
        }

        public static NhanVien Insert(NhanVien obj)
        {
            return repo.Insert(obj);
        }
        public static void Update(NhanVien obj)
        {
            repo.Update(obj);
        }

        public static void Delete(NhanVien obj)
        {
            repo.Delete(obj);
        }

    }
}
