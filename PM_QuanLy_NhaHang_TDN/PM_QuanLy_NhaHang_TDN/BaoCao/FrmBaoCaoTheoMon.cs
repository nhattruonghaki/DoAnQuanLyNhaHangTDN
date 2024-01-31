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
using Microsoft.Reporting.WinForms;

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmBaoCaoTheoMon : Form
    {
        ThongKeTheoMonBUS _ThongKeTheoMonBUS = new ThongKeTheoMonBUS();
        public FrmBaoCaoTheoMon()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoTheoMon_Load(object sender, EventArgs e)
        {
        }

        public void TatCaMonAn()
        {
            List<ThongKeTheoMonDTO> lst = _ThongKeTheoMonBUS.DSMonAn();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Const.rptTatCaMon;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Const.rptDatasource_TatCaMon, lst));
            this.reportViewer1.RefreshReport();
        }

        public void TheoLoai(LoaiMonAnDTO loai)
        {
            List<ThongKeTheoMonDTO> lst = _ThongKeTheoMonBUS.DSTheoLoai(loai.MALOAI);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Const.rptTheoLoai;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Const.rptDatasource_TheoLoai, lst));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(Const.rptpa_TheoLoai, loai.TENLOAI));
            this.reportViewer1.RefreshReport();
        }

        public void NhomTheoLoai()
        {
            LoaiMonAnBUS _loaiMonAnBUS = new LoaiMonAnBUS();
            List<LoaiMonAnDTO> lst = _loaiMonAnBUS.DSLoaiMonAn();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Const.rptNhomTheoLoai;
            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Const.rptDatasource_Nhom, lst));
            this.reportViewer1.RefreshReport();
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int maloai = int.Parse(e.Parameters[Const.paMaLoai].Values[Const.MaLoai]);
            e.DataSources.Add(new ReportDataSource(Const.dataSource_MaLoai, _ThongKeTheoMonBUS.DSTheoLoai(maloai)));
        }
    }
}
