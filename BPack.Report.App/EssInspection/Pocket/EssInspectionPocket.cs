using BPack.Common.Pocket;
using BPack.Report.App.EssInspection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.EssInspection.Pocket
{
    public class EssInspectionPocket : PocketBase
    {
        public EssInspectionPocket()
        {
            InitPocket("ReportQuerys");
        }

        /// <summary>
        /// 출하실적 DRH 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public List<EssLotHeaderModel> SelectEssInspectionHeaderTextModel(EssInspectionModelArgs args)
        {
            //헤더도 한번에 여러건 리턴 
            return PocketQuery<EssLotHeaderModel>("Report.EssInspection.DrhHeader.R", new
            {
                COMP_CD = args.COMP_CD,
                PLANT_CD = args.PLANT_CD,
                DRH_NO = args.DRH_NO,
                HU_NO=args.HU_NO,
                BARCODE_TEXT=args.BARCODE_TEXT
            });
        }

        /// <summary>
        /// LOT 1건 전체 데이터 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public List<EssLotDetailModel> SelectEssInspectionDetailDataModel(EssInspectionModelArgs args)
        {
            List<EssLotDetailModel> models = new List<EssLotDetailModel>();

            var multi = PocketMultiple("Report.EssInspection.Detail.R", new
            {
                COMP_CD = args.COMP_CD,
                PLANT_CD = args.PLANT_CD,
                DRH_NO = args.DRH_NO,
                HU_NO = args.HU_NO,
                BARCODE_TEXT = args.BARCODE_TEXT
            });
            EssLotDetailModel _detailModel = new EssLotDetailModel();
            _detailModel = multi.Read<EssLotDetailModel>().First();

            List<EssEolModel> _essEolModels = new List<EssEolModel>();
            _essEolModels = multi.Read<EssEolModel>().ToList();
            _detailModel.EssEolModels = _essEolModels;

            List<EssHousingModel> _essHousingModels = new List<EssHousingModel>();
            _essHousingModels= multi.Read<EssHousingModel>().ToList();
            _detailModel.EssHousingModels = _essHousingModels;

            List<EssCellModel> _essCellModels = new List<EssCellModel>();
            _essCellModels = multi.Read<EssCellModel>().ToList();

            _detailModel.EssCellModels = _essCellModels;

            models.Add(_detailModel);
            return models;


        }

    }
}
