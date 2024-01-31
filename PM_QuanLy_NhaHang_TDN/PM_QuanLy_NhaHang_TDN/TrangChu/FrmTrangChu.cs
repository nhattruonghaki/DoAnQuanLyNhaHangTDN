using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
using PM_QuanLy_NhaHang_TDN.BanHang;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmTrangChu : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        private int quyen;
        public string nv;
        public int manv;
        //public int TienThua;
        public FrmTrangChu(string tennv, int Quyen, int manhanvien)
        {
            InitializeComponent();
            lblTenNV.Text += tennv;
            quyen = Quyen;
            nv = tennv;
            manv = manhanvien;

            //FrmBanHang bh = new FrmBanHang(this);
            //bh.tienthua = TienThua;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            time_NVonline.Text = DateTime.Now.ToString(Const.timeOnline);
        }
        public void icbtnTrangChu_Click(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
        }

        private void icbtnBanHang_Click(object sender, EventArgs e)
        {
            trangChu1.SendToBack();
            FrmBanHang bh = new FrmBanHang(this);
            bh.MdiParent = this;
            bh.Show();

        }
        private void icbtnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe thongKe = new FrmThongKe(this);
            thongKe.Show();
            this.Hide();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            if (quyen != Const.Quyen1)
            {
                MessageBox.Show(Const.NV + nv + Const.DangNhap_TC, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                icbtnQuanLy.Hide();
                icbtnThongKe.Hide();
            }
            else
            {
                MessageBox.Show(Const.Admin + nv + Const.DangNhap_TC, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void icbtnQuanLy_Click(object sender, EventArgs e)
        {
            FrmQuanLy bh = new FrmQuanLy(this);
            bh.Show();
            this.Hide();
        }

        private void icbtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
            FrmDoiMatKhau dmk = new FrmDoiMatKhau();   
            dmk.ShowDialog();
            
        }

        private void icbtnDangXuat_Click(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
            DialogResult thoat = MessageBox.Show(Const.DangXuat, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
                FrmDangNhap hien = new FrmDangNhap();
                hien.Show();
            }
            
            
        }
    }
}
