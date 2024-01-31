using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmThongKeDoanhThu : Form
    {
        FrmThongKe FrmThongKe;
        ThongKeDoanhThuBUS _ThongKeDoanhThuBUS = new ThongKeDoanhThuBUS();
        public FrmThongKeDoanhThu(FrmThongKe frmThongKe)
        {
            InitializeComponent();
            FrmThongKe = frmThongKe;
            dgvDSDoanhThu.AutoGenerateColumns = false;
            dgvDSDoanhThu.AllowUserToAddRows = false;
        }

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            List<ThongKeDoanhThuDTO> danhSachNam = _ThongKeDoanhThuBUS.LayNam();

            cbbNam.DisplayMember = Const.cbbNam;
            cbbNam.ValueMember = Const.cbbNam;
            cbbNam.DataSource = danhSachNam;

            cbbNam.SelectedIndexChanged += cbbNam_SelectedIndexChanged;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dtpNgayBatDau.Value;
            DateTime ngaykt = dtpNgayKetThuc.Value;
            List<ThongKeDoanhThuDTO> ngay = _ThongKeDoanhThuBUS.TimKiemTheoNgay(ngaybd, ngaykt);
            dgvDSDoanhThu.DataSource = ngay;

            decimal tongTien = ngay.Sum(item => item.TONGTIEN);
            string dinhDangTT = string.Format(Const.DinhDang, tongTien);
            lblTinhTong.Text = Const.lblTinhTong + dinhDangTT;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            FrmThongKeDoanhThu_Load(sender, e);
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = int.Parse(cbbNam.SelectedValue.ToString());
            DataTable danhSachTrongNam = _ThongKeDoanhThuBUS.DSTongTien(nam);
            decimal tongTienNam = Const.tongTienNam;


            if (danhSachTrongNam.Rows.Count > Const.danhSachTrongNam_Rows_Count)
            {
                foreach (DataRow row in danhSachTrongNam.Rows)
                {
                    tongTienNam += Convert.ToDecimal(row[Const.Tong_So_Tien]);
                }
            }
            string dinhDangTT = string.Format(Const.DinhDang, tongTienNam);
            dgvDSDoanhThu.DataSource = danhSachTrongNam;
            lblTinhTong.Text = Const.lblTinhTong + dinhDangTT;
        }
    }
}
