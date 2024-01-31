using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmBieuDo : Form
    {
        FrmThongKe FrmThongKe;
        BieuDoBUS _BieuDoBUS = new BieuDoBUS();
        public FrmBieuDo(FrmThongKe frmThongKe)
        {
            InitializeComponent();
            FrmThongKe = frmThongKe;
        }

        private void FrmBieuDo_Load(object sender, EventArgs e)
        {
            cbbNam.DataSource = _BieuDoBUS.LayNam();
            cbbNam.DisplayMember = "NAM";
            cbbNam.ValueMember = "NAM";
            cbbNam.SelectedIndexChanged += cbbNam_SelectedIndexChanged;
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chon_so = cbbNam.SelectedIndex;
            if (chon_so >= 0 && chon_so < cbbNam.Items.Count)
            {
                BieuDoDTO chonNam = (BieuDoDTO)cbbNam.Items[chon_so];

                // Lấy giá trị NAM từ selectedNam
                int giaTriNam = chonNam.NAM;

                // Lấy dữ liệu tổng tiền của mỗi tháng trong năm được chọn
                DataTable table = _BieuDoBUS.DSTongTien(giaTriNam);

                table.DefaultView.Sort = "THANG ASC";
                table = table.DefaultView.ToTable();

                dgvDSTongTien.DataSource = table;

                // Cập nhật dữ liệu cho chart
                chart.DataSource = table;
                chart.Series["Tổng tiền"].XValueMember = "THANG";
                chart.Series["Tổng tiền"].YValueMembers = "TONGTIEN";

                // Vẽ lại chart
                chart.DataBind();
            }
        }
    }
}
