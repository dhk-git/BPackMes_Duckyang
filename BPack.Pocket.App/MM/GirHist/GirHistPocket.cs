using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirHist;

namespace BPack.Pocket.App.MM.GirHist
{
    public class GirHistPocket : PocketBase
    {
        public GirHistPocket()
        {
            InitPocket("GirHist");
        }

        public List<GirHistModel> SelectGirHistModels(GirHistModelArgs args) {
            return PocketQuery<GirHistModel>("MM.GirHist.List.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                GIR_TYPE_CD = args.Select_Main_Gir_Type_Cd,
                WH_CD_LIST = args.Select_Main_Wh_Cd_List,
                ITEM_TYPE = args.Select_Main_Item_Type,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Group_1,
                ITEM_GR_3 = args.Select_Main_Item_Group_3
            });
        }
    }
}
