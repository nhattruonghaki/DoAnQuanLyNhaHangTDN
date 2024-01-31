using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ThongKeHoaDonDAO
    {
        TDNEntities tDNEntities = new TDNEntities();
        public List<ThongKeHoaDonDTO> DSHoaDon()
        {
            var lst = tDNEntities.HoaDons.ToList();
            return lst.Where(v => v.ThanhToan == false).Select(u => new ThongKeHoaDonDTO
            {
                MAHD = u.MaHD,
                MABAN = u.MaBan,
                NGAYLAPHD = u.NgayLapHD,
                TENNV = u.NhanVien.TenNV,
                MANV = u.MaNV,
                TIENTHUA = Convert.ToInt32(u.TienThua),
            }).ToList();
        }
        // Tìm kiếm

        public List<ThongKeHoaDonDTO> DSHoaDon_MaHD(HoaDon hd)
        {
            return tDNEntities.HoaDons.Where(v => v.MaHD == hd.MaHD && v.ThanhToan == false).Select(u => new ThongKeHoaDonDTO
            {
                MAHD = u.MaHD,
                MABAN = u.MaBan,
                NGAYLAPHD = u.NgayLapHD,
                TENNV = u.NhanVien.TenNV,
                MANV = u.MaNV,
                TIENTHUA = u.TienThua.Value,
            }).ToList();
        }

        public List<ThongKeHoaDonDTO> DSHoaDon_TenNV(string hd)
        {
            return tDNEntities.HoaDons.Where(v => v.NhanVien.TenNV.Contains(hd) && v.ThanhToan == false).Select(u => new ThongKeHoaDonDTO
            {
                MAHD = u.MaHD,
                MABAN = u.MaBan,
                NGAYLAPHD = u.NgayLapHD,
                TENNV = u.NhanVien.TenNV,
                MANV = u.MaNV,
                TIENTHUA = u.TienThua.Value,
            }).ToList();
        }

        public List<ThongKeHoaDonDTO> TimKiemTheoNgay(DateTime ngayDau, DateTime ngayCuoi)
        {
            return tDNEntities.HoaDons.Where(v => v.NgayLapHD >= ngayDau && v.NgayLapHD <= ngayCuoi && v.ThanhToan == false).Select(u => new ThongKeHoaDonDTO
            {
                MAHD = u.MaHD,
                MABAN = u.MaBan,
                NGAYLAPHD = u.NgayLapHD,
                TENNV = u.NhanVien.TenNV,
                MANV = u.MaNV,
                TIENTHUA= u.TienThua.Value,
            }).ToList();
        }
    }
}
