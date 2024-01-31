using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using PM_QuanLy_NhaHang_TDN;

namespace BUS
{
    public class BieuDoBUS
    {
        BieuDoDAO _BieuDoDAO = new BieuDoDAO();
        public DataTable DSTongTien(int chonNam)
        {
            List<BieuDoDTO> tongtien = _BieuDoDAO.DSTongTien();
            DataTable table = new DataTable();
            table.Columns.Add(Const.table_THANG, typeof(string));
            table.Columns.Add(Const.table_TONGTIEN, typeof(decimal));

            var tt = tongtien.Where(t => t.THANG.Year == chonNam).GroupBy(t => t.THANG.Month).Select(u => new
            {
                THANG = new DateTime(chonNam, u.Key, 1).ToString(Const.thang_DateTime),
                TONGTIEN = u.Sum(t => t.TONGTIEN)
            });

            foreach (var item in tt)
            {
                table.Rows.Add(item.THANG, item.TONGTIEN);
            }

            return table;
        }

        public List<BieuDoDTO> LayNam()
        {
            return _BieuDoDAO.LayNam();
        }
    }
}
