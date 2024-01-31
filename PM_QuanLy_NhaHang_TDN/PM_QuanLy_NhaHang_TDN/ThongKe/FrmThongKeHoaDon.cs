using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;
using PM_QuanLy_NhaHang_TDN.BaoCao;
using PM_QuanLy_NhaHang_TDN.BanHang;
using DevExpress.XtraRichEdit.Model;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmThongKeHoaDon : Form
    {
        FrmThongKe FrmThongKe;
        ThongKeHoaDonBUS _ThongKeHoaDonBUS = new ThongKeHoaDonBUS();
        
        public FrmThongKeHoaDon(FrmThongKe frmThongKe)
        {
            InitializeComponent();
            FrmThongKe = frmThongKe;
            dgvDSHD.AutoGenerateColumns = false;
            cbbTimKiem.SelectedIndex = Const.cbbTimKiem_SelectedIndex0;

            //string ten = frmThongKe.tennv;
            //txtTenNV.Text = ten;
            //int tien = frmThongKe.tienThua;
            //txtTienThua.Text = tien.ToString();

        }

        private void FrmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = _ThongKeHoaDonBUS.DSHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dtpNgayBatDau.Value;
            DateTime ngaykt = dtpNgayKetThuc.Value;
            List<ThongKeHoaDonDTO> ngay = _ThongKeHoaDonBUS.TimKiemTheoNgay(ngaybd, ngaykt);
            dgvDSHD.DataSource = ngay;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                FrmThongKeHoaDon_Load(sender, e);
            }
            else
            {
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex0)
                {
                    try
                    {
                        int maHD = int.Parse(txtTimKiem.Text);     
                        HoaDon ma = new HoaDon()
                    {
                        MaHD = maHD,
                    };

                    dgvDSHD.DataSource = _ThongKeHoaDonBUS.DSHoaDon_MaHD(ma);

                    }
                    catch (Exception)
                    {
                       
                        MessageBox.Show(Const.ChiNhapSo, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKiem.Text = string.Empty;
                    }
                }

                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex1)
                {
                    string tenNV = txtTimKiem.Text;

                    List<ThongKeHoaDonDTO> ten = _ThongKeHoaDonBUS.DSHoaDon_TenNV(tenNV);
                    dgvDSHD.DataSource = ten;
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbTimKiem.Text = String.Empty;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtTimKiem.Text = String.Empty;

            FrmThongKeHoaDon_Load(sender, e);
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            FrmBaoCaoHoaDon hd = new FrmBaoCaoHoaDon();
            hd.ShowDialog();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDSHD.SelectedRows.Count > Const.dgvDSHD_SelectedCells_Count)
            {
                int laphd = Convert.ToInt32(txtMaHD.Text);
                string tenNV = txtTenNV.Text;
                DateTime ngay = dtpNgayLapHD.Value;
                int maban = Convert.ToInt32(txtMaBan.Text);
                int tienthua = Convert.ToInt32(txtTienThua.Text);
                ThongKeDoanhThuDTO hd = new ThongKeDoanhThuDTO()
                {
                    MAHD = laphd,
                    TENNV = tenNV,
                    NGAYLAPHD = ngay,
                    MABAN = maban,
                    TIENTHUA = tienthua,
                };

                FrmChiTietHoaDon frm = new FrmChiTietHoaDon(hd.MAHD, hd.TENNV,hd.NGAYLAPHD,hd.MABAN,hd.TIENTHUA);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(Const.chon_Ma_Hoa_Don, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == Const.i) return;
            txtMaHD.Text = dgvDSHD.Rows[i].Cells[Const.HD_dgvMaHD].Value.ToString();
            txtTenNV.Text = dgvDSHD.Rows[i].Cells[Const.HD_dgvTenNV].Value.ToString();
            dtpNgayLapHD.Value = Convert.ToDateTime(dgvDSHD.Rows[i].Cells[Const.HD_dgvNgayLapHD].Value);
            txtMaBan.Text = dgvDSHD.Rows[i].Cells["dgvMaBan"].Value.ToString();
            txtTienThua.Text = dgvDSHD.Rows[i].Cells["dgvTienThua"].Value.ToString();
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            dgvDSHD_CellContentClick(sender, e);
        }

    }
}
