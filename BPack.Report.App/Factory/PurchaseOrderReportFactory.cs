using BPack.Report.App.Common;
using BPack.Report.App.PurchseOrder.Models;
using BPack.Report.App.PurchseOrder.Pocket;
using BPack.Report.App.PurchseOrder.Reports;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.Factory
{
    public class PurchaseOrderReportFactory : IShowReport
    {
        private XtraReport _currentReport;
        private static PurchaseOrderReportFactory _purchaseOrderReportFactory;
        private PurchaseOrderPocket _purchaseOrderPocket;

        public PurchaseOrderReportFactory()
        {

        }

        public static PurchaseOrderReportFactory GetInstance()
        {
            _purchaseOrderReportFactory = _purchaseOrderReportFactory ?? new PurchaseOrderReportFactory();
            return _purchaseOrderReportFactory;
        }


        public IShowReport ShowReport_PurchaseOrder(List<string> pohNoList)
        {
            _purchaseOrderPocket = new PurchaseOrderPocket();
            PurchaseOrderModelArgs purchaseOrderModelArgs = new PurchaseOrderModelArgs();
            purchaseOrderModelArgs.Poh_No_List = pohNoList;
            XtraReport xtraReport = new XtraReport();
            foreach (var pohNo in pohNoList)
            {
                purchaseOrderModelArgs.Poh_No_List = new List<string>();
                purchaseOrderModelArgs.Poh_No_List.Add(pohNo);
                var data = _purchaseOrderPocket.SelectPoModels(purchaseOrderModelArgs);
                PurchaseOrderReport report = new PurchaseOrderReport();
                report.DataRefresh(data);
                report.CreateDocument();
                foreach (Page page in report.Pages)
                {
                    xtraReport.Pages.Add(page);
                }
            }
            _currentReport = xtraReport;
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
