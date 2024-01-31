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
    public partial class FrmQLBan : Form
    {
        FrmQuanLy FrmQuanLy;
        BanAnBUS _BanAnBUS = new BanAnBUS();
        public FrmQLBan(FrmQuanLy frmQuanLy)
        {
            InitializeComponent();
            FrmQuanLy = frmQuanLy;
            dgvDSBan.AutoGenerateColumns = false;
            cbbTimKiem.SelectedIndex = Const.cbbTimKiem_SelectedIndex0;
        }

        private void FrmQLBan_Load(object sender, EventArgs e)
        {
            dgvDSBan.DataSource = _BanAnBUS.LayDSBanAn();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                FrmQLBan_Load(sender, e);
            }
            else
            {
                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex0)
                {
                    int maBan;
                    try
                    {
                        maBan = int.Parse(txtTimKiem.Text);
                        BanAn ba = new BanAn()
                        {
                            MaBan = maBan,
                        };

                        dgvDSBan.DataSource = _BanAnBUS.DSBanAn_MB(ba);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Const.ChiNhapSo, Const.Bao_Loi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKiem.Text = string.Empty;
                    }
                }


                if (cbbTimKiem.SelectedIndex == Const.cbbTimKiem_SelectedIndex1)
                {
                    string tenBan = txtTimKiem.Text;
                    List<BanAnDTO> banAn = _BanAnBUS.DSBanAn_TB(tenBan);
                    dgvDSBan.DataSource = banAn;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBan.Text.Trim()))
            {
                MessageBox.Show(Const.moi_Nhap_Ban, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BanAnDTO newBA = new BanAnDTO()
                {
                    TENBAN = txtTenBan.Text,
                    TRANGTHAI = radBanCu.Checked ? Const.ban_Ban : Const.ban_Ranh,
                    BANTRONG = false,
                };

                if (_BanAnBUS.ThemBA(newBA))
                {
                    MessageBox.Show(Const.them_Ban_Thanh_Cong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Const.them_Ban_That_Bai, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                FrmQLBan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSBan.SelectedRows.Count == Const.dgvDSBan_SelectedRows_Count)
            {
                MessageBox.Show(Const.chon_Ban_Muon_Xoa, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult xoa = MessageBox.Show(Const.xac_Nhan_Xoa_Ban, Const.Thong_Bao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xoa == DialogResult.Yes)
                {
                    BanAnDTO newBA = new BanAnDTO()
                    {
                        MABAN = Convert.ToInt32(txtMaBan.Text),
                        TENBAN = txtTenBan.Text,
                        TRANGTHAI = radBanCu.Checked ? Const.ban_Ban : Const.ban_Ranh,
                        BANTRONG = true,
                        XOA = false
                    };
                    if (_BanAnBUS.XoaBA(newBA))
                    {
                        MessageBox.Show(Const.xoa_Ban_Thanh_Cong,Const.Thong_Bao,MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Const.xoa_Ban_That_Bai, Const.Bao_Loi,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    FrmQLBan_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSBan.SelectedRows.Count == Const.dgvDSBan_SelectedRows_Count)
            {
                MessageBox.Show(Const.chon_Ban_Muon_Sua, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BanAnDTO newBA = new BanAnDTO()
                {
                    MABAN = Convert.ToInt32(txtMaBan.Text),
                    TENBAN = txtTenBan.Text,
                    TRANGTHAI = radBanCu.Checked ? Const.ban_Ban : Const.ban_Ranh,
                    BANTRONG = radBanCu.Checked ? true : false,
                    XOA = false
                };

                if (_BanAnBUS.SuaBA(newBA))
                {
                    MessageBox.Show(Const.sua_Ban_Thanh_Cong, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Const.sua_Ban_That_Bai, Const.Thong_Bao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                FrmQLBan_Load(sender, e);
            }
        }

        private void dgvDSBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;

            if (i == Const.i) return;

            txtMaBan.Text = dgvDSBan.Rows[i].Cells[Const.dgvMaBan].Value.ToString();
            txtTenBan.Text = dgvDSBan.Rows[i].Cells[Const.dgvTenBan].Value.ToString();
            radBanCu.Checked = dgvDSBan.Rows[i].Cells[Const.dgvTrangThaiBan].Value.ToString() == Const.ban_Ban;
            radBanMoi.Checked = dgvDSBan.Rows[i].Cells[Const.dgvTrangThaiBan].Value.ToString() == Const.ban_Ranh;
        }

        private void dgvDSBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            dgvDSBan_CellContentClick(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = String.Empty;
            txtMaBan.Text = String.Empty;
            txtTenBan.Text = String.Empty;
            cbbTimKiem.Text = String.Empty;
            radTatCa.Checked = true;
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            FrmQLBan_Load(sender, e);
        }

        private void radBanTrong_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSBan.DataSource = _BanAnBUS.DS_BanRanh();
        }

        private void radPhucVu_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSBan.DataSource = _BanAnBUS.DS_BanBan();
        }
    }
}
