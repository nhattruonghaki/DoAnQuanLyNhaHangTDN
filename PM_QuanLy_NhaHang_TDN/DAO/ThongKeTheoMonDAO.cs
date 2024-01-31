using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using PM_QuanLy_NhaHang_TDN;

namespace DAO
{
    public class ThongKeTheoMonDAO
    {
        TDNEntities tDNEntities = new TDNEntities();

        public List<ThongKeTheoMonDTO> DSMonAn()
        {
            var lst = tDNEntities.MonAns.ToList();
            return lst.Where(a => a.TrangThai == true).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
            }).ToList();
        }
        // Tìm kiếm

        public List<ThongKeTheoMonDTO> DSMonAn_MaMonAn(MonAn ma)
        {
            return tDNEntities.MonAns.Where(v => v.TrangThai == true && v.MaMonAn == ma.MaMonAn).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_MaLoai(MonAn ma)
        {
            return tDNEntities.MonAns.Where(v => v.MaLoai == ma.MaLoai && v.TrangThai == true).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_TenMonAn(string ma)
        {
            return tDNEntities.MonAns.Where(v => v.TenMonAn.Contains(ma) && v.TrangThai == true).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_Thit()
        {
            return tDNEntities.MonAns.Where(v => v.MaLoai == Const.DSMonAn_Thit && v.TrangThai == true).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
                TenLoai = u.LoaiMonAn.TenLoai,
                HinhAnh = u.HinhAnh
            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_HaiSan()
        {
            return tDNEntities.MonAns.Where(v => v.MaLoai == Const.DSMonAn_HaiSan && v.TrangThai == true).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
                TenLoai = u.LoaiMonAn.TenLoai,
                HinhAnh = u.HinhAnh

            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DSMonAn_RauCu()
        {
            return tDNEntities.MonAns.Where(v => v.TrangThai == true && v.MaLoai == Const.DSMonAn_RauCu).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
                TenLoai = u.LoaiMonAn.TenLoai,
                HinhAnh = u.HinhAnh

            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DS_Nuoc()
        {
            return tDNEntities.MonAns.Where(v => v.TrangThai == true && v.MaLoai == Const.DSMonAn_Nuoc).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
                TenLoai = u.LoaiMonAn.TenLoai,
                HinhAnh = u.HinhAnh

            }).ToList();
        }

        public List<ThongKeTheoMonDTO> DSTheoLoai(int maloai)
        {
            return tDNEntities.MonAns.Where(v => v.MaLoai == maloai && v.TrangThai == true).Select(u => new ThongKeTheoMonDTO
            {
                MAMONAN = u.MaMonAn,
                MALOAI = u.MaLoai,
                TENMONAN = u.TenMonAn,
                SLTONKHO = u.SLTonKho.Value,
                DONGIA = u.DonGia.Value,
            }).ToList();
        }
    }
}
