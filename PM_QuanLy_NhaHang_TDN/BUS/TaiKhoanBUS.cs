using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAO;
using DTO;
using PM_QuanLy_NhaHang_TDN;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public List<TaiKhoanDTO> LayDSTaiKhoan()
        {
            return tkDAO.LayDSTaiKhoan();
        }

        public List<TaiKhoanDTO> LayDSLoaiTaiKhoan()
        {
            return tkDAO.LayDSLoaiTaiKhoan();
        }
        public bool ThemTK(TaiKhoanDTO newtk)
        {
            // kiểm tra khách hàng tồn tại ? theo SDT
            if (tkDAO.IsExisted(newtk)) return false;
            // thực hiện việc thêm khách hàng mới
            return tkDAO.ThemTK(newtk);
        }
        public bool SuaTK(TaiKhoanDTO edittk)
        {            
            return tkDAO.SuaTK(edittk);
        }

        public bool XoaTK(TaiKhoanDTO deltk)
        {
            //if (tkDAO.KTNV_MaNV(maNV) == false) return false;
            return tkDAO.XoaTK(deltk);
        }

        public List<TaiKhoanDTO> DSNhanVien_MaLoaiTK(TaiKhoanDTO nv)
        {
            // xử lý dữ liệu
            return tkDAO.DSNhanVien_MaLoaiTK(nv);
        }

        public List<TaiKhoanDTO> DSNhanVien_TenNV(string nv)
        {
            // xử lý dữ liệu
            return tkDAO.DSNhanVien_TenNV(nv);
        }

        public bool CheckUsername(string checkuser)
        {
            // Biểu thức chính quy để kiểm tra định dạng số điện thoại
            string user = Const.user;

            // Kiểm tra sự khớp của số user với biểu thức chính quy
            Match match = Regex.Match(checkuser, user);

            // Nếu khớp, số điện thoại hợp lệ
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<TaiKhoanDTO> LayNhanVienChuaCoTaiKhoan()
        {
            return tkDAO.LayNhanVienChuaCoTaiKhoan();
        }
        public bool CheckLoginPhanQuyen(string username, string pass)
        {
            return tkDAO.CheckLoginPhanQuyen(username, pass);
        }


        public bool UpdatePassword(string username, string Passold,string newPass)
        {
            return tkDAO.UpdatePassword(username, Passold, newPass);
        }

        public bool QuenPassword(string username, string newPass)
        {
            return tkDAO.QuenPassword(username, newPass);
        }
        public List<TaiKhoanDTO> LayTenNvTaiKhoan(string username)
        {
            return tkDAO.LayTenNvTaiKhoan(username);
        }
    }
}
