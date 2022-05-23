using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirLocStock;

namespace BPack.Pocket.App.MM.GirLocStock
{
    public class GirLocStockPocket : PocketBase
    {
        public GirLocStockPocket()
        {
            InitPocket("GirLocStock");
        }

        public List<LocGirModel> SelectLocGirModels(GirLocStockModelArgs args)
        {
            return PocketQuery<LocGirModel>("MM.GirLocStock.Gir.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Main_Wh_Cd,
                LOC_CD = args.Select_Main_Loc_Cd,
                ITEM_CD = args.Select_Stock_Item_Cd
            });
        }

        public List<LocHuModel> SelectLocHuModels(GirLocStockModelArgs args)
        {
            return PocketQuery<LocHuModel>("MM.GirLocStock.Hu.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Main_Wh_Cd,
                LOC_CD = args.Select_Main_Loc_Cd,
                ITEM_CD = args.Select_Stock_Item_Cd
            });
        }

        public List<LocStockModel> SelectLocStockModels(GirLocStockModelArgs args)
        {
            return PocketQuery<LocStockModel>("MM.GirLocStock.Stock.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Main_Wh_Cd,
                LOC_CD = args.Select_Main_Loc_Cd,
                ITEM_TYPE = args.Select_Main_Item_Type
            });
        }

        public void BpGirLocAdjust(GirLocStockModelArgs args)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            DateTime dateTime = Common.Config.SystemConfig.ServerDateTime;
            PocketExecute("MM.GirLocStock.Adjust.Bp", new {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Adjust_Wh_Cd,
                LOC_CD = args.Select_Adjust_Loc_Cd,
                ITEM_CD = args.Select_Stock_Item_Cd,
                GIR_DT = dateTime.Date,
                GIR_TYPE_CD = args.Select_Adjust_GirType,
                ADJUST_QTY = args.Select_Adjust_Qty,
                CREATE_DTTM = dateTime,
                MODIFY_DTTM = dateTime,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = "KOR"
            });
        }

    }
}
