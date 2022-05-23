using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirTotalGirType;

namespace BPack.Pocket.App.MM.GirTotalGirType
{
    public class GirTotalGirTypePocket : PocketBase
    {
        public GirTotalGirTypePocket()
        {
            InitPocket("GirTotalGirType");
        }

        public DataTable SelectTotalStockModels(GirTotalGirTypeModelArgs args)
        {
            return PocketQuery("MM.GirTotalGirType.TotalStock.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                FROM_DT = args.Select_Main_From_Dt,
                TO_DT = args.Select_Main_To_Dt,
                WH_CD_LIST = args.Select_Main_Wh_Cd_List,
                ITEM_TYPE = args.Select_Main_Item_Type,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Group_1,
                ITEM_GR_3 = args.Select_Main_Item_Group_3
            });
        }

        public DataTable SelectCloseCheck(GirTotalGirTypeModelArgs args)
        {
            return PocketQuery("MM.GirTotalGirType.CloseCheck.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                FROM_DT = args.Select_Main_From_Dt
            });
        }
    }
}
