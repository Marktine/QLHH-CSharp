using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhachHangRepo : IKhachHangRepo
    {
        public List<DTO.KhachHang> getAll()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return db.KhachHangs.ToList();
            }
        }

        public DTO.KhachHang Insert(DTO.KhachHang obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.KhachHangs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(DTO.KhachHang obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.KhachHangs.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(DTO.KhachHang obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.KhachHangs.Attach(obj);
                db.KhachHangs.Remove(obj);
                db.SaveChanges();
            }
        }

        public KhachHang getById(string Id)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return db.KhachHangs.FirstOrDefault(i => i.MaKH == Id);
            }
        }

        public List<KhachHang> getByName(string Name)
        {
            using(QLBHEntities db = new QLBHEntities())
            {
                return (from c in db.KhachHangs
                        where c.TenKH.Contains(Name)
                        select c).ToList();
                        
            }
        }

    }
}
