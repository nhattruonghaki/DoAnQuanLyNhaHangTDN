using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int MaLoaiTK { get; set; }
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public bool TrangThai { get; set; }

        public string LoaiTK { get; set; }
        

        public int MaLoaiTaiKhoan { get; set; }
        public string TenLoaiTaiKhoan { get; set; }
        public bool Quyen { get; set; }


    }
}
