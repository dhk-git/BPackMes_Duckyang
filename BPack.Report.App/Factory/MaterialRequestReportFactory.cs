using BPack.Report.App.Common;
using BPack.Report.App.MaterialRequest;
using BPack.Report.App.MaterialRequest.Pocket;
using BPack.Report.App.MaterialRequest.Reports;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.Factory
{
    public class MaterialRequestReportFactory : IShowReport
    {
        private DevExpress.XtraReports.UI.XtraReport _currentReport;
        private static MaterialRequestReportFactory _materialRequestReportFactory;

        private MaterialRequestDocModelArgs ModelArgs = new MaterialRequestDocModelArgs();
        private MaterialRequestDocPocket docPocket = new MaterialRequestDocPocket();
        public MaterialRequestReportFactory()
        {

        }

        public static MaterialRequestReportFactory GetInstance()
        {
            _materialRequestReportFactory = _materialRequestReportFactory ?? new MaterialRequestReportFactory();
            return _materialRequestReportFactory;
        }

        #region 인터페이스 구현
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
            pt.ShowPreviewDialog();
        }
        #endregion

        public IShowReport ShowReport(string Comp_cd, string Plant_cd, string Mrh_No)
        {
            ModelArgs.COMP_CD = Comp_cd;
            ModelArgs.PLANT_CD = Plant_cd;
            ModelArgs.MRH_NO = Mrh_No;

            var HeaderModels = docPocket.SelectMaterialRequestHeaderModel(ModelArgs);

            var DetailModels = docPocket.SelectMaterialRequestDetailModel(ModelArgs);

            if (HeaderModels.Count >= 1)
            {
                HeaderModels[0].DetailModels = DetailModels;
            }
            MaterialRequestDoc requestDoc = new MaterialRequestDoc(HeaderModels);
            requestDoc.CreateDocument();
            _currentReport = requestDoc;

            return this;
        }
    }
}
