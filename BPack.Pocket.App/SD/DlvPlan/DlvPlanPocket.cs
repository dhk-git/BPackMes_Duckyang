using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvPlan;

namespace BPack.Pocket.App.SD.DlvPlan
{
    public class DlvPlanPocket : PocketBase
    {
        public DlvPlanPocket()
        {
            InitPocket("DlvPlan");
        }

        public List<SalesOrderSummaryModel> SelectSalesOrderSummaryModels(DlvPlanModelArgs args)
        {
            return PocketQuery<SalesOrderSummaryModel>("SD.DlvPlan.SalesOrderSummary.R", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });
        }

        public List<DlvPlanModel> SelectDlvPlanModels(DlvPlanModelArgs args)
        {
            return PocketQuery<DlvPlanModel>("SD.DlvPlan.Plan.R", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });
        }

        public void SaveDlvPlanModels(List<DlvPlanModel> dlvPlanModels)
        {
            PocketExecute("SD.DlvPlan.Plan.CUD", dlvPlanModels);
        }

    }
}
