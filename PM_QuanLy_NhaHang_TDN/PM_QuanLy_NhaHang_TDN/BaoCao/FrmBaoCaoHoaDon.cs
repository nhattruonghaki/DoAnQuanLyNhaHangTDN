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

namespace PM_QuanLy_NhaHang_TDN
{
    public partial class FrmBaoCaoHoaDon : Form
    {
        ThongKeHoaDonBUS _ThongKeHoaDonBUS = new ThongKeHoaDonBUS();
        public FrmBaoCaoHoaDon()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoHoaDon_Load(object sender, EventArgs e)
        {
            List<ThongKeHoaDonDTO> lst = _ThongKeHoaDonBUS.DSHoaDon();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Const.rptHoaDon;
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(Const.rptDatasourceHoaDon, lst));
            this.reportViewer1.RefreshReport();
        }
    }
}
