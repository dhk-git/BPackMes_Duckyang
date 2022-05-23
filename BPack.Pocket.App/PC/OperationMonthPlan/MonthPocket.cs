using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.OperationMonthPlan;

namespace BPack.Pocket.App.PC.OperationMonthPlan
{
    public class OperationMonthPlanPocket : PocketBase
    {
        public OperationMonthPlanPocket()
        {
            InitPocket("OperationMonthPlan");
        }
        public void SaveMonthItemModel(List<MonthItemModel> models)
        {
            PocketExecute("PC.OperationMonthPlan.PlanItem.Save", GetParameters_StrapDisableParam(models));
        }

        public List<MonthPlanGrModel> SelectMonthPlanGrModel(OperationMonthPlanModelArgs args)
        {
            return PocketQuery<MonthPlanGrModel>("PC.OperationMonthPlan.MonthPlanHeaderList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Select_Main_Plan_Year_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        //public List<MonthPlan> SelectMonthPlanModel(OperationMonthPlanModelArgs args)
        //{
        //    return PocketQuery<MonthPlan>("PC.OperationMonthPlan.MonthPlanDetailList.R", new
        //    {
        //        COMP_CD = Common.LoginInfo.UserInfo.CompCode,
        //        PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
        //        YEAR_CD = args.Select_Main_Plan_Year_cd,
        //        ITEM_CD = args.Select_Main_Item_cd,
        //        ITEM_GR_1 = args.Select_Main_Item_Group_cd
        //    });
        //}

        public DataTable SelectMonthPlanModel_DataTable(OperationMonthPlanModelArgs args)
        {
            return PocketQuery("PC.OperationMonthPlan.MonthPlanDetailList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Select_Main_Plan_Year_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        public List<MonthPlanGrModel> SelectMonthPlanGrSumModel(OperationMonthPlanModelArgs args)
        {
            return PocketQuery<MonthPlanGrModel>("PC.OperationMonthPlan.MonthPlanSumList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Select_Main_Plan_Year_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        public void SaveMonthPlanModel(List<MonthPlan> MonthPlanModels)
        {
            PocketExecute("PC.OperationMonthPlan.MonthPlanDetailList.CUD", GetParameters_StrapDisableParam(MonthPlanModels));
        }

    }
}
