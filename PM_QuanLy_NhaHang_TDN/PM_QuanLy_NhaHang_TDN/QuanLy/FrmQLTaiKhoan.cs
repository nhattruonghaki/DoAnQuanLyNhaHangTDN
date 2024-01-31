
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmQLTaiKhoan : Form
    {
        FrmQuanLy FrmQuanLy;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public FrmQLTaiKhoan(FrmQuanLy frmQuanLy)
        {
            InitializeComponent();
            FrmQuanLy = frmQuanLy;
            dgvDSTK.AutoGenerateColumns = false;
            dgvDSTK.AllowUserToAddRows = false;
            cbbTimKiem.SelectedIndex = Const.cbbTimKiem;
            dgvDSTK.CellClick += new DataGridViewCellEventHandler(dgvDSTK_CellContentClick);
        }

        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvDSTK.DataSource = tkBUS.LayDSTaiKhoan();

            cbbLoaiTK.DataSource = tkBUS.LayDSLoaiTaiKhoan();
            cbbLoaiTK.DisplayMember = Const.cbbLoaiTK_Display;
            cbbLoaiTK.ValueMember = Const.cbbLoaiTK_Value;
            cbbNV_oTK.DataSource = tkBUS.LayNhanVienChuaCoTaiKhoan();
            cbbNV_oTK.DisplayMember = Const.cbbNV_oTK_Display;
            cbbNV_oTK.ValueMember = Const.cbbNV_oTK_Value;
        }

        private void dgvDSTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSTK.SelectedCells.Count > Const.dgvDSTK_SeCells_Count)
            {
                DataGridViewCell cell = dgvDSTK.SelectedCells[Const.dgvDSTK_SelectedCells];
                DataGridViewRow row = cell.OwningRow;
                txtMaTK.Text = row.Cells[Const.dgvMaTK].Value.ToString();
                txtTenNV.Text = row.Cells[Const.dgvTenNV].Value.ToString();
                txtTenTK.Text = row.Cells[Const.dgvTenTK].Value.ToString();
                cbbLoaiTK.Text = row.Cells[Const.dgvLoaiTK].Value.ToString();
                txtMatKhau.Text = row.Cells[Const.dgvMatKhau].Value.ToString();
            }
        }

        
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text.Trim()) || string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show(Const.ThongBao_Chua_du_Thong_Tin, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(cbbNV_oTK.SelectedValue == null)
            {
                MessageBox.Show(Const.themTK_KhongCoNV, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            int maNV = (int)cbbNV_oTK.SelectedValue;
            string user = txtTenTK.Text;
            TaiKhoanDTO newtk = new TaiKhoanDTO()
            {
                MaNV = maNV,
                Username = user,
                Pass = Utils.GetMD5(txtMatKhau.Text),
                MaLoai = Convert.ToInt32(cbbLoaiTK.SelectedValue),
                TrangThai = true
            };
            
            // Thêm tài khoản mới vào CSDL
            if (tkBUS.CheckUsername(user) && tkBUS.ThemTK(newtk))
            {
                MessageBox.Show(Const.themTK_ThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmQLTaiKhoan_Load(sender,e);
                reset_Text();
            }
            else
            {
                MessageBox.Show(Const.themTK_ThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if(dgvDSTK.SelectedRows.Count == Const.dgvDSTK_SelectedRows_Count)
            {
                MessageBox.Show(Const.ChonTK_Can_Sua, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int maTk = Convert.ToInt32(txtMaTK.Text);
                TaiKhoanDTO edittk = new TaiKhoanDTO()
                {
                    MaLoaiTK = maTk,
                    Username = txtTenTK.Text,
                    MaLoai = Convert.ToInt32(cbbLoaiTK.SelectedValue),
                };

                if (tkBUS.SuaTK(edittk))
                {
                    MessageBox.Show(Const.suaTK_ThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmQLTaiKhoan_Load(sender, e);
                    reset_Text();
                }
                else
                {
                    MessageBox.Show(Const.suaTK_ThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            
            if (dgvDSTK.SelectedRows.Count == Const.dgvDSTK_SelectedRows_Count)
            {
                MessageBox.Show(Const.ChonTK_Can_Xoa, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult delete = MessageBox.Show(Const.XacNhan_Xoa, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    int maTk = Convert.ToInt32(txtMaTK.Text);
                    if (maTk == Const.MaTK_Khong_The_Xoa)
                    {
                        MessageBox.Show(Const.TK_Khong_The_Xoa, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    TaiKhoanDTO deltk = new TaiKhoanDTO()
                    {
                        MaLoaiTK = maTk,
                    };                   
                    if (tkBUS.XoaTK(deltk))
                    {
                        MessageBox.Show(Const.XoaTK_ThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmQLTaiKhoan_Load(sender, e);
                        reset_Text();
                    }
                    else
                    {
                        MessageBox.Show(Const.XoaTK_ThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
            }
        }

        public void reset_Text()
        {
            txtMaTK.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtTenTK.Text = string.Empty;
            txtMatKhau.Text = string.Empty;           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_Text();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                FrmQLTaiKhoan_Load(sender, e);
            }
            else
            {
                // Thực hiện tìm kiếm và hiển thị kết quả             
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex0)
                {
                    string HoTenNV = txtTimKiem.Text;
                    List<TaiKhoanDTO> nvs = tkBUS.DSNhanVien_TenNV(HoTenNV);
                    dgvDSTK.DataSource = nvs;
                }

                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex1)
                {
                    try
                    {
                    int maLoaiTK = int.Parse(txtTimKiem.Text);
                    TaiKhoanDTO nv = new TaiKhoanDTO()
                    {
                       MaLoaiTK = maLoaiTK
                    };
                    dgvDSTK.DataSource = tkBUS.DSNhanVien_MaLoaiTK(nv);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Const.ChiNhapSo, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKiem.Text = string.Empty;
                    }
                }
            }
        }
    }
}
