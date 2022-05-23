using BPack.Report.App.HandlingUnit.Models;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class SerialSemiBarcodeReport35x55 : DevExpress.XtraReports.UI.XtraReport
    {
        public SerialSemiBarcodeReport35x55()
        {
            InitializeComponent();
        }

        public void DataRefresh(object dataSource)
        {
            foreach (var model in (List<SerialSemiBarcodeReportModel>)dataSource)
            {
                model.HU_BARCODE_WITHOUT_ITEM_CD = model.HU_BARCODE.Split('/')[0];  //바코드번호의 "/"뒤에 품번 제거함
                var aa = model.HU_BARCODE.Split('/')[0];
            }
            objectDataSource1.DataSource = dataSource;
        }

    }
}
