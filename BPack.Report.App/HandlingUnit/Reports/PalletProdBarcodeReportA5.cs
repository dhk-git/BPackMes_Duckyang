using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class PalletProdBarcodeReportA5 : DevExpress.XtraReports.UI.XtraReport
    {
        public PalletProdBarcodeReportA5()
        {
            InitializeComponent();
        }
        public void DataRefresh(object dataSource)
        {
            xrLabel3.Text = "출력일시 : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            objectDataSource1.DataSource = dataSource;
        }
    }
}
