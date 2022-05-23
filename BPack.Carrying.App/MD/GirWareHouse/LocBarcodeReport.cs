using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BPack.Pocket.App.MD.GirWareHouse;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.GirWareHouse
{
    public partial class LocBarcodeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LocBarcodeReport()
        {
            InitializeComponent();
        }

                
        public void DataRefresh(object dataSource)
        {
            objectDataSource1.DataSource = dataSource;
        }
    }
}
