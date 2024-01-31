using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanHangDTO
    {
        public int MaHD { get; set; }
        public int MaMonAn { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
        public int ChietKhau { get; set; }
        public bool TrangThai { get; set; }

        public string TenMonAn { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int MaNV { get; set; }
        public int MaBan { get; set; }

        public bool XoaCTHD { get; set; }
        public string BanTrong { get; set; }

        public string TenBan { get; set; }
        public string ThanhToan { get; set; }
        public int DonGia { get; set; }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string TenNV { get; set; }
        public string TienThua { get; set; }
    }
}
