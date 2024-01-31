using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class BieuDoDAO
    {
        TDNEntities tDNEntities = new TDNEntities();

        public List<BieuDoDTO> DSTongTien()
        {
            var lst = tDNEntities.CTHDs.ToList();

            return lst.Where(u => u.TrangThai == false && u.Xoa == true).Select(t => new BieuDoDTO
            {
                TONGTIEN = t.TongTien.Value,
                THANG = t.HoaDon.NgayLapHD.Date,
                NAM = t.HoaDon.NgayLapHD.Year
            }).ToList();
        }

        public List<BieuDoDTO> LayNam()
        {
            var lst = tDNEntities.CTHDs.ToList();
            return lst.Where(u => u.TrangThai == false && u.Xoa == true).GroupBy(v => v.HoaDon.NgayLapHD.Year).Select(u => new BieuDoDTO
            {
                NAM = u.Key,
            }).ToList();
        }
    }
}
