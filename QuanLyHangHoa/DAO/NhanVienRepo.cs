using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienRepo : INhanVienRepo
    {

        public int GetSLNV()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return db.NhanViens.Count();
            }
        }

        public List<DTO.NhanVien> GetAll()
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                return db.NhanViens.ToList();
            }
        }

        public DTO.NhanVien Insert(DTO.NhanVien obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.NhanViens.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(DTO.NhanVien obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.NhanViens.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(DTO.NhanVien obj)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.NhanViens.Attach(obj);
                db.NhanViens.Remove(obj);
                db.SaveChanges();
            }
        }
    }
}
