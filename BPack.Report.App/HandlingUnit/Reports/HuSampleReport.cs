using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class HuSampleReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HuSampleReport()
        {
            InitializeComponent();
        }

        public void DataRefresh(object data)
        {
            objectDataSource1.DataSource = data;
        }
    }
}
