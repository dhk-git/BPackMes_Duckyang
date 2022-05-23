using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeNwRsPivot;

namespace BPack.Pocket.App.PC.WoeNwRsPivot
{
    public class WoeNwRsPivotPocket : PocketBase
    {
        public WoeNwRsPivotPocket()
        {
            InitPocket("WoeNwRsPivot");
        }
        public List<NwRsPivotModel> SelectNwRsPivotModels(WoeNwRsPivotModelArgs args)
        { 
            return PocketQuery<NwRsPivotModel>("PC.WoeNwRsPivot.WoeNwRsPivotList.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WC_CD = args.Select_Main_Wc_Cd,
                SEARCH_TYPE = args.Select_Main_SearchType,
            });
        }
        public List<NwRsPivotNotworkModel> SelectNwRsPivotNotworkModels(WoeNwRsPivotModelArgs args)
        {
            return PocketQuery<NwRsPivotNotworkModel>("PC.WoeNwRsPivot.NotworktList.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WC_CD=args.Select_Sub_Wc_Cd,
                YEAR_CD=args.Select_Sub_Year_Cd,
                MONTH_CD=args.Select_Sub_Month_Cd,
                WEEK_CD=args.Select_Sub_Week_Cd,
                WORK_DT = args.Select_Sub_Work_dt,
                SEARCH_TYPE = args.Select_Main_SearchType,
            });
        }
        public void SaveNwRsPivotNotworkModel(NwRsPivotNotworkModel nwRsPivotNotworkModel)
        {
            PocketExecute("PC.WoeNwRsPivot.NotworktList.Save"
                , GetParameters_StrapDisableParam(nwRsPivotNotworkModel));
        }
        public void SaveNwRsPivotNotworkModels(List<NwRsPivotNotworkModel> nwRsPivotNotworkModels)
        {
            PocketExecute("PC.WoeNwRsPivot.NotworktList.Save"
                , GetParameters_StrapDisableParam(nwRsPivotNotworkModels));
        }
    }
}
