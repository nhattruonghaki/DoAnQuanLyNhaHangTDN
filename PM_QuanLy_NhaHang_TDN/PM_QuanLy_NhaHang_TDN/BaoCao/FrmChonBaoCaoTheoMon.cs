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
using DTO;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmChonBaoCaoTheoMon : Form
    {
        LoaiMonAnBUS _LoaiMonAnBUS = new LoaiMonAnBUS();
        public FrmChonBaoCaoTheoMon()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                FrmBaoCaoTheoMon frm = new FrmBaoCaoTheoMon();
                frm.TatCaMonAn();
                frm.ShowDialog();
            }
            if (radTheoLoai.Checked)
            {
                FrmBaoCaoTheoMon frm = new FrmBaoCaoTheoMon();
                frm.TheoLoai((LoaiMonAnDTO)cbbTheoLoai.SelectedItem);
                frm.ShowDialog();
            }

            if (radNhomTheoLoai.Checked)
            {
                FrmBaoCaoTheoMon frm = new FrmBaoCaoTheoMon();
                frm.NhomTheoLoai();
                frm.ShowDialog();
            }
        }

        private void FrmChonBaoCaoTheoMon_Load(object sender, EventArgs e)
        {
            cbbTheoLoai.DisplayMember = Const.cbbTheoLoai_DisplayMember;
            cbbTheoLoai.ValueMember = Const.cbbTheoLoai_ValueMember;
            cbbTheoLoai.DataSource = _LoaiMonAnBUS.DSLoaiMonAn();
        }
    }
}
