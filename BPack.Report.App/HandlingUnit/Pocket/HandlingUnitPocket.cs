using BPack.Common.Pocket;
using BPack.Report.App.HandlingUnit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Pocket
{
    public class HandlingUnitPocket : PocketBase
    {
        public HandlingUnitPocket()
        {
            InitPocket("ReportQuerys");
        }

        //중포장 레포트
        public List<dy_MPackingHeaderModel> SelectHuMPackingBarcodeReportModels(HandlingUnitModelArgs args)
        {
        
            string MebBarcodeList = "";
            foreach (var huNo in args.Select_MebBarcodeList)
            {
                MebBarcodeList += MebBarcodeList == "" ? huNo : "^#^" + huNo;
            }

            return PocketQuery<dy_MPackingHeaderModel>("Report.HandlingUnit.HuMPacking.R", new { MEB_BARCODE_LIST  = MebBarcodeList });
            //return PocketQuery<dy_MPackingHeaderModel>("Report.HandlingUnit.HuBigPacking.R", new { HU_NO_LIST = huNoList });
        }

        //MEB 대포장 레포트 OLD
        public List<dy_LPackingHeaderModel> SelectLPackingBarcodeReprotModels(HandlingUnitModelArgs args)
        {
            string huNoList = "";
            foreach (var huNo in args.Select_HuNoList)
            {
                huNoList += huNoList == "" ? huNo : "^#^" + huNo;
            }
            return PocketQuery<dy_LPackingHeaderModel>("Report.HandlingUnit.HuLPacking.R", new { HU_NO_LIST = huNoList });
        }

        //MEB 대포장 레포트 
        public List<dy_LpackModel> SelectDy_LpackReportModels(HandlingUnitModelArgs args)
        {
            List<dy_LpackModel> models = new List<dy_LpackModel>();

            string huNo = "";
            foreach (var _huNo in args.Select_HuNoList)
            {
                huNo = _huNo;
            }
            var multi = PocketMultiple("Report.HandlingUnit.HuLPack.R", new
            {
                HU_NO = huNo
            });
            dy_LpackModel firstModel = new dy_LpackModel();
            firstModel = multi.Read<dy_LpackModel>().First();

            List<dy_LpackDetailModel> detailModels = new List<dy_LpackDetailModel>();
            detailModels= multi.Read<dy_LpackDetailModel>().ToList();

            firstModel.LpackDetailModel = detailModels;

            models.Add(firstModel);
            return models;

        }


        public List<HuSampleModel> SelectHuSampleBarcodeReportModels(HandlingUnitModelArgs args)
        {
            string huNoList = "";
            foreach (var huNo in args.Select_HuNoList)
            {
                huNoList += huNoList == "" ? huNo : "^#^" + huNo;
            }
            return PocketQuery<HuSampleModel>("Report.HandlingUnit.HuSample.R", new { HU_NO_LIST = huNoList });
        }
        //자재 부품식별표
        public List<MatBarcodeReportModel> SelectMatBarcodeReportModels(HandlingUnitModelArgs args)
        {
            string huNoList = "";
            foreach (var huNo in args.Select_HuNoList)
            {
                huNoList += huNoList == "" ? huNo : "^#^" + huNo;
            }
            return PocketQuery<MatBarcodeReportModel>("Report.HandlingUnit.Mat.R", new { HU_NO_LIST = huNoList });
        }
        //반제품 개별식별표
        public List<SerialSemiBarcodeReportModel> SelectSerialSemiBarcodeReportModels(HandlingUnitModelArgs args)
        {
            string huNoList = "";
            foreach (var huNo in args.Select_HuNoList)
            {
                huNoList += huNoList == "" ? huNo : "^#^" + huNo;
            }
            //return PocketQuery<SerialSemiBarcodeReportModel>("Report.HandlingUnit.SerialSemi.R", new { HU_NO_LIST = huNoList });
            return PocketQuery<SerialSemiBarcodeReportModel>("Report.HandlingUnit.Mat.R", new { HU_NO_LIST = huNoList });
        }
        //완제품 개별 식별표
        public List<SerialGoodsBarcodeReportModel> SelectSerialGoodsBarcodeReportModels(HandlingUnitModelArgs args)
        {
            string huNoList = "";
            foreach (var huNo in args.Select_HuNoList)
            {
                huNoList += huNoList == "" ? huNo : "^#^" + huNo;
            }
            return PocketQuery<SerialGoodsBarcodeReportModel>("Report.HandlingUnit.SerialGoods.R", new { HU_NO_LIST = huNoList });
        }
        //만능 식별표 
        public List<MultiBarcodeReportModel> SelectMultiBarcodeReportModels(HandlingUnitModelArgs args)
        {
            string barcodeNoList = "";
            foreach (var barcodeNo in args.Select_BarcodeNoList)
            {
                barcodeNoList += barcodeNoList == "" ? barcodeNo : "^#^" + barcodeNo;
            }
            return PocketQuery<MultiBarcodeReportModel>("Report.HandlingUnit.Multi.R", new { BARCODE_NO_LIST = barcodeNoList });
        }
        //매핑 식별표
        public List<MappingBarcodeReportModel> MappingBarcodeReportModels(HandlingUnitModelArgs args)
        {
            string huNoList = "";
            foreach (var huNo in args.Select_HuNoList)
            {
                huNoList += huNoList == "" ? huNo : "^#^" + huNo;
            }
            return PocketQuery<MappingBarcodeReportModel>("Report.HandlingUnit.Mapping.R", new { HU_NO_LIST = huNoList });
        }

        // 부적합 태그
        public List<NcrTagReportModel> SelectNcrHistTagModels(HandlingUnitModelArgs args)
        {
            string ncrNoList = "";
            foreach (var ncrNo in args.Select_NcrNoList)
            {
                ncrNoList += ncrNoList == "" ? ncrNo : "/" + ncrNo;
            }
            return PocketQuery<NcrTagReportModel>("Report.HandlingUnit.NcrTag.R", new { NCR_NO = ncrNoList, REPORT_TYPE = args.NcrReportType });
        }

        // 부적합 반송 태그
        public List<NcrReturnReportModel> SelectNcrHistReturnTagModels(HandlingUnitModelArgs args)
        {
            string ncrNoList = "";
            foreach (var ncrNo in args.Select_NcrNoList)
            {
                ncrNoList += ncrNoList == "" ? ncrNo : "/" + ncrNo;
            }
            return PocketQuery<NcrReturnReportModel>("Report.HandlingUnit.NcrReturnTag.R", new { NCR_NO = ncrNoList });
        }

        // 초중종 검사 태그
        public List<FmlTagReportModel> SelectFmlTagModels(HandlingUnitModelArgs args)
        {
            string InspNoList = "";
            foreach (var InspNo in args.Select_InspNoList)
            {
                InspNoList += InspNoList == "" ? InspNo : "^#^" + InspNo;
            }
            return PocketQuery<FmlTagReportModel>("Report.HandlingUnit.FmlTag.R", new { INSP_NO_LIST = InspNoList });
        }

    }
}
