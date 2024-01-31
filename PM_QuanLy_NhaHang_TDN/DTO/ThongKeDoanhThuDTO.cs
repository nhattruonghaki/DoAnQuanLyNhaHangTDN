using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDoanhThuDTO
    {
        public int MAHD { get; set; }
        public string MAMONAN { get; set; }
        public int SOLUONG { get; set; }
        public int TONGTIEN { get; set; }
        public int CHIETKHAU { get; set; }

        public DateTime NGAYLAPHD { get; set; }
        public int NAM { get; set; }
        public string TENNV { get; set; }
        public int DONGIA { get; set; }
        public int MABAN { get; set; }
        public bool TRANGTHAI { get; set; }
        public bool XOA { get; set; }
        public int TIENTHUA { get; set; }
    }
}
