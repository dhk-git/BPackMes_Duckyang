using BPack.Report.App.Common;
using BPack.Report.App.HandlingUnit.Models;
using BPack.Report.App.HandlingUnit.Pocket;
using BPack.Report.App.HandlingUnit.Reports;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.Factory
{
    public class HandlingUnitReportFactory : IShowReport
    {
        private DevExpress.XtraReports.UI.XtraReport _currentReport;
        private readonly HandlingUnitModelArgs _args = new HandlingUnitModelArgs();
        private readonly HandlingUnitPocket _pocket = new HandlingUnitPocket();
        private static HandlingUnitReportFactory _handlingUnitReportFactory;

        private HandlingUnitReportFactory()
        {

        }
        public static HandlingUnitReportFactory GetInstance()
        {
            _handlingUnitReportFactory = _handlingUnitReportFactory ?? new HandlingUnitReportFactory();
            return _handlingUnitReportFactory;
        }
        /// <summary>
        /// 자재부품식별표 바코드라벨 출력
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_Mat(List<string> huNoList, PaperKind paperKind = PaperKind.A5)
        {
            if (huNoList.Count == 0) return null;

            _args.Select_HuNoList = huNoList;
            var data = _pocket.SelectMatBarcodeReportModels(_args);

            if (paperKind == PaperKind.A5)
            {
                MatBarcodeReportA5 report = new MatBarcodeReportA5();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            else
            {
                MatBarcodeReportA4 report = new MatBarcodeReportA4();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            return this;
        }
        /// <summary>
        /// 생산부품식별표 바코드라벨 출력
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_PalletProd(List<string> huNoList, PaperKind paperKind = PaperKind.A5)
        {
            if (huNoList.Count == 0) return null;

            _args.Select_HuNoList = huNoList;
            var data = _pocket.SelectMatBarcodeReportModels(_args);

            if (paperKind == PaperKind.A5)
            {
                PalletProdBarcodeReportA5 report = new PalletProdBarcodeReportA5();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            else
            {
                PalletProdBarcodeReportA4 report = new PalletProdBarcodeReportA4();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            return this;
        }
        /// <summary>
        /// 생산부품식별표 박스 바코드라벨 출력(현재 파렛트식별표와 동일함 20210302 )
        /// </summary>
        /// <param name="huNoList"></param>
        /// <param name="paperKind"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_BoxProd(List<string> huNoList, PaperKind paperKind = PaperKind.A5)
        {
            if (huNoList.Count == 0) return null;

            _args.Select_HuNoList = huNoList;
            var data = _pocket.SelectMatBarcodeReportModels(_args);

            if (paperKind == PaperKind.A5)
            {
                PalletProdBarcodeReportA5 report = new PalletProdBarcodeReportA5();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            else
            {
                PalletProdBarcodeReportA4 report = new PalletProdBarcodeReportA4();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            return this;
        }

        /// <summary>
        /// 반제품 개별식별표 바코드 라벨
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_SerialSemi(List<string> huNoList)
        {
            if (huNoList.Count == 0) return null;

            SerialSemiBarcodeReport report = new SerialSemiBarcodeReport();
            _args.Select_HuNoList = huNoList;
            //var data = _pocket.SelectMatBarcodeReportModels(_args);
            var data = _pocket.SelectSerialSemiBarcodeReportModels(_args);
            report.DataRefresh(data);
            report.CreateDocument();
            _currentReport = report;
            return this;
        }
        /// <summary>
        /// 반제품 개별식별표 바코드 라벨 35x55
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_SerialSemi35x55(List<string> huNoList)
        {
            if (huNoList.Count == 0) return null;
            SerialSemiBarcodeReport35x55 report = new SerialSemiBarcodeReport35x55();
            _args.Select_HuNoList = huNoList;
            //var data = _pocket.SelectMatBarcodeReportModels(_args);
            var data = _pocket.SelectSerialSemiBarcodeReportModels(_args);
            report.DataRefresh(data);
            report.CreateDocument();
            _currentReport = report;
            return this;
        }


        /// <summary>
        /// 완제품 개별식별표 바코드 라벨
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_SerialGoods(List<string> huNoList)
        {
            //if (huNoList.Count == 0) return null;

            SerialGoodsBarcodeReport report = new SerialGoodsBarcodeReport();
            _args.Select_HuNoList = huNoList;

            var data = _pocket.SelectSerialGoodsBarcodeReportModels(_args);
            report.DataRefresh(data);
            report.CreateDocument();
            _currentReport = report;
            return this;
        }

        /// <summary>
        /// 만능 식별표 바코드 라벨
        /// </summary>
        /// <param name="barcodeNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_Multi(List<string> barcodeNoList, PaperKind paperKind = PaperKind.A5)
        {
            if (barcodeNoList.Count == 0) return null;

            _args.Select_BarcodeNoList = barcodeNoList;
            var data = _pocket.SelectMultiBarcodeReportModels(_args);

            if (paperKind == PaperKind.A5)
            {
                MultiBarcodeReportA5 report = new MultiBarcodeReportA5();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            else
            {
                MultiBarcodeReportA4 report = new MultiBarcodeReportA4();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            return this;
        }

        /// <summary>
        /// 부적합 태그
        /// </summary>
        /// <param name="ncrNoList"></param>
        /// <param name="reportType"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_NcrTag(List<string> ncrNoList, string reportType, PaperKind paperKind = PaperKind.A5)
        {
            if (ncrNoList.Count == 0) return null;

            _args.Select_NcrNoList = ncrNoList;
            _args.NcrReportType = reportType;
            var data = _pocket.SelectNcrHistTagModels(_args);

            if (paperKind == PaperKind.A5)
            {
                NcrTagReportA5 report = new NcrTagReportA5();
                report.DataRefresh(data, _args.NcrReportType);
                //report.ShowPrintMarginsWarning = false; // 여백 경고 메시지 off

                report.CreateDocument();
                _currentReport = report;
            }
            else
            {
                NcrTagReportA4 report = new NcrTagReportA4();
                report.DataRefresh(data, _args.NcrReportType);

                report.CreateDocument();
                _currentReport = report;
            }

            return this;
        }
        /// <summary>
        /// 부적합 반송 태그
        /// </summary>
        /// <param name="ncrNoList"></param>
        /// <param name="reportType"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_NcrReturnTag(List<string> ncrNoList)
        {
            if (ncrNoList.Count == 0) return null;

            NcrReturnReportA4 report = new NcrReturnReportA4();
            _args.Select_NcrNoList = ncrNoList;

            List<NcrReturnReportHeaderModel> headerModelList = new List<NcrReturnReportHeaderModel>();

            var data = _pocket.SelectNcrHistReturnTagModels(_args);

            var bpGroupingList = data.GroupBy(r => r.BP_CD).ToList();

            foreach (var bpGroup in bpGroupingList)
            {
                string[] reportTitle = new string[] { "반송증(품질팀 보관용)", "반송증(자재팀 보관용)", "반송증(업체용)" };

                for (int i = 0; i < reportTitle.Count(); i++)
                {
                    NcrReturnReportHeaderModel headerModel = new NcrReturnReportHeaderModel();
                    headerModel.REPORT_TYPE_SEQ = i.ToString();
                    headerModel.REPORT_TITLE = reportTitle[i];

                    var firstModel = bpGroup.ToList().FirstOrDefault();
                    headerModel.BP_CD = firstModel.BP_CD;
                    headerModel.BP_NM = firstModel.BP_NM;
                    headerModel.JUDGE_USER = firstModel.JUDGE_USER;
                    headerModel.REPORT_DATE = firstModel.REPORT_DATE;
                    headerModel.REJECTED_DATE = firstModel.REJECTED_DATE;
                    headerModel.INCOMING_DATE = firstModel.INCOMING_DATE;
                    headerModel.detailModels = new List<NcrReturnReportDetailModel>();

                    foreach (var item in bpGroup)
                    {
                        NcrReturnReportDetailModel detailModel = new NcrReturnReportDetailModel();
                        detailModel.ROW_NO = (headerModel.detailModels.Count() + 1).ToString();
                        detailModel.ITEM_CD = item.ITEM_CD;
                        detailModel.ITEM_NM = item.ITEM_NM;
                        detailModel.LOT_NO = item.LOT_NO;
                        detailModel.INCOMING_QTY = item.INCOMING_QTY;
                        detailModel.REJECTED_QTY = item.REJECTED_QTY;
                        detailModel.NCR_NM = item.NCR_NM;
                        headerModel.detailModels.Add(detailModel);
                    }

                    // 빈공간 채움
                    for (int j = bpGroup.Count(); j < 7; j++)
                    {
                        NcrReturnReportDetailModel detailModel = new NcrReturnReportDetailModel();
                        detailModel.ROW_NO = (headerModel.detailModels.Count() + 1).ToString();
                        headerModel.detailModels.Add(detailModel);
                    }

                    headerModelList.Add(headerModel);
                }
            }

            report.DataRefresh(headerModelList);
            report.CreateDocument();
            _currentReport = report;
            return this;
        }

        /// <summary>
        /// 초중종 태그
        /// </summary>
        /// <param name="InspNoList"></param>
        /// <param name="reportType"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_FmlTag(List<string> inspNoList, PaperKind paperKind = PaperKind.A5)
        {
            if (inspNoList.Count == 0) return null;

            _args.Select_InspNoList = inspNoList;
            var data = _pocket.SelectFmlTagModels(_args);

            if (paperKind == PaperKind.A5)
            {
                FmlTagReportA5 report = new FmlTagReportA5();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            else
            {
                FmlTagReportA4 report = new FmlTagReportA4();
                report.DataRefresh(data);
                report.CreateDocument();
                _currentReport = report;
            }
            return this;
        }

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

        /// <summary>
        /// 매핑 식별표 바코드 라벨
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public IShowReport HandlingUnit_Mapping(List<string> huNoList)
        {
            return this;
        }

        public DevExpress.XtraReports.UI.XtraReport GetReport()
        {
            return _currentReport;
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

    }
}
