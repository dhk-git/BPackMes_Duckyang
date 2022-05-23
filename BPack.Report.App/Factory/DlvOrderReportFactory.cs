using BPack.Report.App.Common;
using BPack.Report.App.DlvOrder.Models;
using BPack.Report.App.DlvOrder.Pocket;
using BPack.Report.App.DlvOrder.Reports;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.Factory
{
    public class DlvOrderReportFactory : IShowReport
    {
        private XtraReport _currentReport;
        private DlvOrderPocket _dlvOrderPocket;
        public static DlvOrderReportFactory _dlvOrderReportFactory;

        public static DlvOrderReportFactory GetInstance()
        {
            _dlvOrderReportFactory = _dlvOrderReportFactory ?? new DlvOrderReportFactory();
            return _dlvOrderReportFactory;
        }

        public IShowReport ShowReport_DlvOrder(List<string> dohNoList)
        {
            _dlvOrderPocket = new DlvOrderPocket();
            DlvOrderModelArgs dlvOrderModelArgs = new DlvOrderModelArgs();
            dlvOrderModelArgs.Doh_No_List = dohNoList;
            var data = _dlvOrderPocket.SelectDlvOrderModels(dlvOrderModelArgs);
            DlvOrderReport report = new DlvOrderReport();
            report.DataRefresh(data);
            report.CreateDocument();
            _currentReport = report;
            return this;
        }


        public XtraReport GetReport()
        {
            return _currentReport;
        }

        public void Print()
        {
            if (_currentReport == null)
            {
                throw new Exception("레포트가 생성되지 않았습니다.");
            }
            PrintTool pt = new PrintTool(this._currentReport.PrintingSystem);
            pt.Print();
        }

        public void Print(string printerName)
        {
            if (_currentReport == null)
            {
                throw new Exception("레포트가 생성되지 않았습니다.");
            }
            PrintTool pt = new PrintTool(this._currentReport.PrintingSystem);
            pt.PrinterSettings.PrinterName = printerName;
            pt.Print();
        }

        public void ShowPreview()
        {
            if (_currentReport == null)
            {
                throw new Exception("레포트가 생성되지 않았습니다.");
            }
            PrintTool pt = new PrintTool(this._currentReport.PrintingSystem);
            pt.ShowPreview();
        }

        public void ShowPreviewDialog()
        {
            if (_currentReport == null)
            {
                throw new Exception("레포트가 생성되지 않았습니다.");
            }
            PrintTool pt = new PrintTool(this._currentReport.PrintingSystem);
            pt.PreviewForm.PrintControl.SetPageView(1, 1);
            pt.ShowPreviewDialog();
        }
    }
}
