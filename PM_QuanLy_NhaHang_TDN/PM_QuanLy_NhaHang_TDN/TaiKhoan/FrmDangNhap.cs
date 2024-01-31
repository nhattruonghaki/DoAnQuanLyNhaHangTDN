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
using BUS;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PM_QuanLy_NhaHang_TDN.BanHang;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmDangNhap : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void lkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau qmk = new FrmQuenMatKhau();
            qmk.ShowDialog();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoanDN.Text.Trim()) || string.IsNullOrEmpty(txtMatKhauDN.Text.Trim()))
            {
                MessageBox.Show(Const.Chua_Nhap_Ten_va_Pass, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Username = txtTaiKhoanDN.Text;

            List<TaiKhoanDTO> taiKhoanDTO = tkBUS.LayTenNvTaiKhoan(Username);

                //string Pass = txtMatKhauDN.Text;
                string Pass = Utils.GetMD5(txtMatKhauDN.Text);
                if (tkBUS.CheckUsername(Username) && tkBUS.CheckLoginPhanQuyen(Username, Pass))
                {
                    string Tennv = taiKhoanDTO[Const.Tennv_taiKhoanDTO].TenNV;
                int manhanvien = taiKhoanDTO[0].MaNV;
                int Quyen = taiKhoanDTO[Const.QuyenMaLoai_taiKhoanDTO].MaLoai;
                    FrmTrangChu frmTrangChu = new FrmTrangChu(Tennv, Quyen, manhanvien);   
                    frmTrangChu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(Const.DN_ThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }         

        }
        // Con mắt hiển thị và ẩn mật khẩu
        private void icbtnAnMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauDN.PasswordChar == Const.AnPass)
            {
                icbtnHienMK.BringToFront();
                txtMatKhauDN.PasswordChar = Convert.ToChar(Const.HienPass);
            }
        }
        private void icbtnHienMK_Click(object sender, EventArgs e)
        {    
            if (txtMatKhauDN.PasswordChar == Const.HienPass)
            {
                icbtnAnMK.BringToFront();
                txtMatKhauDN.PasswordChar = Convert.ToChar(Const.AnPass);
            }
        }
        // thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show(Const.Thoat, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(thoat == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
    }
}



