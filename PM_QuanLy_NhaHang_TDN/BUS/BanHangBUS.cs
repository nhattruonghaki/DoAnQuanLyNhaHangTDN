using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    
    public class BanHangBUS
    {
        BanHangDAO bhDAO = new BanHangDAO();
        public List<BanHangDTO> LayDSXuatHD(int mahd)
        {
            return bhDAO.LayDSXuatHD(mahd);
        }


        public List<BanHangDTO> ChiTietBanHang(int mahd)
        {
            return bhDAO.ChiTietBanHang(mahd);
        }

        public bool ThemDSBanHang(BanHangDTO ds)
        {
            return bhDAO.ThemDSBanHang(ds);
        }
        public bool TruSoLuongMon(int maMonAn, int soLuong)
        {
            return bhDAO.TruSoLuongMon(maMonAn,soLuong);
        }
        public bool ThemBanTrong(int maban)
        {
            return bhDAO.ThemBanTrong(maban);
        }
        public bool ThemHD(BanHangDTO ds)
        {
            if (bhDAO.kt_tontai_BanAn(ds)) return false;
            return bhDAO.ThemHD(ds);
        }
        public List<BanHangDTO> DS_HoaDon()
        {
            return bhDAO.DS_HoaDon();
        }

        public bool AnCTHD_HD(BanHangDTO bh)
        {
            return bhDAO.AnCTHD_HD(bh);
        }
        public bool SuaDSBanHang(BanHangDTO suaBanHang, int mamonan)
        {
            return bhDAO.SuaDSBanHang(suaBanHang,mamonan);
        }
        public bool XoaDSBanHang(BanHangDTO xoads, int mamonan, int soluong)
        {
            return bhDAO.XoaDSBanHang(xoads,mamonan,soluong);
        }

        public List<BanHangDTO> DS_BanTrong()
        {
            return bhDAO.DS_BanTrong();
        }
    }
}
