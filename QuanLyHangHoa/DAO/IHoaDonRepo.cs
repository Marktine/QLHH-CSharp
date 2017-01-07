using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public interface IHoaDonRepo
    {
        List<HoaDon> getAll();
        HoaDon Insert(HoaDon obj);
        void Update(HoaDon obj);
        void Delete(HoaDon obj);
    }
}
