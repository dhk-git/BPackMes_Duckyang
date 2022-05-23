using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class Dy_LpackReport : DevExpress.XtraReports.UI.XtraReport
    {
        
        public Dy_LpackReport()
        {
            InitializeComponent();

        }
        public void DataRefresh(object data)
        {
            objectDataSource1.DataSource = data;
        }

    }
}
