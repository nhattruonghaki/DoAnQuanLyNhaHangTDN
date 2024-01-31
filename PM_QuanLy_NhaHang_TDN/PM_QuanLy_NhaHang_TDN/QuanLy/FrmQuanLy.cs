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
    public partial class FrmQuanLy : Form
    {
        FrmTrangChu FrmTrangChu;
        public FrmQuanLy(FrmTrangChu frmTrangChu)
        {
            InitializeComponent();
            FrmTrangChu = frmTrangChu;
            
        }

        private void TSM_QLNhanVien_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien nv = new FrmQLNhanVien(this);
            nv.MdiParent = this;
            nv.Show();
        }

        private void TSM_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQLTaiKhoan tk = new FrmQLTaiKhoan(this);
            tk.MdiParent = this;
            tk.Show();
        }

        private void TSM_QLMonAn_Click(object sender, EventArgs e)
        {
            FrmQLMonAn ma = new FrmQLMonAn(this);
            ma.MdiParent = this;
            ma.Show();
        }

        private void TSM_QLBan_Click(object sender, EventArgs e)
        {
            FrmQLBan b = new FrmQLBan(this); 
            b.MdiParent = this;
            b.Show();
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            FrmQLNhanVien nv = new FrmQLNhanVien(this);
            nv.MdiParent = this;
            nv.Show();

        }

        private void TSM_VeTrangChu_Click(object sender, EventArgs e)
        {           
            this.Hide();
            FrmTrangChu.Show();
            FrmTrangChu.icbtnTrangChu_Click(sender, e);
        }
    }
}
