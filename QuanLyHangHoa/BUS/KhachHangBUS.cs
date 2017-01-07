using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
    public static class KhachHangBUS
    {
        static IKhachHangRepo repo;
        static KhachHangBUS()
        {
            repo = new KhachHangRepo();
        }

        public static List<KhachHang> getAll()
        {
            return repo.getAll();
        }

        public static KhachHang Insert(KhachHang obj)
        {
            return repo.Insert(obj);
        }

        public static void Update(KhachHang obj)
        {
            repo.Update(obj);
        }

        public static void Delete (KhachHang obj)
        {
            repo.Delete(obj);
        }
        public static KhachHang searchById(string Id)
        {
            return repo.getById(Id);
        }

        public static List<KhachHang> searchByName(string Name)
        {
            return repo.getByName(Name);
        }

    }
}
