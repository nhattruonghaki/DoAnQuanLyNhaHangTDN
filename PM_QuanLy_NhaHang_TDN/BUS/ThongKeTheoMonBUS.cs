using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThongKeTheoMonBUS
    {
        ThongKeTheoMonDAO _ThongKeTheoMonDAO = new ThongKeTheoMonDAO();

        public List<ThongKeTheoMonDTO> DSMonAn()
        {
            return _ThongKeTheoMonDAO.DSMonAn();
        }

        public List<ThongKeTheoMonDTO> DSTheoLoai(int maloai)
        {
            return _ThongKeTheoMonDAO.DSTheoLoai(maloai);
        }
        // Tìm kiếm

        public List<ThongKeTheoMonDTO> DSMonAn_MaMonAn(MonAn ma)
        {
            return _ThongKeTheoMonDAO.DSMonAn_MaMonAn(ma);
        }

        public List<ThongKeTheoMonDTO> DSMonAn_MaLoai(MonAn ma)
        {
            return _ThongKeTheoMonDAO.DSMonAn_MaLoai(ma);
        }

        public List<ThongKeTheoMonDTO> DSMonAn_TenMonAn(string ma)
        {
            return _ThongKeTheoMonDAO.DSMonAn_TenMonAn(ma);
        }

        public List<ThongKeTheoMonDTO> DSMonAn_Thit()
        {
            return _ThongKeTheoMonDAO.DSMonAn_Thit();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_HaiSan()
        {
            return _ThongKeTheoMonDAO.DSMonAn_HaiSan();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_RauCu()
        {
            return _ThongKeTheoMonDAO.DSMonAn_RauCu();
        }
        public List<ThongKeTheoMonDTO> DS_Nuoc()
        {
            return _ThongKeTheoMonDAO.DS_Nuoc();
        }
    }
}
