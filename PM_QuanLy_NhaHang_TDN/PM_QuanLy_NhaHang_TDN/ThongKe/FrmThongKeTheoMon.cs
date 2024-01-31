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
using DAO;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmThongKeTheoMon : Form
    {
        FrmThongKe FrmThongKe;
        ThongKeTheoMonBUS _ThongKeTheoMonBUS = new ThongKeTheoMonBUS();
        public FrmThongKeTheoMon(FrmThongKe frmThongKe)
        {
            InitializeComponent();
            FrmThongKe = frmThongKe;
            dgvDSMonAn.AutoGenerateColumns = false;
            cbbTimKiem.SelectedIndex = Const.cbbTimKiem_SelectedIndex0;
        }

        private void FrmThongKeTheoMon_Load(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = _ThongKeTheoMonBUS.DSMonAn();
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            FrmThongKeTheoMon_Load(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                FrmThongKeTheoMon_Load(sender, e);
            }
            else
            {
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex0)
                {
                    try
                    {
                    int maMonAn = int.Parse(txtTimKiem.Text);
                    MonAn ma = new MonAn()
                    {
                        MaMonAn = maMonAn,
                    };

                    dgvDSMonAn.DataSource = _ThongKeTheoMonBUS.DSMonAn_MaMonAn(ma);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Const.ChiNhapSo, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKiem.Text = string.Empty;
                    }
                }
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex1)
                {
                    string tenMonAn = txtTimKiem.Text;
                    List<ThongKeTheoMonDTO> ten = _ThongKeTheoMonBUS.DSMonAn_TenMonAn(tenMonAn);
                    dgvDSMonAn.DataSource = ten;
                }
            }
        }

        private void radThit_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = _ThongKeTheoMonBUS.DSMonAn_Thit();
        }

        private void radHaiSan_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = _ThongKeTheoMonBUS.DSMonAn_HaiSan();
        }

        private void radRauCu_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = _ThongKeTheoMonBUS.DSMonAn_RauCu();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmChonBaoCaoTheoMon frm = new FrmChonBaoCaoTheoMon();
            frm.ShowDialog();
        }

        private void radNuoc_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = _ThongKeTheoMonBUS.DS_Nuoc();
        }
    }
}
