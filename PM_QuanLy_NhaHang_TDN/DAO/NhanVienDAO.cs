using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using DTO;
using PM_QuanLy_NhaHang_TDN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DAO
{
    public class NhanVienDAO
    {
        TDNEntities tdnEnti = new TDNEntities();
        public List<NhanVienDTO> LayDSNhanVien()
        {
            return tdnEnti.NhanViens.Where(ds => ds.TrangThai == true).Select(nv => new NhanVienDTO
            {
                MaNV = nv.MaNV,
                TenNV = nv.TenNV,
                GioiTinh = nv.GioiTinh == null ? Const.NV_chuoirong_DAO : (nv.GioiTinh.Value ? Const.NhanVien_Nam : Const.NhanVien_Nu),
                Email = nv.Email,
                NgayVaoLam = nv.NgayVaoLam,
                SDT = nv.SDT,
                DiaChi = nv.DiaChi,
                ChucVu = nv.ChucVu,
                HinhAnh = nv.HinhAnh,
                
            }).ToList();
        }
        // phương thức thêm mới nhân viên
        public bool ThemNV(NhanVienDTO NhanVienNew)
        {
            try
            {
                // kiểm soát lỗi
                NhanVien nvEF = new NhanVien()
                {
                    MaNV = NhanVienNew.MaNV,
                    TenNV = NhanVienNew.TenNV,
                    GioiTinh = NhanVienNew.GioiTinh == Const.NhanVien_Nam ? true : false,
                    Email = NhanVienNew.Email,
                    NgayVaoLam = NhanVienNew.NgayVaoLam,
                    SDT = NhanVienNew.SDT,
                    DiaChi = NhanVienNew.DiaChi,
                    ChucVu = NhanVienNew.ChucVu,
                    HinhAnh = NhanVienNew.HinhAnh,
                    TrangThai = NhanVienNew.TrangThai == true,
                };
                tdnEnti.NhanViens.Add(nvEF);
                tdnEnti.SaveChanges();
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
           
        }
        // sự tồn tại của nhân viên theo SDT và Email
        public bool IsExisted(NhanVienDTO nvExisted)
        {
            try
            {
                var nvEF = tdnEnti.NhanViens.SingleOrDefault(nve => nve.SDT == nvExisted.SDT || nve.Email == nvExisted.Email);
                return nvEF != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Phương thức sửa thông tin nhân viên
        public bool SuaNhanVien(NhanVienDTO maNV)
        {
            try
            {
                NhanVien nvEF = tdnEnti.NhanViens.Find(maNV.MaNV);
                bool kt = tdnEnti.NhanViens.Any(nv => (nv.SDT == maNV.SDT || nv.Email == maNV.Email) && nv.MaNV != maNV.MaNV);
                
                nvEF.TenNV = maNV.TenNV;
                nvEF.GioiTinh = maNV.GioiTinh == Const.NhanVien_Nam ? true : false;
                nvEF.Email = maNV.Email;
                nvEF.NgayVaoLam = maNV.NgayVaoLam;
                nvEF.SDT = maNV.SDT;
                nvEF.DiaChi = maNV.DiaChi;
                nvEF.ChucVu = maNV.ChucVu;
                nvEF.HinhAnh = maNV.HinhAnh;
                tdnEnti.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        // Phương thức Xoá thông tin nhân viên theo mã
        public bool XoaNhanVien(NhanVienDTO maNV)
        {
            try
            {             
                // Tìm tài khoản của nhân viên cần xóa
                TaiKhoan tkEF = tdnEnti.TaiKhoans.FirstOrDefault(tk => tk.MaNV == maNV.MaNV);
                // Nếu tài khoản tồn tại, xoá tài khoản về false
                if (tkEF != null)
                {
                    tkEF.TrangThai = maNV.TrangThai;
                }
                NhanVien nvEF = tdnEnti.NhanViens.Find(maNV.MaNV);
                nvEF.TrangThai = maNV.TrangThai = false;
                tdnEnti.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<NhanVienDTO> DSNhanVien_MaNV(NhanVien nhanvien)
        {
            return tdnEnti.NhanViens.Where(d => d.TrangThai == true && d.MaNV == nhanvien.MaNV).Select(nv => new NhanVienDTO
            {
                MaNV = nv.MaNV,
                TenNV = nv.TenNV,
                GioiTinh = nv.GioiTinh == null ? Const.NV_chuoirong_DAO : (nv.GioiTinh.Value ? Const.NhanVien_Nam : Const.NhanVien_Nu),
                Email = nv.Email,
                NgayVaoLam = nv.NgayVaoLam,
                SDT = nv.SDT,
                DiaChi = nv.DiaChi,
                ChucVu = nv.ChucVu,
                HinhAnh = nv.HinhAnh,
            }).ToList();
        }

        public List<NhanVienDTO> DSNhanVien_TenNV(string tennv)
        {
            return tdnEnti.NhanViens.Where(d => d.TrangThai == true && d.TenNV.Contains(tennv)).Select(nv => new NhanVienDTO
            {
                MaNV = nv.MaNV,
                TenNV = nv.TenNV,
                GioiTinh = nv.GioiTinh == null ? Const.NV_chuoirong_DAO : (nv.GioiTinh.Value ? Const.NhanVien_Nam : Const.NhanVien_Nu),
                Email = nv.Email,
                NgayVaoLam = nv.NgayVaoLam,
                SDT = nv.SDT,
                DiaChi = nv.DiaChi,
                ChucVu = nv.ChucVu,
                HinhAnh = nv.HinhAnh,
            }).ToList();
        }

        public List<NhanVienDTO> DSNhanVien_Nam()
        {
            return tdnEnti.NhanViens.Where(d => d.TrangThai == true && d.GioiTinh == true).Select(nv => new NhanVienDTO
            {
                MaNV = nv.MaNV,
                TenNV = nv.TenNV,
                GioiTinh = nv.GioiTinh == null ? Const.NV_chuoirong_DAO : (nv.GioiTinh.Value ? Const.NhanVien_Nam : Const.NhanVien_Nu),
                Email = nv.Email,
                NgayVaoLam = nv.NgayVaoLam,
                SDT = nv.SDT,
                DiaChi = nv.DiaChi,
                ChucVu = nv.ChucVu,
                HinhAnh = nv.HinhAnh,
            }).ToList();
        }

        public List<NhanVienDTO> DSNhanVien_Nu()
        {
            return tdnEnti.NhanViens.Where(d => d.TrangThai == true && d.GioiTinh == false).Select(nv => new NhanVienDTO
            {
                MaNV = nv.MaNV,
                TenNV = nv.TenNV,
                GioiTinh = nv.GioiTinh == null ? Const.NV_chuoirong_DAO : (nv.GioiTinh.Value ? Const.NhanVien_Nam : Const.NhanVien_Nu),
                Email = nv.Email,
                NgayVaoLam = nv.NgayVaoLam,
                SDT = nv.SDT,
                DiaChi = nv.DiaChi,
                ChucVu = nv.ChucVu,
                HinhAnh = nv.HinhAnh,
            }).ToList();
        }

   


    }
}
