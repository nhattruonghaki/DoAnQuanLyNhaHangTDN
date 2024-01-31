using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;
using System.Drawing.Imaging;
using DAO;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmQLMonAn : Form
    {
        FrmQuanLy FrmQuanLy;
        MonAnBUS maBUS = new MonAnBUS();
        ThongKeTheoMonBUS theoMonBUS = new ThongKeTheoMonBUS();
        // đường dẫn hình ảnh tương đối
        private string folderPath = Const.QLMA_folderPath;
        public FrmQLMonAn(FrmQuanLy frmQuanLy)
        {
            InitializeComponent();
            FrmQuanLy = frmQuanLy;
            dgvDSMonAn.AutoGenerateColumns = false;
            dgvDSMonAn.AllowUserToAddRows = false;
            cbbTimKiem.SelectedIndex = Const.cbbTimKiem;
            dgvDSMonAn.CellClick += new DataGridViewCellEventHandler(dgvDSMonAn_CellContentClick);
        }

        private void FrmQLMonAn_Load(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = maBUS.LayDSMonAn();

            cbbLoaiMonAn.DataSource = maBUS.LayDSLoaiMonAn();
            cbbLoaiMonAn.DisplayMember = Const.cbbLoaiMonAn_DisplayMember;
            cbbLoaiMonAn.ValueMember = Const.cbbLoaiMonAn_ValueMember;

        }

        private void dgvDSMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSMonAn.SelectedCells.Count > Const.dgvDSMonAn_SelectedCells_Count)
            {
                DataGridViewCell cell = dgvDSMonAn.SelectedCells[Const.dgvDSMonAn_SelectedCells];
                DataGridViewRow row = cell.OwningRow;
                txtMaMonAn.Text = row.Cells[Const.dgvMaMonAn].Value.ToString();
                txtTenMonAn.Text = row.Cells[Const.dgvTenMonAn].Value.ToString();
                txtDonGia.Text = row.Cells[Const.dgvDonGia].Value.ToString();
                txtSL.Text = row.Cells[Const.dgvSoLuong].Value.ToString();
                cbbLoaiMonAn.Text = row.Cells[Const.dgvLoaiMonAn].Value.ToString();

                // Lấy dữ liệu hình ảnh từ cột có chỉ số là 8 (nếu cột đó là cột chứa hình ảnh)
                if (row.Cells[Const.row_Cells].Value != null)
                {
                    // Đọc dữ liệu hình ảnh từ cell và chuyển đổi sang kiểu byte[]
                    byte[] imageBytes = (byte[])row.Cells[Const.row_Cells].Value;

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
        //chuyển ảnh về dạng byte

        public void ChuyenAnhVaoThuMuc()
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(folderPath + Const.QLMA_DuongDan + txtMaMonAn.Text + Const.QLMA_Duoi_jpg, FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] bytes = ConvertImageToByteArray(picHinhAnh.Image);
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }
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
            ofdFile.InitialDirectory = Const.MA_ofdFile_InitialDirectory;

            ofdFile.Filter = Const.MA_ofdFile_Filter;
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
                    MessageBox.Show(Const.Khong_The_TaiAnh + ex.Message, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image == null)
            {
                MessageBox.Show(Const.Khong_Co_HinhAnh, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtTenMonAn.Text.Trim()) || string.IsNullOrEmpty(txtDonGia.Text.Trim())
                || string.IsNullOrEmpty(txtSL.Text.Trim()))
            {
                MessageBox.Show(Const.NhapDayDuThonTinMonAn, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                DataGridViewColumn column = dgvDSMonAn.Columns[Const.QLMA_dgvMaMonAn];
                int index = Convert.ToInt32(dgvDSMonAn.Rows[dgvDSMonAn.Rows.Count - Const.QLMA_index].Cells[column.Index].Value);
                txtMaMonAn.Text = string.Format(Const.QLMA_txtMaMonAn, (index + Const.QLMA_txtMaMonAn_index_1));

            MonAnDTO themma = new MonAnDTO()
            {
                TenMonAn = txtTenMonAn.Text,
                MaLoai = Convert.ToInt32(cbbLoaiMonAn.SelectedValue),
                DonGia = Convert.ToInt32(txtDonGia.Text),
                SLTonKho = Convert.ToInt32(txtSL.Text),
                HinhAnh = ConvertImageToByteArray(picHinhAnh.Image),
                TrangThai = true
            };
            ChuyenAnhVaoThuMuc();
            if (maBUS.ThemMonAn(themma))
            {
                MessageBox.Show(Const.Them_Mon_Thanh_Cong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmQLMonAn_Load(sender, e);
                reset_Text();
            }
            else
            {
                MessageBox.Show(Const.Them_Mon_That_Bai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image == null)
            {
                MessageBox.Show(Const.Khong_Co_HinhAnh, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvDSMonAn.SelectedRows.Count == Const.dgvDSTK_SelectedRows_Count)
            {
                MessageBox.Show(Const.MonAnCanSua, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int mama = Convert.ToInt32(txtMaMonAn.Text);
                MonAnDTO editma = new MonAnDTO()
                {
                    MaMonAn = mama,
                    TenMonAn = txtTenMonAn.Text,
                    MaLoai = Convert.ToInt32(cbbLoaiMonAn.SelectedValue),
                    DonGia = Convert.ToInt32(txtDonGia.Text),
                    SLTonKho = Convert.ToInt32(txtSL.Text),
                    HinhAnh = ConvertImageToByteArray(picHinhAnh.Image),
                };
                ChuyenAnhVaoThuMuc();
                if (maBUS.SuaMonAn(editma))
                {
                    MessageBox.Show(Const.Sua_Mon_Thanh_Cong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmQLMonAn_Load(sender, e);
                    reset_Text();
                }
                else
                {
                    MessageBox.Show(Const.Sua_Mon_That_Bai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSMonAn.SelectedRows.Count == Const.dgvDSTK_SelectedRows_Count)
            {
                MessageBox.Show(Const.ChonMonAnCanXoa, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult delete = MessageBox.Show(Const.XacNhanXoaMonAn, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    int mama = Convert.ToInt32(txtMaMonAn.Text);
                    MonAnDTO xoama = new MonAnDTO()
                    {
                        MaMonAn = mama,
                    };
                    if (maBUS.XoaMonAn(xoama))
                    {
                        MessageBox.Show(Const.Xoa_Mon_Thanh_Cong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmQLMonAn_Load(sender, e);
                        reset_Text();
                    }
                    else
                    {
                        MessageBox.Show(Const.Xoa_Mon_That_Bai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }

        }
        public void reset_Text()
        {
            txtTenMonAn.Text = string.Empty;
            txtMaMonAn.Text = string.Empty;
            txtSL.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            cbbLoaiMonAn.Text = string.Empty;
            picHinhAnh.Image = null;
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                FrmQLMonAn_Load(sender, e);
            }
            else
            {
                // Thực hiện tìm kiếm và hiển thị kết quả             
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex0)
                {
                    string tenman = txtTimKiem.Text;
                    List<MonAnDTO> ma = maBUS.DSMonAn_TenMonAn(tenman);
                    dgvDSMonAn.DataSource = ma;
                }

                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex1)
                {
                    int mama;
                    try
                    {
                        mama = int.Parse(txtTimKiem.Text);
                        MonAn ma = new MonAn()
                        {
                            MaMonAn = mama,
                        };
                        dgvDSMonAn.DataSource = maBUS.DSMonAn_MaMonAn(ma);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Const.ChiNhapSo, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKiem.Text = string.Empty;
                    }
                }



            }
        }

        private void radThit_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = theoMonBUS.DSMonAn_Thit();
        }

        private void radHaiSan_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = theoMonBUS.DSMonAn_HaiSan();
        }

        private void radRauCu_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = theoMonBUS.DSMonAn_RauCu();

        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            FrmQLMonAn_Load(sender, e);
        }

        private void radNuoc_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = theoMonBUS.DS_Nuoc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = string.Empty;
            txtSL.Text = string.Empty;
            txtMaMonAn.Text = string.Empty;
            txtTenMonAn.Text = string.Empty;
        }
    }
}
