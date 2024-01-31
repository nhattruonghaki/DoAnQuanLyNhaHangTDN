using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using PM_QuanLy_NhaHang_TDN;

namespace DAO
{
    public class BanAnDAO
    {
        TDNEntities _qLNHEntities = new TDNEntities();

        public List<BanAnDTO> LayDSBanAn()
        {
            var lst = _qLNHEntities.BanAns.ToList();

            return lst.Where(v => v.Xoa == false).Select(u => new BanAnDTO
            {
                MABAN = u.MaBan,
                TENBAN = u.TenBan,
                TRANGTHAI = u.TrangThai == null ? Const.chuoi_rong : (u.TrangThai.Value ? Const.BanCu : Const.BanMoi),

            }).ToList();
        }
        // Thêm

        public bool ThemBA(BanAnDTO newBA)
        {
            try
            {
                BanAn baEF = new BanAn()
                {
                    MaBan = newBA.MABAN,
                    TenBan = newBA.TENBAN,
                    TrangThai = newBA.TRANGTHAI == Const.BanCu ? true : false,
                    BanTrong = newBA.BANTRONG,
                    Xoa = newBA.XOA
                };

                _qLNHEntities.BanAns.Add(baEF);
                _qLNHEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Xóa
        public bool XoaBA(BanAnDTO newBA)
        {
            try
            {
                BanAn baEF = new BanAn()
                {
                    MaBan = newBA.MABAN,
                    TenBan = newBA.TENBAN,
                    TrangThai = newBA.TRANGTHAI == Const.BanCu ? true : false,
                    Xoa = newBA.XOA
                };

                BanAn _banAn = _qLNHEntities.BanAns.SingleOrDefault(u => u.MaBan == newBA.MABAN);
                if (_banAn == null)
                    return false;
                _banAn.Xoa = true;
                _banAn.TrangThai = true;
                _banAn.BanTrong = true;

                _qLNHEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa
        public bool SuaBA(BanAnDTO newBA)
        {
            try
            {
                BanAn baEF = new BanAn()
                {
                    MaBan = newBA.MABAN,
                    TenBan = newBA.TENBAN,
                    TrangThai = newBA.TRANGTHAI == Const.BanCu ? true : false,
                    BanTrong = newBA.BANTRONG,
                    Xoa = newBA.XOA
                };

                BanAn _banAn = _qLNHEntities.BanAns.SingleOrDefault(u => u.MaBan == newBA.MABAN);
                if (_banAn == null)
                    return false;
                _banAn.MaBan = newBA.MABAN;
                _banAn.TenBan = newBA.TENBAN;
                _banAn.TrangThai = newBA.TRANGTHAI == Const.BanCu ? true : false;
                _banAn.BanTrong = newBA.BANTRONG ? true : false;

                _qLNHEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Tìm kiếm

        public List<BanAnDTO> DSBanAn_MB(BanAn ba)
        {
            return _qLNHEntities.BanAns.Where(u => u.MaBan == ba.MaBan).Select(v => new BanAnDTO
            {
                MABAN = v.MaBan,
                TENBAN = v.TenBan,
                TRANGTHAI = v.TrangThai == null ? Const.chuoi_rong : (v.TrangThai.Value ? Const.BanCu : Const.BanMoi),
            }).ToList();
        }

        public List<BanAnDTO> DSBanAn_TB(string tenban)
        {
            return _qLNHEntities.BanAns.Where(u => u.TenBan.Contains(tenban)).Select(v => new BanAnDTO
            {
                MABAN = v.MaBan,
                TENBAN = v.TenBan,
                TRANGTHAI = v.TrangThai == null ? Const.chuoi_rong : (v.TrangThai.Value ? Const.BanCu : Const.BanMoi),
            }).ToList();
        }

        public List<BanAnDTO> DS_BanRanh()
        {
            return _qLNHEntities.BanAns.Where(u => u.TrangThai == false && u.Xoa == false).Select(v => new BanAnDTO
            {
                MABAN = v.MaBan,
                TENBAN = v.TenBan,
                TRANGTHAI = v.TrangThai == null ? Const.chuoi_rong : (v.TrangThai.Value ? Const.BanCu : Const.BanMoi),
            }).ToList();
        }

        public List<BanAnDTO> DS_BanBan()
        {
            return _qLNHEntities.BanAns.Where(u => u.TrangThai == true && u.Xoa == false).Select(v => new BanAnDTO
            {
                MABAN = v.MaBan,
                TENBAN = v.TenBan,
                TRANGTHAI = v.TrangThai == null ? Const.chuoi_rong : (v.TrangThai.Value ? Const.BanCu : Const.BanMoi),
            }).ToList();
        }
    }
}
