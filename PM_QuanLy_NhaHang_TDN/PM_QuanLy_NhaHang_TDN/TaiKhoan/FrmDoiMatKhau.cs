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

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmDoiMatKhau : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void icbtnHienMKold_Click(object sender, EventArgs e)
        {
            if (txtMKold.PasswordChar == Const.HienPass)
            {
                icbtnAnMKold.BringToFront();
                txtMKold.PasswordChar = Convert.ToChar(Const.AnPass);
            }
        }

        private void icbtnAnMKold_Click(object sender, EventArgs e)
        {
            if (txtMKold.PasswordChar == Const.AnPass)
            {
                icbtnHienMKold.BringToFront();
                txtMKold.PasswordChar = Convert.ToChar(Const.HienPass);
            }
        }

        private void icbtnHienMKM_Click(object sender, EventArgs e)
        {
            if (txtMKnew.PasswordChar == Const.HienPass)
            {
                icbtnAnMKM.BringToFront();
                txtMKnew.PasswordChar = Convert.ToChar(Const.AnPass);
            }
        }

        private void icbtnAnMKM_Click(object sender, EventArgs e)
        {
            if (txtMKnew.PasswordChar == Const.AnPass)
            {
                icbtnHienMKM.BringToFront();
                txtMKnew.PasswordChar = Convert.ToChar(Const.HienPass);
            }
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

        private void icbtnXacNhan_Click(object sender, EventArgs e)
        {
            string Username = txtEmailDK.Text;
            string Passold = Utils.GetMD5(txtMKold.Text);
            string Pass = Utils.GetMD5(txtMKnew.Text);
            string PassXN = Utils.GetMD5(txtXNMKnew.Text);

            if (Pass != PassXN)
            {
                MessageBox.Show(Const.MatKhau_XN, Const.Bao_Loi,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (tkBUS.CheckUsername(Username) && tkBUS.UpdatePassword(Username, Passold, Pass))
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
