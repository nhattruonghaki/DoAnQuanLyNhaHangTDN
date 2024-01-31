using BUS;
using DAO;
using DTO;
using Microsoft.ReportingServices.Diagnostics.Internal;
using PM_QuanLy_NhaHang_TDN.BaoCao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLy_NhaHang_TDN.BanHang
{
    public partial class FrmBanHang : Form
    {
        FrmTrangChu FrmTrangChu;
        MonAnBUS monanBUS = new MonAnBUS();
        BanAnBUS banAnBUS = new BanAnBUS();
        BanHangBUS banhangBUS = new BanHangBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        ThongKeTheoMonBUS theomonBUS = new ThongKeTheoMonBUS();
        public int tienthua;

        // đường dẫn hình ảnh tương đối
        private string folderPath = Const.BH_folderPath;
        public FrmBanHang(FrmTrangChu frmTrangChu)
        {
            InitializeComponent();
            FrmTrangChu = frmTrangChu;
            int ma = frmTrangChu.manv;
            txtMaNhanVien.Text = ma.ToString();

            string ten = frmTrangChu.nv;
            txtTenNhanVien.Text = ten.ToString();

            dgvDSMonAnKhachChon.AutoGenerateColumns = false;
            dgvDSMonAnKhachChon.AllowUserToAddRows = false;

            dgvDSHD.AutoGenerateColumns = false;
            dgvDSHD.AllowUserToAddRows = false;
        }
        private void FrmBanHang_Load(object sender, EventArgs e)
        {  
            // lấy danh sách hoá đơn
            dgvDSHD.DataSource = banhangBUS.DS_HoaDon();
            
            cbbLoaiMenu.DataSource = monanBUS.LayDSLoaiMonAn();
            cbbLoaiMenu.DisplayMember = Const.BH_cbbLoaiMenu_DisplayMember;
            cbbLoaiMenu.ValueMember = Const.BH_cbbLoaiMenu_ValueMember;

            cbbBanTrong.DataSource = banhangBUS.DS_BanTrong();
            cbbBanTrong.DisplayMember = Const.BH_cbbBanTrong_DisplayMember;
            cbbBanTrong.ValueMember = Const.BH_cbbBanTrong_ValueMember;

        }

        private void cbbLoaiMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiMenu.SelectedIndex == Const.cbbLoaiMenu_SelectedIndex0)
            {


                cbbTenMonAn.DataSource = theomonBUS.DSMonAn_Thit();
                cbbTenMonAn.DisplayMember = Const.BH_cbbTenMonAn_DisplayMember;
                cbbTenMonAn.ValueMember = Const.BH_cbbTenMonAn_ValueMember;


            }
            if (cbbLoaiMenu.SelectedIndex == Const.cbbLoaiMenu_SelectedIndex1)
            {
                cbbTenMonAn.DataSource = theomonBUS.DSMonAn_HaiSan();
                cbbTenMonAn.DisplayMember = Const.BH_cbbTenMonAn_DisplayMember;
                cbbTenMonAn.ValueMember = Const.BH_cbbTenMonAn_ValueMember;
            }
            if (cbbLoaiMenu.SelectedIndex == Const.cbbLoaiMenu_SelectedIndex2)
            {
                cbbTenMonAn.DataSource = theomonBUS.DSMonAn_RauCu();
                cbbTenMonAn.DisplayMember = Const.BH_cbbTenMonAn_DisplayMember;
                cbbTenMonAn.ValueMember = Const.BH_cbbTenMonAn_ValueMember;
            }
            if (cbbLoaiMenu.SelectedIndex == 3)
            {
                cbbTenMonAn.DataSource = theomonBUS.DS_Nuoc();
                cbbTenMonAn.DisplayMember = Const.BH_cbbTenMonAn_DisplayMember;
                cbbTenMonAn.ValueMember = Const.BH_cbbTenMonAn_ValueMember;
            }
        }
        private void cbbTenMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(folderPath + Const.BH_DuongDan + cbbTenMonAn.SelectedValue + Const.BH_Duoi_jpg))
            {
                byte[] byteHA = File.ReadAllBytes(folderPath + Const.BH_DuongDan + cbbTenMonAn.SelectedValue + Const.BH_Duoi_jpg);

                MemoryStream mos = new MemoryStream(byteHA);

                picHinhAnh.Image = Image.FromStream(mos);
            }
            else
            {
                picHinhAnh.Image = null;
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show(Const.BH_VuiLongChonBan, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtChietKhau.Text))
            {
                MessageBox.Show(Const.BH_VuiLongNhapSLvaCK, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            BanHangDTO ds = new BanHangDTO()
            {
                MaHD = Convert.ToInt32(txtMaHD.Text),
                MaMonAn = Convert.ToInt32(cbbTenMonAn.SelectedValue),
                SoLuong = soluong,
                ChietKhau = Convert.ToInt32(txtChietKhau.Text),
                TrangThai = true,
                XoaCTHD = true
            };

            if(soluong <= Const.BH_Soluong)
            {
                MessageBox.Show(Const.BH_VuiLongNhapLaiSL, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (banhangBUS.TruSoLuongMon(ds.MaMonAn, ds.SoLuong))
                {
                    if (banhangBUS.ThemDSBanHang(ds))
                    {
                        MessageBox.Show(Const.BH_ThemMonThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Const.BH_ThemMonThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Const.BH_SoLuongKhongDu, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvDSHD_SelectionChanged(sender, e);
            }
            
        }
        private void icbtnThemHoaDon_Click(object sender, EventArgs e)
        {
            BanHangDTO ds = new BanHangDTO()
            {
                NgayLapHD = DateTime.Now,
                MaBan = Convert.ToInt32(cbbBanTrong.SelectedValue),
                MaNV = Convert.ToInt32(txtMaNhanVien.Text),
                ThanhToan = Const.BH_ds_ThanhToan,
                BanTrong = Const.BH_ds_BanTrong,
            };
            if (banhangBUS.ThemHD(ds) && banhangBUS.ThemBanTrong(ds.MaBan))
            {
                MessageBox.Show(Const.BH_ThemHDThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmBanHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show(Const.BH_ThemHDThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                MessageBox.Show(Const.BH_VuiLongChonMon, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvDSMonAnKhachChon.SelectedRows.Count > Const.dgvDSMonAnKhachChon_SelectedRows_Count)
            {
                BanHangDTO ds = new BanHangDTO()
                {
                    MaHD = Convert.ToInt32(txtMaHD.Text),
                    MaLoai = Convert.ToInt32(cbbLoaiMenu.SelectedValue),
                    MaMonAn = Convert.ToInt32(cbbTenMonAn.SelectedValue),
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    ChietKhau = Convert.ToInt32(txtChietKhau.Text),
                };
                if (banhangBUS.SuaDSBanHang(ds,ds.MaMonAn))
                {
                    MessageBox.Show(Const.BH_SuaMonThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSHD_SelectionChanged(sender, e);
                }
                else
                {
                    MessageBox.Show(Const.BH_SuaMonThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvDSHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSHD.SelectedCells.Count > Const.dgvDSHD_SelectedCells_Count)
            {
                DataGridViewCell selectedCell = dgvDSHD.SelectedCells[Const.dgvDSHD_SelectedCells];
                int rowIndex = selectedCell.RowIndex;
                int maHoaDon = Convert.ToInt32(dgvDSHD.Rows[rowIndex].Cells[Const.BH_maHoaDon].Value);
                dgvDSMonAnKhachChon.DataSource = banhangBUS.ChiTietBanHang(maHoaDon);

                int tongThanhTien = Const.BH_tongThanhTien;
                foreach (DataGridViewRow row in dgvDSMonAnKhachChon.Rows)
                {
                    if (Convert.ToInt32(row.Cells[Const.BH_Cells_dgvMaHD].Value) == maHoaDon)
                    {                        
                        tongThanhTien += Convert.ToInt32(row.Cells[Const.BH_Cells_dgvTong].Value);
                    }
                }
                txtTongTien.Text = tongThanhTien.ToString();
            }
        }

        private void txtTraTien_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTraTien.Text.Trim()))
            {
                MessageBox.Show(Const.BH_VuiLongNhapTien, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int tongThanhTien = Convert.ToInt32(txtTongTien.Text);
            int tienTra = Convert.ToInt32(txtTraTien.Text);
            int tienCanTra = tienTra - tongThanhTien;
            txtTienThua.Text = tienCanTra.ToString();
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == Const.i) return;
            LabelTrangThai.Text = Const.BH_labelTrangThai;
            lblBan.Text = dgvDSHD.Rows[i].Cells[Const.BH_lblBan].Value.ToString();
            txtMaHD.Text = dgvDSHD.Rows[i].Cells[Const.BH_maHoaDon].Value.ToString();
            lblTrangThai.Text = dgvDSHD.Rows[i].Cells[Const.BH_lblThanhToan].Value.ToString();
        }
        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            dgvDSHD_CellContentClick(sender, e);
        }

        private void icbtnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTraTien.Text.Trim()) || string.IsNullOrEmpty(txtMaHD.Text.Trim()))
            {
                MessageBox.Show(Const.BH_VuiLong_ThanhToan_NhapTien, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int hd = Convert.ToInt32(txtMaHD.Text);
            int maban = Convert.ToInt32(lblBan.Text);
            string tennv = txtTenNhanVien.Text;
            string TienThua = txtTienThua.Text;
            
            BanHangDTO banhang = new BanHangDTO()
            {
                MaHD = hd,
                MaBan = maban,
                TenNV = tennv,
                TienThua= TienThua
            };
            tienthua = Convert.ToInt32(txtTienThua.Text);
            if(tienthua < Const.tienthua)
            {
                MessageBox.Show(Const.BH_VuiLongNhapDuTien, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (banhangBUS.AnCTHD_HD(banhang))
                {
                    MessageBox.Show(Const.BH_ThanhToanThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmXuatHoaDon xuathd = new FrmXuatHoaDon(banhang.MaHD, banhang.TenNV, banhang.MaBan,banhang.TienThua);
                    xuathd.Show();
                    FrmBanHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Const.BH_ThanhToanThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                MessageBox.Show(Const.BH_VuiLongChonMon, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BanHangDTO bh = new BanHangDTO()
            {
                MaHD = Convert.ToInt32(txtMaHD.Text),
                MaMonAn = Convert.ToInt32(txtMaMonAn.Text),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
            };
            
            if (banhangBUS.XoaDSBanHang(bh,bh.MaMonAn,bh.SoLuong))
            {
                DialogResult xoa = MessageBox.Show(Const.BH_XacNhanXoa, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(xoa == DialogResult.Yes)
                {
                    MessageBox.Show(Const.BH_XoaMonThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSHD_SelectionChanged(sender, e);
                }
            }
            else
            {
                MessageBox.Show(Const.BH_XoaMonThatBai, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDSMonAnKhachChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == Const.i) return;
            txtMaMonAn.Text = dgvDSMonAnKhachChon.Rows[i].Cells[Const.BH_TxtMaMonAn].Value.ToString();
            txtMaHD.Text = dgvDSMonAnKhachChon.Rows[i].Cells[Const.BH_Cells_dgvMaHD].Value.ToString();
            txtSoLuong.Text = dgvDSMonAnKhachChon.Rows[i].Cells[Const.BH_TxtSoLuong].Value.ToString();
            cbbLoaiMenu.Text = dgvDSMonAnKhachChon.Rows[i].Cells[Const.BH_CbbLoaiMenu].Value.ToString();
            cbbTenMonAn.Text = dgvDSMonAnKhachChon.Rows[i].Cells[Const.BH_CbbTenMonAn].Value.ToString();
            txtChietKhau.Text = dgvDSMonAnKhachChon.Rows[i].Cells[Const.BH_TxtChietKhau].Value.ToString();
        }

        private void dgvDSMonAnKhachChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            dgvDSMonAnKhachChon_CellContentClick(sender, e);
        }

        private void txtTraTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbbBanTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBanTrong.SelectedIndex >= Const.cbbBanTrong_SelectedIndex)
            {
                BanHangDTO selectedBan = (BanHangDTO)cbbBanTrong.SelectedItem;
                lblBan.Text = selectedBan.MaBan.ToString();
                lblTrangThai.Text = Const.BH_DangTrong;   
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = string.Empty;
            txtChietKhau.Text = string.Empty;
            txtMaHD.Text = string.Empty;
            txtTraTien.Text = string.Empty;
            txtTienThua.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            txtMaMonAn.Text = string.Empty;
            FrmBanHang_Load(sender, e);
        }
    }
}
