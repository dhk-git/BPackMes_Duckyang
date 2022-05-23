using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.OperationWeekPlan;

namespace BPack.Pocket.App.PC.OperationWeekPlan
{
    public class OperationWeekPlanPocket : PocketBase
    {
        public OperationWeekPlanPocket()
        {
            InitPocket("OperationWeekPlan");
        }

        public List<WeekItemMasterModel> SelectItemMasterModels(OperationWeekPlanModelArgs args)
        {
            return PocketQuery<WeekItemMasterModel>("PC.OperationWeekPlan.ItemList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Year_cd
            });
        }
        public void SaveWeekItemModel(List<WeekItemModel> models)
        {
            PocketExecute("PC.OperationWeekPlan.PlanItem.Save", GetParameters_StrapDisableParam(models));
        }
        public List<WeekPlanGrModel> SelectWeekPlanGrModel(OperationWeekPlanModelArgs args)
        {
            return PocketQuery<WeekPlanGrModel>("PC.OperationWeekPlan.WeekPlanHeaderList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                START_DT = args.Select_Main_Plan_Start_dt,
                END_DT=args.Select_Main_Plan_End_dt,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }
        public DataTable SelectWeekPlanDetailGrModel(OperationWeekPlanModelArgs args)
        {
            //USP_PC_SNOP_WeekPlan_DetailGr_R
            return PocketQuery("PC.OperationWeekPlan.WeekPlanDetailGrList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                START_DT = args.Select_Main_Plan_Start_dt,
                END_DT = args.Select_Main_Plan_End_dt,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        public DataTable SelectWeekPlanDetailModel(OperationWeekPlanModelArgs args)
        {
            return PocketQuery("PC.OperationWeekPlan.WeekPlanDetailList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                START_DT = args.Select_Main_Plan_Start_dt,
                END_DT = args.Select_Main_Plan_End_dt,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        public DataTable SelectWeekPlanDetailSumModel(OperationWeekPlanModelArgs args)
        {
            return PocketQuery("PC.OperationWeekPlan.WeekPlanDetailSumList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                START_DT = args.Select_Main_Plan_Start_dt,
                END_DT = args.Select_Main_Plan_End_dt,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        public void SaveWeekPlanModel(List<WeekPlanModel> WeekPlanModels)
        {
            PocketExecute("PC.OperationWeekPlan.WeekPlanDetailList.CUD", GetParameters_StrapDisableParam(WeekPlanModels));
        }

        public void SaveWeekPlanConfirm(WeekConfirmModel weekConfirmModels)
        {
            PocketExecute("PC.OperationWeekPlan.WeekPlanConFirm.CUD", GetParameters_StrapDisableParam(weekConfirmModels));
        }
             




    }
}
