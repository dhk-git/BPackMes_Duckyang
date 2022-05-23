using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvOrderVsResult;

namespace BPack.Pocket.App.SD.DlvOrderVsResult
{
    public class DlvOrderVsResultPocket : PocketBase
    {
        public DlvOrderVsResultPocket()
        {
            InitPocket("DlvOrderVsResult");
        }
        public List<DlvOrderVsResultModel> SelectDlvOrderVsResultModels(DlvOrderVsResultModelArgs args)
        {
            return PocketQuery<DlvOrderVsResultModel>("SD.DlvOrderVsResult.DlvOrderVsResultList.R", new {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                BP_CD = args.Select_Main_Bp_Cd,
                IS_TOTAL_DATE = args.Select_Main_IsTotalDate
            });
        }
    }
}
