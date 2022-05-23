using BPack.Report.App.HandlingUnit.Models;
using DevExpress.DataAccess.DataFederation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class SerialGoodsBarcodeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SerialGoodsBarcodeReport()
        {
            InitializeComponent();

            // DefaultPrinterSettingsUsing.UseLandscape = true; // + 도시바 프린터 속성 - 페이지속성 - 방향 - 가로180(S) 지정필요
        }

        public void DataRefresh(object dataSource)
        {
            var source = (dataSource as List<SerialGoodsBarcodeReportModel>);
            //foreach(SerialGoodsBarcodeReportModel model in source)
            //{
            //    var imagePath = Path.Combine(System.Environment.CurrentDirectory, "Images");
            //    model.SYMBOL = Path.Combine(imagePath, model.SYMBOL);
            //}
            objectDataSource1.DataSource = dataSource;

        }

    }
}
