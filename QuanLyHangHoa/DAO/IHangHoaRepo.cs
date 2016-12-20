using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public interface IHangHoaRepo 
    {
        List<HangHoa> GetAll();
        HangHoa GetById(string ID);
        List<HangHoa> GetByName(string TenHH); 
        HangHoa Insert(HangHoa obj);
        void Update(HangHoa obj);
        void Delete(HangHoa obj);
    }
}
