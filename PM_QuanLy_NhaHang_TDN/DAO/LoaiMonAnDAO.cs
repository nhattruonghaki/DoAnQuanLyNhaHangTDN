using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoaiMonAnDAO
    {
        TDNEntities _TDNEntities = new TDNEntities();

        public List<LoaiMonAnDTO> DSLoaiMonAn()
        {
            var lst = _TDNEntities.LoaiMonAns.ToList();
            return lst.Select(u => new LoaiMonAnDTO
            {
                MALOAI = u.MaLoai,
                TENLOAI = u.TenLoai
            }).ToList();

        }
        public List<LoaiMonAnDTO> DSLoaiMonAn(int maloai)
        {
            return _TDNEntities.LoaiMonAns.Where(v => v.MaLoai == maloai).Select(u => new LoaiMonAnDTO
            {
                MALOAI = u.MaLoai,
                TENLOAI = u.TenLoai
            }).ToList();
        }



    }
}
