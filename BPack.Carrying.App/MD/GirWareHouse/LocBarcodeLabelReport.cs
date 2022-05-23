using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Carrying.App.MD.GirWareHouse
{
    public partial class LocBarcodeLabelReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LocBarcodeLabelReport()
        {
            InitializeComponent();
        }

        public void DataRefresh(object dataSource)
        {
            objectDataSource1.DataSource = dataSource;
        }

    }
}
