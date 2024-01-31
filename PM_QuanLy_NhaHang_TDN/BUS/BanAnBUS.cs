using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BanAnBUS
    {
        BanAnDAO _BanAnDAO = new BanAnDAO();

        public List<BanAnDTO> LayDSBanAn()
        {
            return _BanAnDAO.LayDSBanAn();
        }
        // Thêm

        public bool ThemBA(BanAnDTO newBA)
        {
            return _BanAnDAO.ThemBA(newBA);
        }
        // Xóa
        public bool XoaBA(BanAnDTO newBA)
        {
            return _BanAnDAO.XoaBA(newBA);
        }
        // Sửa
        public bool SuaBA(BanAnDTO newBA)
        {
            return _BanAnDAO.SuaBA(newBA);
        }
        // Tìm kiếm

        public List<BanAnDTO> DSBanAn_MB(BanAn ba)
        {
            return _BanAnDAO.DSBanAn_MB(ba);
        }

        public List<BanAnDTO> DSBanAn_TB(string tenban)
        {
            return _BanAnDAO.DSBanAn_TB(tenban);
        }

        public List<BanAnDTO> DS_BanRanh()
        {
            return _BanAnDAO.DS_BanRanh();
        }

        public List<BanAnDTO> DS_BanBan()
        {
            return _BanAnDAO.DS_BanBan();
        }
    }
}
