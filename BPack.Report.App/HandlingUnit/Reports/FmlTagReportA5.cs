using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class FmlTagReportA5 : DevExpress.XtraReports.UI.XtraReport
    {
        public FmlTagReportA5()
        {
            InitializeComponent();
        }

        public void DataRefresh(object source)
        {
            objectDataSource1.DataSource = source;
        }
        
    }
}
