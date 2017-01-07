using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public static class HoaDonBUS
    {
        static IHoaDonRepo repo;
        static HoaDonBUS()
        {
            repo = new HoaDonRepo();
        }

        public static List<HoaDon> getAll()
        {
            return repo.getAll();
        }

        public static HoaDon insert(HoaDon obj)
        {
            return repo.Insert(obj);
        }

        public static void Update(HoaDon obj)
        {
            repo.Update(obj);
        }

        public static void Delete(HoaDon obj)
        {
            repo.Delete(obj);
        }
    }
}
