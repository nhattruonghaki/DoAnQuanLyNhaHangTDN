using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using PM_QuanLy_NhaHang_TDN;

namespace DAO
{
    public class BanHangDAO
    {
        TDNEntities tdnEnti = new TDNEntities();
        public List<BanHangDTO> ChiTietBanHang(int mahd)
        {
            var lst = tdnEnti.CTHDs.ToList();
            return lst.Where(v => v.MaHD == mahd && v.TrangThai == true).Select(ds => new BanHangDTO
            {
                MaHD = ds.MaHD,
                MaMonAn = ds.MaMonAn,
                TenMonAn = ds.MonAn.TenMonAn,
                SoLuong = ds.SoLuong.Value,
                DonGia = ds.MonAn.DonGia.Value,
                TongTien = ds.TongTien.Value,
                ChietKhau = ds.ChietKhau.Value,
                MaLoai = ds.MonAn.MaLoai,
                TenLoai = ds.MonAn.LoaiMonAn.TenLoai,
                TrangThai = ds.TrangThai.Value,
            }).ToList();
        }

        public List<BanHangDTO> LayDSXuatHD(int mahd)
        {
            var lst = tdnEnti.CTHDs.ToList();
            return lst.Where(v => v.MaHD == mahd && v.Xoa == true).Select(ds => new BanHangDTO
            {
                MaHD = ds.MaHD,
                MaMonAn = ds.MaMonAn,
                TenMonAn = ds.MonAn.TenMonAn,
                SoLuong = ds.SoLuong.Value,
                DonGia = ds.MonAn.DonGia.Value,
                TongTien = ds.TongTien.Value,
                ChietKhau = ds.ChietKhau.Value,
                MaLoai = ds.MonAn.MaLoai,
                TenLoai = ds.MonAn.LoaiMonAn.TenLoai,
                TrangThai = ds.TrangThai.Value,
            }).ToList();
        }
        public bool ThemDSBanHang(BanHangDTO ds)
        {
            var mamonanEF = tdnEnti.CTHDs.SingleOrDefault(u => u.MaMonAn == ds.MaMonAn && u.Xoa == false && u.TrangThai == false && u.MaHD == ds.MaHD);
            int donGia = tdnEnti.MonAns.SingleOrDefault(ma => ma.MaMonAn == ds.MaMonAn).DonGia.Value;
            int tongTien = ds.SoLuong * donGia * (100 - ds.ChietKhau) / 100;
            if (mamonanEF == null)
            {
                var monanEF = tdnEnti.CTHDs.SingleOrDefault(u => u.MaMonAn == ds.MaMonAn && u.MaHD == ds.MaHD);
                if (monanEF == null)
                {
                    
                    CTHD dsbh = new CTHD
                    {
                        MaHD = ds.MaHD,
                        MaMonAn = ds.MaMonAn,
                        SoLuong = ds.SoLuong,
                        TongTien = ds.TongTien = tongTien,
                        ChietKhau = ds.ChietKhau,
                        TrangThai = ds.TrangThai,
                        Xoa = ds.XoaCTHD
                    };

                    tdnEnti.CTHDs.Add(dsbh);
                }
                else
                {
                    monanEF.SoLuong += ds.SoLuong;
                    monanEF.ChietKhau = ds.ChietKhau;
                    monanEF.TongTien = monanEF.SoLuong * monanEF.MonAn.DonGia * (100 - monanEF.ChietKhau) / 100;
                }
            }
            else
            {
                mamonanEF.SoLuong = ds.SoLuong;
                mamonanEF.Xoa = true; mamonanEF.TrangThai = true;
            }

                tdnEnti.SaveChanges();
                return true;
           
           
        }

