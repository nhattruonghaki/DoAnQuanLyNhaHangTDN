using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class MonAnDAO
    {
        TDNEntities tdnEnti = new TDNEntities();
        public List<MonAnDTO> LayDSMonAn()
        {
            return tdnEnti.MonAns.Where(lay => lay.TrangThai == true).Select(ds => new MonAnDTO
            {
                MaMonAn = ds.MaMonAn,
                MaLoai = ds.MaLoai,
                TenLoai = ds.LoaiMonAn.TenLoai,
                TenMonAn = ds.TenMonAn,
                SLTonKho = ds.SLTonKho.Value,
                DonGia = ds.DonGia.Value,
                HinhAnh = ds.HinhAnh
            }).ToList();
        }
        public List<MonAnDTO> LayDSLoaiMonAn()
        {
            return tdnEnti.LoaiMonAns.Select(loai => new MonAnDTO
            {
                MaLoai = loai.MaLoai,
                TenLoai = loai.TenLoai
            }).ToList();
        }
        public bool ThemMonAn(MonAnDTO themma)
        {
            try
            {
                // kiểm soát lỗi
                MonAn ma = new MonAn()
                {
                    MaLoai = themma.MaLoai,
                    TenMonAn = themma.TenMonAn,
                    SLTonKho = themma.SLTonKho,
                    DonGia = themma.DonGia,
                    HinhAnh = themma.HinhAnh,
                    TrangThai = themma.TrangThai == true
                };
                tdnEnti.MonAns.Add(ma);
                tdnEnti.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaMonAn(MonAnDTO suama)
        {
            try
            {
                MonAn ma = tdnEnti.MonAns.Find(suama.MaMonAn);
                ma.TenMonAn = suama.TenMonAn;
                ma.MaLoai = suama.MaLoai;
                ma.SLTonKho = suama.SLTonKho;
                ma.DonGia = suama.DonGia;
                ma.HinhAnh = suama.HinhAnh;
                tdnEnti.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaMonAn(MonAnDTO xoama)
        {
            try
            {
                MonAn ma = tdnEnti.MonAns.Find(xoama.MaMonAn);
                ma.TrangThai = xoama.TrangThai = false;
                tdnEnti.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<MonAnDTO> DSMonAn_MaMonAn(MonAn MonAn)
        {
            return tdnEnti.MonAns.Where(d => d.TrangThai == true && d.MaMonAn == MonAn.MaMonAn).Select(ma => new MonAnDTO
            {
                MaMonAn = ma.MaMonAn,
                MaLoai = ma.MaLoai,
                TenLoai = ma.LoaiMonAn.TenLoai,
                TenMonAn = ma.TenMonAn,
                SLTonKho = ma.SLTonKho.Value,
                DonGia = ma.DonGia.Value,
                HinhAnh = ma.HinhAnh
            }).ToList();
        }

        public List<MonAnDTO> DSMonAn_TenMonAn(string tenma)
        {
            return tdnEnti.MonAns.Where(d => d.TrangThai == true && d.TenMonAn.Contains(tenma)).Select(ma => new MonAnDTO
            {
                MaMonAn = ma.MaMonAn,
                MaLoai = ma.MaLoai,
                TenLoai = ma.LoaiMonAn.TenLoai,
                TenMonAn = ma.TenMonAn,
                SLTonKho = ma.SLTonKho.Value,
                DonGia = ma.DonGia.Value,
                HinhAnh = ma.HinhAnh
            }).ToList();
        }
    }
}
