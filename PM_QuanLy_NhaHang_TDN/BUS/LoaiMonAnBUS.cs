using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiMonAnBUS
    {
        LoaiMonAnDAO _LoaiMonAnDAO = new LoaiMonAnDAO();

        public List<LoaiMonAnDTO> DSLoaiMonAn()
        {
            return _LoaiMonAnDAO.DSLoaiMonAn();
        }
        public List<LoaiMonAnDTO> DSLoaiMonAn(int maloai)
        {
            return _LoaiMonAnDAO.DSLoaiMonAn(maloai);
        }
    }
}
