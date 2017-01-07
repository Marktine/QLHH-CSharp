using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HoaDonRepo : IHoaDonRepo
    {
        public List<DTO.HoaDon> getAll()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return db.HoaDons.ToList();
            }
        }

        public DTO.HoaDon Insert(DTO.HoaDon obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.HoaDons.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(DTO.HoaDon obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.HoaDons.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(DTO.HoaDon obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.HoaDons.Attach(obj);
                db.HoaDons.Remove(obj);
                db.SaveChanges();
            }
        }
    }
}
