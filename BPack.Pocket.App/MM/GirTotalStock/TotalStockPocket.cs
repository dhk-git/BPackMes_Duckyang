using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirTotalStock;

namespace BPack.Pocket.App.MM.GirTotalStock
{
    public class GirTotalStockPocket : PocketBase
    {
        public GirTotalStockPocket()
        {
            InitPocket("GirTotalStock");
        }

        public DataTable SelectTotalStockModels(GirTotalStockModelArgs args)
        {
            return PocketQuery("MM.GirTotalStock.TotalStock.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD_LIST = args.Select_Main_Wh_Cd_List,
                ITEM_TYPE = args.Select_Main_Item_Type,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Group_1,
                ITEM_GR_3 = args.Select_Main_Item_Group_3
            });
        }

        public List<LocStockModel> SelectTotalLocStockModels(GirTotalStockModelArgs args)
        {
            return PocketQuery<LocStockModel>("MM.GirTotalStock.TotalLocStock.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
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
