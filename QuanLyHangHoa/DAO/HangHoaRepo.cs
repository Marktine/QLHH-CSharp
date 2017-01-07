using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HangHoaRepo : IHangHoaRepo
    {

        public List<DTO.HangHoa> GetAll()
        {
           using (QLBHEntities db = new QLBHEntities())
           {
               return (from c in db.HangHoas
                       where c.TinhTrang == true
                       select c).ToList();
           }
        }

        public DTO.HangHoa Insert(DTO.HangHoa obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.HangHoas.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(DTO.HangHoa obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.HangHoas.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public HangHoa GetById(string Id)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return db.HangHoas.FirstOrDefault(i => i.MaHang == Id);
            }
        }

        public List<HangHoa> GetByName(string TenHH)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return (from c in db.HangHoas
                        where c.TenHang.Contains(TenHH)
                        select c).ToList();
            }
        }

        public void Delete(DTO.HangHoa obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.HangHoas.Attach(obj);
                db.HangHoas.Remove(obj);
                db.SaveChanges();
            }
        }
    }
}
