using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmQuenMatKhau : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }


        private void icbtnHien_Click(object sender, EventArgs e)
        {
            if (txtXNMKnew.PasswordChar == Const.HienPass)
            {
                icbtnAn.BringToFront();
                txtXNMKnew.PasswordChar = Convert.ToChar(Const.AnPass);
            }
        }

        private void icbtnAn_Click(object sender, EventArgs e)
        {
            if (txtXNMKnew.PasswordChar == Const.AnPass)
            {
                icbtnHien.BringToFront();
                txtXNMKnew.PasswordChar = Convert.ToChar(Const.HienPass);
            }
        }

        private void icbtnHienMK_Click(object sender, EventArgs e)
        {
            if (txtMKnew.PasswordChar == Const.HienPass)
            {
                icbtnAnMK.BringToFront();
                txtMKnew.PasswordChar = Convert.ToChar(Const.AnPass);
            }
        }

        private void icbtnAnMK_Click(object sender, EventArgs e)
        {
            if (txtMKnew.PasswordChar == Const.AnPass)
            {
                icbtnHienMK.BringToFront();
                txtMKnew.PasswordChar = Convert.ToChar(Const.HienPass);
            }
        }

        private void icbtnXacNhan_Click(object sender, EventArgs e)
        {
            string email = txtEmailDK.Text;
            string Pass = Utils.GetMD5(txtMKnew.Text);
            string PassXN = Utils.GetMD5(txtXNMKnew.Text);

            if (Pass != PassXN)
            {
                MessageBox.Show(Const.MatKhau_XN, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nvBUS.CheckEmail(email) && tkBUS.QuenPassword(email, Pass))
            {
                MessageBox.Show(Const.DoiMK_new_ThanhCong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(Const.DoiMK_new_ThatBai, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
