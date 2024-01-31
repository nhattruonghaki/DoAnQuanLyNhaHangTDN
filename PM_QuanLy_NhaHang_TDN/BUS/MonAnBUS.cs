using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class MonAnBUS
    {
        MonAnDAO maDAO = new MonAnDAO();
        public List<MonAnDTO> LayDSMonAn()
        {
            return maDAO.LayDSMonAn();
        }
        public List<MonAnDTO> LayDSLoaiMonAn()
        {
            return maDAO.LayDSLoaiMonAn();
        }
        public bool ThemMonAn(MonAnDTO themma)
        {
            return maDAO.ThemMonAn(themma);
        }
        public bool SuaMonAn(MonAnDTO suama)
        {
            return maDAO.SuaMonAn(suama);
        }
        public bool XoaMonAn(MonAnDTO xoama)
        {
            return maDAO.XoaMonAn(xoama);
        }

        public List<MonAnDTO> DSMonAn_MaMonAn(MonAn ma)
        {
            // xử lý dữ liệu
            return maDAO.DSMonAn_MaMonAn(ma);
        }

        public List<MonAnDTO> DSMonAn_TenMonAn(string tenma)
        {
            // xử lý dữ liệu
            return maDAO.DSMonAn_TenMonAn(tenma);
        }

    }
}
