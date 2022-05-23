using BPack.Report.App.Common;
using BPack.Report.App.EssInspection.Models;
using BPack.Report.App.EssInspection.Pocket;
using BPack.Report.App.EssInspection.Reports;
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
    public class EssInspectionReportFactory : IShowReport
    {
        private DevExpress.XtraReports.UI.XtraReport _currentReport;
        private static EssInspectionReportFactory _reportFactory;

        private EssInspectionModelArgs ModelArgs = new EssInspectionModelArgs();
        private EssInspectionPocket docPocket = new EssInspectionPocket();
        public EssInspectionReportFactory()
        {

        }

        public static EssInspectionReportFactory GetInstance()
        {
            _reportFactory = _reportFactory ?? new EssInspectionReportFactory();
            return _reportFactory;
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
            pt.PreviewForm.PrintControl.SetPageView(1, 1);
            pt.ShowPreviewDialog();
        }
        #endregion

        /// <summary>
        /// 출하실적 -출하실적 DRH NO 대상 전체 조회
        /// </summary>
        /// <param name="Comp_cd"></param>
        /// <param name="Plant_cd"></param>
        /// <param name="Drh_No"></param>
        /// <returns></returns>
        public IShowReport ShowReport_Drh( string Drh_No)
        {
            ModelArgs.DRH_NO = Drh_No;

            List<EssLotHeaderModel> HeaderModels = SelectEssLotHeader();

            if (HeaderModels == null || HeaderModels.Count == 0)
            {
                return null;
            }
            EssInspectionDoc_New DocumeintReport = new EssInspectionDoc_New();
            DocumeintReport.Datarefresh(HeaderModels);
            DocumeintReport.CreateDocument();
            _currentReport = DocumeintReport;

            return this;
        }

        /// <summary>
        /// BARCODE 대상 1건 조회
        /// </summary>
        /// <param name="Comp_cd"></param>
        /// <param name="Plant_cd"></param>
        /// <param name="BarCodeText"></param>
        /// <returns></returns>
        public IShowReport ShowReport_BarCodeText(string Comp_cd, string Plant_cd, string BarCodeText)
        {
            ModelArgs.COMP_CD = Comp_cd;
            ModelArgs.PLANT_CD = Plant_cd;
            ModelArgs.BARCODE_TEXT = BarCodeText;
            List<EssLotHeaderModel> HeaderModels = SelectEssLotHeader();

            if (HeaderModels == null || HeaderModels.Count == 0)
            {
                return null;
            }
            EssInspectionDoc DocumeintReport = new EssInspectionDoc();
            DocumeintReport.Datarefresh(HeaderModels);
            DocumeintReport.CreateDocument();
            _currentReport = DocumeintReport;

            return this;
        }

        /// <summary>
        /// 식별표 대상 1건 조회
        /// </summary>
        /// <param name="Comp_cd"></param>
        /// <param name="Plant_cd"></param>
        /// <param name="Huno"></param>
        /// <returns></returns>
        public IShowReport ShowReport_HuNo(string Comp_cd, string Plant_cd, string Huno)
        {
            ModelArgs.COMP_CD = Comp_cd;
            ModelArgs.PLANT_CD = Plant_cd;
            ModelArgs.HU_NO = Huno;
            List<EssLotHeaderModel> HeaderModels = SelectEssLotHeader();

            if (HeaderModels == null || HeaderModels.Count == 0)
            {
                return null;
            }
            EssInspectionDoc DocumeintReport = new EssInspectionDoc();
            DocumeintReport.Datarefresh(HeaderModels);
            DocumeintReport.CreateDocument();
            _currentReport = DocumeintReport;

            return this;
        }

        /// <summary>
        /// 출하실적+식별표 대상 1건 조회
        /// </summary>
        /// <param name="Comp_cd"></param>
        /// <param name="Plant_cd"></param>
        /// <param name="Drh_No"></param>
        /// <param name="Huno"></param>
        /// <returns></returns>
        public IShowReport ShowReportDrhHuNo(string Comp_cd, string Plant_cd, string Drh_No, string Huno)
        {
            ModelArgs.COMP_CD = Comp_cd;
            ModelArgs.PLANT_CD = Plant_cd;
            ModelArgs.DRH_NO = Drh_No;
            ModelArgs.HU_NO = Huno;
            List<EssLotHeaderModel> HeaderModels = SelectEssLotHeader();

            if (HeaderModels == null || HeaderModels.Count == 0)
            {
                return null;
            }
            EssInspectionDoc DocumeintReport = new EssInspectionDoc();
            DocumeintReport.Datarefresh(HeaderModels);
            DocumeintReport.CreateDocument();
            _currentReport = DocumeintReport;

            return this;
        }

        public List<EssLotHeaderModel> SelectEssLotHeader()
        {
            List<EssLotHeaderModel> HeaderModels = docPocket.SelectEssInspectionHeaderTextModel(ModelArgs);
            if (HeaderModels == null || HeaderModels.Count == 0)
            {
                return null;
            }
            foreach (EssLotHeaderModel headerModel in HeaderModels)
            {
                ModelArgs.COMP_CD = headerModel.COMP_CD;
                ModelArgs.PLANT_CD = headerModel.PLANT_CD;
                ModelArgs.HU_NO = headerModel.HU_NO;
                ModelArgs.DRH_NO = headerModel.DRH_NO;
                ModelArgs.BARCODE_TEXT = headerModel.BARCODE_TEXT;
                List<EssLotDetailModel> DetailModels = docPocket.SelectEssInspectionDetailDataModel(ModelArgs);
                    headerModel.detailModels = DetailModels;
            }
            return HeaderModels;
        }
    }
}
