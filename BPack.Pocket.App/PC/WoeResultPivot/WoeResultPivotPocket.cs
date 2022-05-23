using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeResultPivot;

namespace BPack.Pocket.App.PC.WoeResultPivot
{
    public class WoeResultPivotPocket : PocketBase
    {
        public WoeResultPivotPocket()
        {
            InitPocket("WoeResultPivot");
        }

        public List<ResultPivotModel> SelectResultPivotModels(WoeResultPivotModelArgs args)
        {
            return PocketQuery<ResultPivotModel>("PC.WoeResultPivot.ResultPivot.Select", new {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                SHIFT_CD = args.Select_Main_Shift_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                ITEM_TYPE_CD = args.Select_Main_Item_Type_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                ALC_CD = args.Select_Main_Alc_Cd
            });
        }

        public List<ResultEachModel> SelectResultEachModels(WoeResultPivotModelArgs args)
        {
            return PocketQuery<ResultEachModel>("PC.WoeResultPivot.ResultEach.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                SHIFT_CD = args.Select_Main_Shift_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                ITEM_TYPE_CD = args.Select_Main_Item_Type_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                ALC_CD = args.Select_Main_Alc_Cd
            });
        }
    }
}
