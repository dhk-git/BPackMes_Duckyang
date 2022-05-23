using BPack.Report.App.Common;
using BPack.Report.App.HandlingUnit.Models;
using BPack.Report.App.HandlingUnit.Pocket;
using BPack.Report.App.HandlingUnit.Reports;
using BPack.Report.App.HandlingUnit.Reports.DY;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.Factory.Dy_HandlingUnit
{
    public class Dy_HandlingUnitReportFactory : IShowReport
    {
        private DevExpress.XtraReports.UI.XtraReport _currentReport;
        private readonly HandlingUnitModelArgs _args = new HandlingUnitModelArgs();
        private readonly HandlingUnitPocket _pocket = new HandlingUnitPocket();
        private static Dy_HandlingUnitReportFactory _handlingUnitReportFactory;
        public Dy_HandlingUnitReportFactory()
        {

        }
        public static Dy_HandlingUnitReportFactory GetInstance()
        {
            _handlingUnitReportFactory = _handlingUnitReportFactory ?? new Dy_HandlingUnitReportFactory();
            return _handlingUnitReportFactory;
        }

        #region Interface 구현
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
            pt.ShowPreviewDialog();
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

        public XtraReport GetReport()
        {
            return _currentReport;
        }
        #endregion

        public IShowReport HandlingUnit_HuSampleBarcode(List<string> huNoList)
        {
            if (huNoList.Count == 0) return null;

            _args.Select_HuNoList = huNoList;
            var data = _pocket.SelectHuSampleBarcodeReportModels(_args);

            HuSampleReport report = new HuSampleReport();
            report.DataRefresh(data);
            report.CreateDocument();
            _currentReport = report;

            return this;
        }

        //중포장 바코드
        public IShowReport HandlingUnit_MPackingBarcode(List<string> mebBarcodeList)
        {
            if (mebBarcodeList.Count == 0) return null;

            _args.Select_MebBarcodeList = mebBarcodeList;
            var data = _pocket.SelectHuMPackingBarcodeReportModels(_args);

            Dy_MPackingReport report = new Dy_MPackingReport();
            report.DataRefresh(data);
            report.CreateDocument();
            _currentReport = report;

            return this;
        }

        //대포장 바코드
        public IShowReport HandlingUnit_LPackingBarcode(List<string> huNoList)
        {
            //2022.04.12 정수교
            if (huNoList.Count == 0) return null;
            XtraReport xtraReport = new XtraReport();
            foreach (var huNo in huNoList)
            {
                _args.Select_HuNoList = new List<string>();
                _args.Select_HuNoList.Add(huNo);
                var data = _pocket.SelectDy_LpackReportModels(_args);
                Dy_LpackReport report = new Dy_LpackReport();
                report.DataRefresh(data);
                report.CreateDocument();
                foreach (Page page in report.Pages)
                {
                    xtraReport.Pages.Add(page);
                }

            }
            _currentReport = xtraReport;

            //if (huNoList.Count == 0) return null;
            //_args.Select_HuNoList = huNoList;
            //var data = _pocket.SelectLPackingBarcodeReprotModels(_args);

            //Dy_LpackingReport report2 = new Dy_LpackingReport();
            //report.DataRefresh(data);
            //report.CreateDocument();
            //_currentReport = report;

            return this;
        }


    }
}
