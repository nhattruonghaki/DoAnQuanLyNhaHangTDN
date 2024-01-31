using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThongKeHoaDonBUS
    {
        ThongKeHoaDonDAO _ThongKeHoaDonDAO = new ThongKeHoaDonDAO();

        public List<ThongKeHoaDonDTO> DSHoaDon()
        {
            return _ThongKeHoaDonDAO.DSHoaDon();
        }
        // Tìm kiếm

        public List<ThongKeHoaDonDTO> DSHoaDon_MaHD(HoaDon hd)
        {
            return _ThongKeHoaDonDAO.DSHoaDon_MaHD(hd);
        }

        public List<ThongKeHoaDonDTO> DSHoaDon_TenNV(string hd)
        {
            return _ThongKeHoaDonDAO.DSHoaDon_TenNV(hd);
        }

        public List<ThongKeHoaDonDTO> TimKiemTheoNgay(DateTime ngayDau, DateTime ngayCuoi)
        {
            return _ThongKeHoaDonDAO.TimKiemTheoNgay(ngayDau, ngayCuoi);
        }
    }
}
