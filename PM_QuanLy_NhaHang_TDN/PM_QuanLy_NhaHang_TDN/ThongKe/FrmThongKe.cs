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
    public partial class FrmThongKe : Form
    {
        FrmTrangChu FrmTrangChu;
        public string tennv;
        //public int tienThua;
        public FrmThongKe(FrmTrangChu frmTrangChu)
        {
            InitializeComponent();
            FrmTrangChu = frmTrangChu;
            FrmThongKeDoanhThu frm = new FrmThongKeDoanhThu(this);
            frm.MdiParent = this;
            frm.Show();
            tennv = frmTrangChu.nv;

            //tienThua = frmTrangChu.TienThua;
        }

        private void biểuĐồDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBieuDo bd = new FrmBieuDo(this);
            bd.MdiParent = this;
            bd.Show();
        }

        private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKeHoaDon frm = new FrmThongKeHoaDon(this);
            frm.MdiParent = this;
            frm.Show();

        }

        private void thốngKêTheoMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKeTheoMon frm = new FrmThongKeTheoMon(this);
            frm.MdiParent = this;
            frm.Show();
            

        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKeDoanhThu frm = new FrmThongKeDoanhThu(this);
            frm.MdiParent = this;
            frm.Show();

        }

        private void vềTrangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrangChu.Show();
            FrmTrangChu.icbtnTrangChu_Click(sender, e);
        }
    }
}
