using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        TDNEntities tdnEnti = new TDNEntities();
        public List<TaiKhoanDTO> LayDSTaiKhoan()
        {
            return tdnEnti.TaiKhoans.Where(ds => ds.TrangThai.Value == true).Select(tk => new TaiKhoanDTO
            {
                MaLoaiTK = tk.MaLoaiTK,                           
                MaNV = tk.MaNV,
                TenNV = tk.NhanVien.TenNV,
                MaLoai = tk.MaLoai,
                TenLoai = tk.LoaiTK.TenLoaiTaiKhoan,
                Username = tk.Username,
                Pass = tk.Pass,
            }).ToList();
        }
        public List<TaiKhoanDTO> LayDSLoaiTaiKhoan()
        {
            return tdnEnti.LoaiTKs.Select(tk => new TaiKhoanDTO
            {
                MaLoaiTaiKhoan = tk.MaLoaiTaiKhoan,
                TenLoaiTaiKhoan = tk.TenLoaiTaiKhoan,
            }).ToList();
        }
        public List<TaiKhoanDTO> LayTenNvTaiKhoan(string username)
        {
            return tdnEnti.TaiKhoans.Where(ds => ds.TrangThai.Value == true && ds.Username == username).Select(tk => new TaiKhoanDTO
            {
                MaLoaiTK = tk.MaLoaiTK,
                MaNV = tk.MaNV,
                TenNV = tk.NhanVien.TenNV,
                MaLoai = tk.MaLoai,
                TenLoai = tk.LoaiTK.TenLoaiTaiKhoan,
                Username = tk.Username,
                Pass = tk.Pass,
            }).ToList();
        }
        public bool ThemTK(TaiKhoanDTO newtk)
        {
            try
            {
                TaiKhoan tkEF = new TaiKhoan()
                {
                    MaNV = newtk.MaNV,
                    Username = newtk.Username,
                    Pass = newtk.Pass,
                    MaLoai = newtk.MaLoai,
                    TrangThai = newtk.TrangThai
                };
                tdnEnti.TaiKhoans.Add(tkEF);
                tdnEnti.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                // ghi log e.Message;
                return false;
            }
        }

        public bool IsExisted(TaiKhoanDTO exis)
        {
            var tk = tdnEnti.TaiKhoans.SingleOrDefault(t => t.Username == exis.Username);
            return tk != null;
        }


        public bool SuaTK(TaiKhoanDTO edittk)
        {
            try
            {
                TaiKhoan tkEF = tdnEnti.TaiKhoans.Find(edittk.MaLoaiTK);
                bool ktUser = tdnEnti.TaiKhoans.Any(tk => tk.Username == edittk.Username && tk.MaLoaiTK != edittk.MaLoaiTK);
                tkEF.Username = edittk.Username;

                tkEF.MaLoai = edittk.MaLoai;

                tdnEnti.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool XoaTK(TaiKhoanDTO deltk)
        {
            try
            {
                TaiKhoan tkEF = tdnEnti.TaiKhoans.Find(deltk.MaLoaiTK);

                // xoá mất luôn để hiển thị lên lại trên cbb
                tdnEnti.TaiKhoans.Remove(tkEF);
                //tkEF.TrangThai = deltk.TrangThai = false;
                tdnEnti.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }




        public List<TaiKhoanDTO> LayNhanVienChuaCoTaiKhoan()
        {  
            var taiKhoans = from tk in tdnEnti.NhanViens
                            where !tdnEnti.TaiKhoans.Any(t => t.MaNV == tk.MaNV || tk.TrangThai == false)
                            select new TaiKhoanDTO
                            {
                                MaNV = tk.MaNV,
                                TenNV = tk.TenNV
                            };
            return taiKhoans.ToList();
        }

        public bool CheckLoginPhanQuyen(string username, string pass)
        {
            var taiKhoan = tdnEnti.TaiKhoans.FirstOrDefault(tk => tk.Username == username && tk.Pass == pass && tk.TrangThai == true);

            if (taiKhoan != null)
            {        
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public List<TaiKhoanDTO> DSNhanVien_MaLoaiTK(TaiKhoanDTO nhanvien)
        {
            return tdnEnti.TaiKhoans.Where(d => d.TrangThai == true && d.MaLoaiTK == nhanvien.MaLoaiTK).Select(nv => new TaiKhoanDTO
            {
                MaLoaiTK = nv.MaLoaiTK,
                TenNV = nv.NhanVien.TenNV,
                TenLoai = nv.LoaiTK.TenLoaiTaiKhoan,
                Username = nv.Username,
                Pass = nv.Pass,
            }).ToList();
        }

        public List<TaiKhoanDTO> DSNhanVien_TenNV(string tennv)
        {
            return tdnEnti.TaiKhoans.Where(d => d.TrangThai == true && d.NhanVien.TenNV.Contains(tennv)).Select(tk => new TaiKhoanDTO
            {
                MaLoaiTK = tk.MaLoaiTK,
                MaNV = tk.MaNV,
                TenNV = tk.NhanVien.TenNV,
                MaLoai = tk.MaLoai,
                TenLoai = tk.LoaiTK.TenLoaiTaiKhoan,
                Username = tk.Username,
                Pass = tk.Pass,
            }).ToList();
        }

        public bool QuenPassword(string email, string newPass)
        {
            //Kiểm tra thông tin đăng nhập trong cơ sở dữ liệu so sánh Email trong CSDL = Email nhập
            var user = tdnEnti.TaiKhoans.SingleOrDefault(u => u.NhanVien.Email == email);
            if (user != null)
            {
                user.Pass = newPass;
                tdnEnti.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePassword(string username, string Passold,string newPass)
        {
            //Kiểm tra thông tin đăng nhập trong cơ sở dữ liệu so sánh Username trong CSDL = username nhập và pass cũng vại
            var user = tdnEnti.TaiKhoans.SingleOrDefault(u => u.Username == username && u.Pass == Passold);
            if (user != null)
            {
                user.Pass = newPass;
                tdnEnti.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
 

    }
}
