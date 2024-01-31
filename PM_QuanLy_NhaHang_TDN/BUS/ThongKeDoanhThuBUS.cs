using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using PM_QuanLy_NhaHang_TDN;

namespace BUS
{
    public class ThongKeDoanhThuBUS
    {
        ThongKeDoanhThuDAO _ThongKeDoanhThuDAO = new ThongKeDoanhThuDAO();

        public List<ThongKeDoanhThuDTO> DSChiTietHD(int mahd)
        {
            return _ThongKeDoanhThuDAO.DSChiTietHD(mahd);
        }

        // Tìm kiếm
        public List<ThongKeDoanhThuDTO> TimKiemTheoNgay(DateTime ngayDau, DateTime ngayCuoi)
        {
            return _ThongKeDoanhThuDAO.TimKiemTheoNgay(ngayDau, ngayCuoi);
        }

        public decimal TinhTong(List<ThongKeDoanhThuDTO> tinhTongs)
        {
            decimal tong = Const.tong;
            foreach (ThongKeDoanhThuDTO tinhTong in tinhTongs)
            {
                tong += tinhTong.TONGTIEN;
            }
            return tong;
        }

        public DataTable DSTongTien(int chonNam)
        {
            List<ThongKeDoanhThuDTO> tongtien = _ThongKeDoanhThuDAO.DSTongTien();
            DataTable table = new DataTable();
            table.Columns.Add(Const.tableDT_MAHD, typeof(int));
            table.Columns.Add(Const.tableDT_TONGTIEN, typeof(decimal));
            table.Columns.Add(Const.tableDT_SOLUONG, typeof(int));
            table.Columns.Add(Const.tableDT_MAMONAN, typeof(string));
            table.Columns.Add(Const.tableDT_CHIETKHAU, typeof(int));
            table.Columns.Add(Const.tableDT_NGAY, typeof(DateTime));

            var tt = tongtien.Where(t => t.NAM == chonNam).Select(u => new
            {
                MAHD = u.MAHD,
                TONGTIEN = u.TONGTIEN,
                MAMONAN = u.MAMONAN,
                SOLUONG = u.SOLUONG,
                CHIETKHAU = u.CHIETKHAU,
                NGAYLAPHD = u.NGAYLAPHD
            });

            foreach (var item in tt)
            {
                table.Rows.Add(item.MAHD,item.TONGTIEN,item.SOLUONG,item.MAMONAN,item.CHIETKHAU,item.NGAYLAPHD);
            }

            return table;
        }

        public List<ThongKeDoanhThuDTO> LayNam()
        {
            return _ThongKeDoanhThuDAO.LayNam();
        }
    }
}
