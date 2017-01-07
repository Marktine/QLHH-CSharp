using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public interface IKhachHangRepo
    {
        List<KhachHang> getAll();
        KhachHang Insert(KhachHang obj);
        void Update(KhachHang obj);
        void Delete(KhachHang obj);
        KhachHang getById(string Id);
        List<KhachHang> getByName(string Name);
    }
}
