using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeRsltInfo;
using System.Collections.Generic;

namespace BPack.Pocket.App.PC.WoeRsltInfo
{
    public class WoeRsltInfoPocket : PocketBase
    {
        public WoeRsltInfoPocket()
        {
            InitPocket("WoeRsltInfo");
        }

        public List<WoeRsltInfoModel> SelectWoeRsltInfoModels(WoeRsltInfoModelArgs args)
        {
            return PocketQuery<WoeRsltInfoModel>("PC.WoeRsltInfo.WoList.Select", new
            {
                COMP_CD = args.CompCd,
                PLANT_CD = args.PlantCd,
                WC_CD = args.WcCd,
                WO_DT_FROM = args.WoDtFrom,
                WO_DT_TO = args.WoDtTo,
                ITEM_CD = args.ItemCd,
                ITEM_NM = args.ItemNm
            });
        }

        public List<WoeRsltInfoRsModel> SelectWoeRsltInfoRsModels(WoeRsltInfoModelArgs args)
        {
            return PocketQuery<WoeRsltInfoRsModel>("PC.WoeRsltInfo.Rs.Select", new
            {
                WO_NO = args.WoNo,
                ROUTE_NO = args.RouteNo,
                OPER = args.Oper
            });
        }

        public List<WoeRsltInfoHuModel> SelectWoeRsltInfoHuModels(WoeRsltInfoModelArgs args)
        {
            return PocketQuery<WoeRsltInfoHuModel>("PC.WoeRsltInfo.Hu.Select", new
            {
                WO_NO = args.WoNo
            });
        }

        public List<WorkResultModel> SelectWorkResultModels(WoeRsltInfoModelArgs args)
        {
            return PocketQuery<WorkResultModel>("PC.WoeRsltInfo.WorkResult.Select", new
            {
                COMP_CD = args.CompCd,
                PLANT_CD = args.PlantCd,
                WC_CD = args.WcCd,
                START_DT = args.WoDtFrom,
                END_DT = args.WoDtTo,
                ITEM_CD = args.ItemCd,
                ITEM_NM = args.ItemNm,
                ITEM_GR_1 = args.ItemGr1
            });
        }

    }
}
