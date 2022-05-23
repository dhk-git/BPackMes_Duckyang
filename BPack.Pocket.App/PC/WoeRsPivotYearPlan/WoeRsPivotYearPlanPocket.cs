using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeRsPivotYearPlan;

namespace BPack.Pocket.App.PC.WoeRsPivotYearPlan
{
    public class WoeRsPivotYearPlanPocket : PocketBase
    {
        public WoeRsPivotYearPlanPocket()
        {
            InitPocket("WoeRsPivotYearPlan");
        }

        public List<YearPlanGrModel> SelectRsYearPlanGrModel(WoeRsPivotYearPlanModelArgs args)
        {
            return PocketQuery<YearPlanGrModel>("PC.WoeRsPivotYearPlan.HeaderList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Select_Main_Plan_Year_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }
        public DataTable SelectRsYearPlanModel_DataTable(WoeRsPivotYearPlanModelArgs args)
        {
            return PocketQuery("PC.WoeRsPivotYearPlan.DetailList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Select_Main_Plan_Year_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }

        public List<YearPlanGrModel> SelectRsYearPlanGrSumModel(WoeRsPivotYearPlanModelArgs args)
        {
            return PocketQuery<YearPlanGrModel>("PC.WoeRsPivotYearPlan.SumList.R", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                YEAR_CD = args.Select_Main_Plan_Year_cd,
                ITEM_CD = args.Select_Main_Item_cd,
                ITEM_GR_1 = args.Select_Main_Item_Group_cd
            });
        }
    }
}