        public bool TruSoLuongMon(int maMonAn, int soLuong)
        {
            try
            {
                var monAn = tdnEnti.MonAns.Single(ma => ma.MaMonAn == maMonAn);
                
                if (monAn.SLTonKho < soLuong)
                {
                    return false;
                }
              
                    monAn.SLTonKho -= soLuong;
                tdnEnti.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ThemBanTrong(int maban)
        {
            try
            {
                var bantrong = tdnEnti.BanAns.Single(ma => ma.MaBan == maban);
                bantrong.BanTrong = true; 
                tdnEnti.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ThemHD(BanHangDTO ds)
        {
            try
            {
                HoaDon dsbh = new HoaDon
                {
                    MaHD = ds.MaHD,
                    MaBan = ds.MaBan,
                    MaNV = ds.MaNV,
                    NgayLapHD = ds.NgayLapHD,
                    ThanhToan = ds.ThanhToan == Const.BH_ChuaThanhToan ? true : false,
                    
                };
                tdnEnti.HoaDons.Add(dsbh);
                tdnEnti.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool kt_tontai_BanAn(BanHangDTO maban)
        {          
            var mabanEF = tdnEnti.HoaDons.FirstOrDefault(u => u.MaBan == maban.MaBan && u.ThanhToan == true);
            return mabanEF != null;
        }

        public bool SuaDSBanHang(BanHangDTO suaBanHang, int mamonan)
        {
            int donGia = tdnEnti.MonAns.Single(ma => ma.MaMonAn == suaBanHang.MaMonAn).DonGia.Value;
            int tongTien = suaBanHang.SoLuong * donGia * (100 - suaBanHang.ChietKhau) / 100;

            var monAn = tdnEnti.MonAns.Single(ma => ma.MaMonAn == mamonan);

            try
            {
                CTHD dsbh = new CTHD
                {
                    MaMonAn = suaBanHang.MaMonAn,
                    SoLuong = suaBanHang.SoLuong,
                    TongTien = suaBanHang.TongTien = tongTien,
                    ChietKhau = suaBanHang.ChietKhau,
                };
                CTHD _cthd = tdnEnti.CTHDs.SingleOrDefault(u => u.MaHD == suaBanHang.MaHD && u.MaMonAn == suaBanHang.MaMonAn);
                if (_cthd == null)
                    return false;

            int soLuongBanDau = (int)_cthd.SoLuong;

                _cthd.MaMonAn = suaBanHang.MaMonAn;
                _cthd.SoLuong = suaBanHang.SoLuong;
                _cthd.ChietKhau = suaBanHang.ChietKhau;
                _cthd.TongTien = suaBanHang.TongTien;
                _cthd.MonAn.MaLoai = suaBanHang.MaLoai;

            if (soLuongBanDau < _cthd.SoLuong)
            {
                monAn.SLTonKho -= (_cthd.SoLuong - soLuongBanDau);
            }
            else if (soLuongBanDau > _cthd.SoLuong)
            {
                monAn.SLTonKho += (soLuongBanDau - _cthd.SoLuong);
            }
           
                tdnEnti.SaveChanges();
                return true;
        }
        catch (Exception)
        {
            return false;
        }
}
        // xoá
        public bool XoaDSBanHang(BanHangDTO xoads, int mamonan, int soluong)
        {
            try
            {
                var monAn = tdnEnti.MonAns.Single(ma => ma.MaMonAn == mamonan);
                monAn.SLTonKho += soluong;
                CTHD dsbh = new CTHD
                {
                    MaHD = xoads.MaHD,
                    MaMonAn = xoads.MaMonAn,
                    
                };
                CTHD _cthd = tdnEnti.CTHDs.SingleOrDefault(u => u.MaHD == xoads.MaHD && u.MaMonAn == xoads.MaMonAn);
                if (_cthd == null)
                    return false;
                _cthd.TrangThai = false;
                _cthd.Xoa = false;
                tdnEnti.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<BanHangDTO> DS_HoaDon()
        {
            return tdnEnti.HoaDons.Where(ct => ct.ThanhToan == true).Select(u => new BanHangDTO
            {
                MaHD = u.MaHD,
                NgayLapHD = u.NgayLapHD,
                MaNV = u.MaNV,
                MaBan = u.MaBan,
                ThanhToan = u.ThanhToan == null ? Const.BH_ChuoiRong : (u.ThanhToan.Value ? Const.BH_ChuaThanhToan : Const.BH_DaThanhToan),
                TenBan = u.BanAn.TenBan,
            }).ToList();
        }

        public List<BanHangDTO> DS_BanTrong()
        {
            return tdnEnti.BanAns.Where(ct => ct.BanTrong == false).Select(u => new BanHangDTO
            {
                MaBan = u.MaBan,
                TenBan = u.TenBan,
            }).ToList();

        }
        public bool AnCTHD_HD(BanHangDTO anctdh_hd)
        {
            List<CTHD> danhSachCTHD = tdnEnti.CTHDs.Where(ct => ct.MaHD == anctdh_hd.MaHD).ToList();
            foreach (CTHD cthd in danhSachCTHD)
            {
                cthd.TrangThai = false;
            }

            // Cập nhật trạng thái của hóa đơn trong bảng HoaDon
            HoaDon hoaDon = tdnEnti.HoaDons.SingleOrDefault(hd => hd.MaHD == anctdh_hd.MaHD);
            {
                hoaDon.TienThua = Convert.ToInt32(anctdh_hd.TienThua);
            }
            if (hoaDon != null)
            {
                
                hoaDon.ThanhToan = false;
            }

            BanAn banAn = tdnEnti.BanAns.SingleOrDefault(hd => hd.MaBan == anctdh_hd.MaBan);
            if (banAn != null)
            {
                banAn.BanTrong = false;
            }


            // Lưu các thay đổi vào cơ sở dữ liệu
            tdnEnti.SaveChanges();
            return true;
        }

        
    }
}
