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
using DTO;
using Microsoft.Reporting.WinForms;

namespace PM_QuanLy_NhaHang_TDN.BaoCao
{
    public partial class FrmChiTietHoaDon : Form
    {
        ThongKeDoanhThuBUS _ThongKeDoanhThuBUS = new ThongKeDoanhThuBUS();
        //NhanVienBUS _NhanVienBUS = new NhanVienBUS();
        private int Mahd;
        private string TenNV;
        private DateTime NgayLapHD;
        private int MaBan;
        private int TienThua;
        public FrmChiTietHoaDon(int mahd, string tennv, DateTime ngayLapHD, int maBan, int tienthua)
        {
            InitializeComponent();
            Mahd = mahd;
            TenNV = tennv;
            NgayLapHD = ngayLapHD;
            MaBan = maBan;
            TienThua = tienthua;
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            List<ThongKeDoanhThuDTO> lst = _ThongKeDoanhThuBUS.DSChiTietHD(Mahd);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Const.rptCTHD;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Const.rptDatasource_CTHD, lst));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paMaHD_CTHD, Mahd.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paTenNV_CTHD, TenNV.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paNgayLapHD_CTHD, NgayLapHD.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paMaBan_CTHD, MaBan.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.paTienThua_CTHD, TienThua.ToString()));

            this.reportViewer1.RefreshReport();

        }
    }
}
