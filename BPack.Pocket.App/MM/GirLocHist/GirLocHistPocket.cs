using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirLocHist;

namespace BPack.Pocket.App.MM.GirLocHist
{
    public class GirLocHistPocket : PocketBase
    {
        public GirLocHistPocket()
        {
            InitPocket("GirLocHist");
        }
        public List<GirLocInModel> SelectGirLocInHistModels(GirLocHistModelArgs args)
        {
            return PocketQuery<GirLocInModel>("MM.GirLocHist.InList.Select", new
            {
                COMP_CD=args.Select_Main_Comp_Cd,
                PLANT_CD=args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WH_CD =args.Select_Main_Wh_Cd,
                ITEM_TYPE_CD=args.Select_Main_Item_Type_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                BARCODE_TEXT=args.Select_Main_BarcodeText,
                LOC_IN_TYPE=args.Select_Main_LocInType
            });
        }
        public List<GirLocOutModel> SelectGirLocOutHistModels(GirLocHistModelArgs args)
        {
            return PocketQuery<GirLocOutModel>("MM.GirLocHist.OutList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WH_CD = args.Select_Main_Wh_Cd,
                ITEM_TYPE_CD = args.Select_Main_Item_Type_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                BARCODE_TEXT = args.Select_Main_BarcodeText,
                LOC_OUT_TYPE=args.Select_Main_LocOutType
            });
        }
    }
}
