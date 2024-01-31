using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class ThongKeDoanhThuDAO
    {
        TDNEntities _TDNEntities = new TDNEntities();

        // Chi tiết hóa đơn
        public List<ThongKeDoanhThuDTO> DSChiTietHD(int mahd)
        {
            var lst = _TDNEntities.CTHDs.ToList();

            return lst.Where(ct => ct.MaHD == mahd && ct.TrangThai == false && ct.Xoa == true).Select(u => new ThongKeDoanhThuDTO
            {
                MAHD = u.MaHD,
                MAMONAN = u.MonAn.TenMonAn.ToString(),
                NGAYLAPHD = u.HoaDon.NgayLapHD,
                SOLUONG = u.SoLuong.Value,
                CHIETKHAU = Convert.ToInt32(u.ChietKhau),
                DONGIA = u.MonAn.DonGia.Value,
                TONGTIEN = u.TongTien.Value,
            }).ToList();
        }
        public List<ThongKeDoanhThuDTO> TimKiemTheoNgay(DateTime ngayDau, DateTime ngayCuoi)
        {
            return _TDNEntities.CTHDs.Where(v => v.HoaDon.NgayLapHD >= ngayDau && v.HoaDon.NgayLapHD <= ngayCuoi && v.TrangThai == false && v.Xoa == true).Select(u => new ThongKeDoanhThuDTO
            {
                MAHD = u.MaHD,
                MAMONAN = u.MonAn.TenMonAn,
                SOLUONG = u.SoLuong.Value,
                TONGTIEN = u.TongTien.Value,
                CHIETKHAU = u.ChietKhau.Value,
                NGAYLAPHD = u.HoaDon.NgayLapHD
            }).ToList();
        }
            public List<ThongKeDoanhThuDTO> DSTongTien()
        {
            var lst = _TDNEntities.CTHDs.ToList();

            return lst.Where(ct => ct.TrangThai == false && ct.Xoa == true).Select(t => new ThongKeDoanhThuDTO
            {
                TONGTIEN = t.TongTien.Value,
                NAM = t.HoaDon.NgayLapHD.Year,
                MAHD = t.MaHD,
                MAMONAN = t.MonAn.TenMonAn,
                SOLUONG = t.SoLuong.Value,
                CHIETKHAU = t.ChietKhau.Value,
                NGAYLAPHD = t.HoaDon.NgayLapHD
            }).ToList();
        }

        public List<ThongKeDoanhThuDTO> LayNam()
        {
            var lst = _TDNEntities.CTHDs.ToList();
            return lst.Where(ct => ct.TrangThai == false && ct.Xoa == true).GroupBy(v => v.HoaDon.NgayLapHD.Year).Select(u => new ThongKeDoanhThuDTO
            {
                NAM = u.Key,
            }).ToList();
        }
    }

}
