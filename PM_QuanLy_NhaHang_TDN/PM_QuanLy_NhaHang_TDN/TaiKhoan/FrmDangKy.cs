using BUS;
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
    public partial class FrmDangKy : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public FrmDangKy()
        {
            InitializeComponent();
        }
        // Con mắt hiển thị và ẩn mật khẩu
        private void icbtnAnMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauDK.PasswordChar == Const.AnPass)
            {
                icbtnHienMK.BringToFront();
                txtMatKhauDK.PasswordChar = Convert.ToChar(Const.HienPass);
            }
        }

        private void icbtnHienMK_Click(object sender, EventArgs e)
        {   
            if (txtMatKhauDK.PasswordChar == Const.HienPass)
            {
                icbtnAnMK.BringToFront();
                txtMatKhauDK.PasswordChar = Convert.ToChar(Const.AnPass);
            }
            
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            cbbLoaiTK.DataSource = tkBUS.LayDSLoaiTaiKhoan();
            cbbLoaiTK.DisplayMember = Const.cbbLoaiTK_Display;
            cbbLoaiTK.ValueMember = Const.cbbLoaiTK_Value;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            NhanVienBUS nhanVienDTO = new NhanVienBUS();
            int maNV = nhanVienDTO.LayMaNhanVienMoiNhat();
            TaiKhoanDTO newtk = new TaiKhoanDTO()
            {
                MaNV = maNV,
                Username = txtTaiKhoanDK.Text,
                Pass = Utils.GetMD5(txtMatKhauDK.Text),
                MaLoai = Convert.ToInt32(cbbLoaiTK.SelectedValue),
                TrangThai = true
            };


            // Thêm tài khoản mới vào CSDL
            if (tkBUS.CheckUsername(newtk.Username) && tkBUS.ThemTK(newtk))
                {
                    MessageBox.Show(Const.DK_TK_ThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Const.DK_TK_ThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

    }
}
