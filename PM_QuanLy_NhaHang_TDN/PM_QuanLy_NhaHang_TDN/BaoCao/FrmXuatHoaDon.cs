using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;

namespace PM_QuanLy_NhaHang_TDN.BaoCao
{
    public partial class FrmXuatHoaDon : Form
    {
        BanHangBUS _BanHangBUS = new BanHangBUS();
        private int Mahd;
        private string TenNV;
        private int MaBan;
        private string TienThua;
        public FrmXuatHoaDon(int mahd, string tenNV, int maBan, string tienthua)
        {
            InitializeComponent();
            Mahd = mahd;
            TenNV = tenNV;
            MaBan = maBan;
            TienThua = tienthua;
        }

        private void FrmXuatHoaDon_Load(object sender, EventArgs e)
        {
            List<BanHangDTO> lst = _BanHangBUS.LayDSXuatHD(Mahd);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Const.rptXuatHD;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Const.rptData_XuatHD, lst));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paNgayLap_XuatHD, DateTime.Now.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paMaHD_XuatHD, Mahd.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paTenNV_XuatHD, TenNV));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paMaBan_XuatHD, MaBan.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paTienThua_XuatHD, TienThua));

            this.reportViewer1.RefreshReport();
        }
    }
}
