using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeBadRsPivot;

namespace BPack.Pocket.App.PC.WoeBadRsPivot
{
    public class WoeBadRsPivotPocket : PocketBase
    {
        public WoeBadRsPivotPocket()
        {
            InitPocket("WoeBadRsPivot");
        }
        public List<BadRsPivotModel> SelectBadRsPivotModels(WoeBadRsPivotModelArgs args)
        {
            return PocketQuery<BadRsPivotModel>("PC.WoeBadRsPivot.BadRsPivotList.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WC_CD = args.Select_Main_Wc_Cd,
                ITEM_CD= args.Select_Main_Item_Cd,
                ITEM_NM=args.Select_Main_Item_Nm,
                SEARCH_TYPE = args.Select_Main_SearchType,
            });
        }
        public List<BadRsPivotBadModel> SelectBadRsPivotBadModels(WoeBadRsPivotModelArgs args)
        {
            return PocketQuery<BadRsPivotBadModel>("PC.WoeBadRsPivot.BadList.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WC_CD = args.Select_Sub_Wc_Cd,
                ITEM_CD =args.Select_Sub_Item_Cd,
                ITEM_NM=args.Select_Sub_Item_Nm,
                YEAR_CD = args.Select_Sub_Year_Cd,
                MONTH_CD = args.Select_Sub_Month_Cd,
                WEEK_CD = args.Select_Sub_Week_Cd,
                WORK_DT = args.Select_Sub_Work_dt,
                SEARCH_TYPE = args.Select_Main_SearchType,
            });
        }
        public void SaveBadRsPivotBadModel(BadRsPivotBadModel model)
        {
            PocketExecute("PC.WoeBadRsPivot.BadtList.Save"
                , GetParameters_StrapDisableParam(model));
        }
        public void SaveBadRsPivotBadModels(List<BadRsPivotBadModel> models)
        {
            PocketExecute("PC.WoeBadRsPivot.BadList.Save"
                , GetParameters_StrapDisableParam(models));
        }
    }
}
