
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmQLNhanVien : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();

        FrmQuanLy FrmQuanLy;

        public FrmQLNhanVien(FrmQuanLy frmQuanLy)
        {
            InitializeComponent();
            FrmQuanLy = frmQuanLy;
            dgvDSNV.AutoGenerateColumns = false;
            dgvDSNV.AllowUserToAddRows = false;
            cbbChucVu.SelectedIndex = Const.cbbChucVuSeIn;
            cbbTimKiem.SelectedIndex = Const.cbbTimKiem;
            dgvDSNV.CellClick += new DataGridViewCellEventHandler(dgvDSNV_CellContentClick);
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = nvBUS.LayDSNhanVien();
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSNV.SelectedCells.Count > Const.dgvDSNVsecellscount)
            {
                DataGridViewCell cell = dgvDSNV.SelectedCells[Const.dgvDSNVsecells];
                DataGridViewRow row = cell.OwningRow;
                txtMaNV.Text = row.Cells[Const.dgvMaNV].Value.ToString();
                txtHoTen.Text = row.Cells[Const.dgvHoTen].Value.ToString();
                radNam.Checked = row.Cells[Const.dgvNam].Value.ToString() == Const.GioiTinhNam;
                radNu.Checked = row.Cells[Const.dgvNu].Value.ToString() == Const.GioiTinhNu;
                txtEmail.Text = row.Cells[Const.dgvEmail].Value.ToString();
                txtSDT.Text = row.Cells[Const.dgvSDT].Value.ToString();
                dtpNgayVaoLam.Value = Convert.ToDateTime(row.Cells[Const.dgvNgayVaoLam].Value);
                txtDiaChi.Text = row.Cells[Const.dgvDiaChi].Value.ToString();
                cbbChucVu.Text = row.Cells[Const.dgvChucVu].Value.ToString();

                // Lấy dữ liệu hình ảnh từ cột có chỉ số là 8 (nếu cột đó là cột chứa hình ảnh)
                if (row.Cells[Const.dgvHinhAnh].Value != null)
                {
                    // Đọc dữ liệu hình ảnh từ cell và chuyển đổi sang kiểu byte[]
                    byte[] imageBytes = (byte[])row.Cells[Const.dgvHinhAnh].Value;

                    // Chuyển đổi kiểu byte[] sang kiểu Image
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        // Hiển thị hình ảnh lên PictureBox
                        picHinhAnh.Image = image;
                    }
                }
                else
                {
                    // Gán giá trị null cho Image của PictureBox để hiển thị giá trị null
                    picHinhAnh.Image = null;
                }
            }
        }

        // chuyển ảnh về dạng byte
        private byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imageToConvert);
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void icbtnThemAnh_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            ofdFile.InitialDirectory = Const.NV_ofdFile_InitialDirectory;

            ofdFile.Filter = Const.NV_ofdFile_Filter;
            ofdFile.FilterIndex = Const.ofdFile_FilterIndex;
            ofdFile.RestoreDirectory = true;
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofdFile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            picHinhAnh.Image = Image.FromStream(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Const.Khong_The_TaiAnh + ex.Message,Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image == null)
            {
                MessageBox.Show(Const.Khong_Co_HinhAnh, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) 
                || string.IsNullOrEmpty(txtSDT.Text.Trim()) || string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                MessageBox.Show(Const.Khong_Day_Du_ThongTin, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhanVienDTO insNV = new NhanVienDTO()
            {
                TenNV = txtHoTen.Text,
                GioiTinh = radNam.Checked ? Const.GioiTinhNam : Const.GioiTinhNu,
                Email = txtEmail.Text,
                SDT =  txtSDT.Text,
                NgayVaoLam = dtpNgayVaoLam.Value,
                DiaChi = txtDiaChi.Text,
                ChucVu = cbbChucVu.Text,
                HinhAnh = ConvertImageToByteArray(picHinhAnh.Image),
                TrangThai = true
            };

            if (nvBUS.CheckPhoneNumber(insNV.SDT) && nvBUS.CheckEmail(insNV.Email) && nvBUS.ThemNV(insNV))
            {  
                MessageBox.Show(Const.themNVThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDangKy dk = new FrmDangKy();
                FrmQLNhanVien_Load(sender, e);
                reset_Text();
                dk.ShowDialog();               
            }
            else
            {
                MessageBox.Show(Const.themNVThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image == null)
            {
                MessageBox.Show(Const.Khong_Co_HinhAnh,Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvDSNV.SelectedRows.Count == Const.dgvDSNV_SelectedRows_Count)
            {
                MessageBox.Show(Const.ChonNVCanSua, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int maNV = Convert.ToInt32(txtMaNV.Text);
                NhanVienDTO nv = new NhanVienDTO()
                {
                    MaNV = maNV,
                    TenNV = txtHoTen.Text,
                    GioiTinh = radNam.Checked ? Const.GioiTinhNam : Const.GioiTinhNu,
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                    NgayVaoLam = dtpNgayVaoLam.Value,
                    DiaChi = txtDiaChi.Text,
                    ChucVu = cbbChucVu.Text,
                    HinhAnh = ConvertImageToByteArray(picHinhAnh.Image),
                };
                if (nvBUS.CheckPhoneNumber(nv.SDT) && nvBUS.CheckEmail(nv.Email) && nvBUS.SuaNhanVien(nv))
                {
                    MessageBox.Show(Const.suaNVThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Const.suaNVThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                FrmQLNhanVien_Load(sender, e);
                reset_Text();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if(dgvDSNV.SelectedRows.Count == Const.dgvDSNV_SelectedRows_Count)
            {
                MessageBox.Show(Const.ChonNVCanXoa, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult delete = MessageBox.Show(Const.xacNhanXoa, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    int maNV = Convert.ToInt32(txtMaNV.Text);

                    if (maNV == Const.MaNV_KhongXoa)
                    {
                        MessageBox.Show(Const.NV_admin, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    NhanVienDTO nv = new NhanVienDTO()
                    {
                        MaNV = maNV,
                    };
                    // xoá mất luôn
                    //BanHang.SANPHAMs.Remove(spEF);
                    if (nvBUS.XoaNhanVien(nv))
                    {
                        MessageBox.Show(Const.xoaNVThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmQLNhanVien_Load(sender, e);
                        reset_Text();
                    }
                    else
                    {
                        MessageBox.Show(Const.xoaNVThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                FrmQLNhanVien_Load(sender, e);
            }
            else
            {
                // Thực hiện tìm kiếm và hiển thị kết quả             
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex0)
                {
                    string HoTenNV = txtTimKiem.Text;
                    List<NhanVienDTO> nvien = nvBUS.DSNhanVien_TenNV(HoTenNV);
                    dgvDSNV.DataSource = nvien;
                }

                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex1)
                {
                    try
                    {
                        int maNhanVien = int.Parse(txtTimKiem.Text);
                        NhanVien nv = new NhanVien()
                        {
                            MaNV = maNhanVien
                        };
                        dgvDSNV.DataSource = nvBUS.DSNhanVien_MaNV(nv);

                    }
                    catch(Exception)
                    {
                        MessageBox.Show(Const.ChiNhapSo, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKiem.Text = string.Empty;
                    }
                }
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            FrmQLNhanVien_Load(sender, e);
        }

        private void radALLnvNam_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = nvBUS.DSNhanVien_Nam();
        }

        private void radALLnvNu_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = nvBUS.DSNhanVien_Nu();

        }
        public void reset_Text()
        {
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtSDT.Text = string.Empty;  
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_Text();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
