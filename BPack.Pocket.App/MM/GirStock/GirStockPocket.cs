using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirStock;

namespace BPack.Pocket.App.MM.GirStock
{
    public class GirStockPocket : PocketBase
    {
        public GirStockPocket()
        {
            InitPocket("GirStock");
        }

        public List<GirModel> SelectGirModels(GirStockModelArgs args)
        {
            return PocketQuery<GirModel>("MM.GirStock.GirList.Select", new {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Main_Wh_Cd,
                ITEM_CD = args.Select_Stock_Item_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt
            });
        }

        public List<StockModel> SelectStockModels(GirStockModelArgs args)
        {
            return PocketQuery<StockModel>("MM.GirStock.StockList.Select", new {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Main_Wh_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_TYPE = args.Select_Main_Item_Type,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm
            });
        }

        public List<WhHuModel> SelectWhHuModels(GirStockModelArgs args)
        {
            return PocketQuery<WhHuModel>("MM.GirStock.WhHuList.Select", new {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Main_Wh_Cd,
                ITEM_CD = args.Select_Stock_Item_Cd
            });
        }
    }
}
