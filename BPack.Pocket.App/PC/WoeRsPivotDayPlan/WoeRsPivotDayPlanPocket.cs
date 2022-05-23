using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeRsPivotDayPlan;

namespace BPack.Pocket.App.PC.WoeRsPivotDayPlan
{
    public class WoeRsPivotDayPlanPocket : PocketBase
    {
        public WoeRsPivotDayPlanPocket()
        {
            InitPocket("WoeRsPivotDayPlan");
        }
        public List<RsPivotDayPlanModel> SelectRsPivotDayPlanModels(WoeRsPivotDayPlanModelArgs args)
        {


            List<RsPivotDayPlanModel> AA = PocketQuery<RsPivotDayPlanModel>("PC.WoeRsPivotDayPlan.WoeRsPivotDayPlanList.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });

            return AA;
        }

    }
}
