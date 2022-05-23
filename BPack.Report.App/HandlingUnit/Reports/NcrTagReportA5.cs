using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class NcrTagReportA5 : DevExpress.XtraReports.UI.XtraReport
    {
        public NcrTagReportA5()
        {
            InitializeComponent();
        }

        public void DataRefresh(object source, string reportType)
        {
            switch (reportType)
            {
                case "A":
                    xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::BPack.Report.App.Properties.Resources.부적합의심, true);
                    xrLabel4.Text = "등록자";
                    break;
                case "B":
                    xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::BPack.Report.App.Properties.Resources.부적합, true);
                    xrLabel4.Text = "판정자";
                    break;
                case "C":
                    xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::BPack.Report.App.Properties.Resources.특채, true);
                    xrLabel4.Text = "판정자";
                    break;
            }

            objectDataSource1.DataSource = source;
        }

    }
}
