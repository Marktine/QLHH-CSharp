using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public static class HangHoaBUS
    {
        static IHangHoaRepo repo;
        static HangHoaBUS()
        {
            repo = new HangHoaRepo();
        }

        public static List<HangHoa> GetAll()
        {
            return repo.GetAll();
        }
        public static HangHoa Insert(HangHoa obj)
        {
            return repo.Insert(obj);
        }

        public static void Update(HangHoa obj)
        {
            repo.Update(obj);
        }

        public static HangHoa GetById(string Id)
        {
            return repo.GetById(Id);
        }

        public static List<HangHoa> GetByName(string TenHH)
        {
            return repo.GetByName(TenHH);
        }

        public static void Delete(HangHoa obj)
        {
            repo.Delete(obj);
        }

    }
}
