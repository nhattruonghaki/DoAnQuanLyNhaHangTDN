using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeTheoMonDTO
    {
        public int MAMONAN { get; set; }
        public int MALOAI { get; set; }
        public string TENMONAN { get; set; }
        public int SLTONKHO { get; set; }
        public int DONGIA { get; set; }
        public string MANCC { get; set; }

        public string TenLoai { get; set; }
        public byte[] HinhAnh { get; set; }
    }
}
