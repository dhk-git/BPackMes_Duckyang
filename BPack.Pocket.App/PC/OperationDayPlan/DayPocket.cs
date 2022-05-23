using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.OperationDayPlan;

namespace BPack.Pocket.App.PC.OperationDayPlan
{
    public class OperationDayPlanPocket : PocketBase
    {
        public OperationDayPlanPocket()
        {
            InitPocket("OperationDayPlan");
        }
        public DataTable SelectDayPlanDetailGrModel(OperationDayPlanModelArgs args)
        {
            //USP_PC_SNOP_WeekPlan_DetailGr_R
            return PocketQuery("PC.OperationDayPlan.DayPlanDetailGrList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                MONTH_DT = args.Select_Main_Plan_Month_dt,
                WEEK_CD = args.Select_Main_Month_Week_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                SNOP_STATUS = args.Select_Main_Snop_Status
            });
        }
        public List<DayPlanGrModel> SelectDayPlanGrModel(OperationDayPlanModelArgs args)
        {
            return PocketQuery<DayPlanGrModel>("PC.OperationDayPlan.DayPlanHeaderList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                MONTH_DT = args.Select_Main_Plan_Month_dt,
                WEEK_CD = args.Select_Main_Month_Week_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                SNOP_STATUS = args.Select_Main_Snop_Status
            }); 
        }
        public DataTable SelectDayPlanDetailModel(OperationDayPlanModelArgs args)
        {
            return PocketQuery("PC.OperationDayPlan.DayPlanDetailList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                MONTH_DT = args.Select_Main_Plan_Month_dt,
                WEEK_CD = args.Select_Main_Month_Week_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                SNOP_STATUS = args.Select_Main_Snop_Status

            });
        }
        public void SaveDayPlanModel(List<DayPlanModel> DayPlanModels)
        {
            PocketExecute("PC.OperationDayPlan.DayPlanDetailList.CUD", GetParameters_StrapDisableParam(DayPlanModels));
        }
        public void SaveDayPlanConfirm(DayConfirmModel dayConfirmModels)
        {
            PocketExecute("PC.OperationDayPlan.DayPlanConFirm.CUD", GetParameters_StrapDisableParam(dayConfirmModels));
        }



    }
}
