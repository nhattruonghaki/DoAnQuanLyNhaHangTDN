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
    public partial class frmBangBanHang : Form
    {
        public frmBangBanHang()
        {
            InitializeComponent();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon laphd = new frmLapHoaDon();
            laphd.ShowDialog();
        }

        private void frmBangBanHang_Load(object sender, EventArgs e)
        {
            
        }
    }
}
