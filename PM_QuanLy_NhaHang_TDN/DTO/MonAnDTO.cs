using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAnDTO
    {
        public int MaMonAn { get; set; }
        public int MaLoai { get; set; }
        public string TenMonAn { get; set; }
        public int SLTonKho { get; set; }
        public int DonGia { get; set; }
        public int MaNCC { get; set; }
        public byte[] HinhAnh { get; set; }
        public bool TrangThai { get; set; }
        public string TenLoai { get; set; }

    }
}
