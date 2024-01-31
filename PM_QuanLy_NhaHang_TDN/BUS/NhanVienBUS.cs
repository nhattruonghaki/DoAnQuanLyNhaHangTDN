using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Text.RegularExpressions;
using PM_QuanLy_NhaHang_TDN;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();
        public List<NhanVienDTO> LayDSNhanVien()
        {
            return nvDAO.LayDSNhanVien();
        }
        // phương thức thêm nhân viên mới
        public bool ThemNV(NhanVienDTO NhanVienNew)
        {
            if (nvDAO.IsExisted(NhanVienNew)) return false;
            return nvDAO.ThemNV(NhanVienNew);
        }
        // qua bên thêm nv gọi lại: check trước khi thêm
        public bool CheckEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string emailbatbuoc = Const.emailbatbuoc;

            // Kiểm tra sự khớp của email với biểu thức chính quy
            Match match = Regex.Match(email, emailbatbuoc);

            // Nếu khớp, email hợp lệ
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public bool CheckPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra định dạng số điện thoại
            string phoneN = Const.phoneN;

            // Kiểm tra sự khớp của số điện thoại với biểu thức chính quy
            Match match = Regex.Match(phoneNumber, phoneN);

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

        public bool SuaNhanVien(NhanVienDTO maNV)
        {
            //if (nvDAO.IsExisted(maNV)) return false;
            return nvDAO.SuaNhanVien(maNV);

        }
        public bool XoaNhanVien(NhanVienDTO maNV)
        {
            return nvDAO.XoaNhanVien(maNV);
        }

        public List<NhanVienDTO> DSNhanVien_MaNV(NhanVien nv)
        {
            return nvDAO.DSNhanVien_MaNV(nv);
        }

        public List<NhanVienDTO> DSNhanVien_TenNV(string nv)
        {
            return nvDAO.DSNhanVien_TenNV(nv);
        }

        public List<NhanVienDTO> DSNhanVien_Nam()
        {
            return nvDAO.DSNhanVien_Nam();
        }

        public List<NhanVienDTO> DSNhanVien_Nu()
        {
            return nvDAO.DSNhanVien_Nu();
        }

        // thêm nhân viên rồi đăng kí tài khoản
        public int LayMaNhanVienMoiNhat()
        {
            List<NhanVienDTO> listNV = nvDAO.LayDSNhanVien();
            int maxMaNV = Const.maxMaNV;
            foreach (NhanVienDTO nv in listNV)
            {
                if (nv.MaNV > maxMaNV)
                {
                    maxMaNV = nv.MaNV;
                }
            }
            return maxMaNV;
        }


    }
}
