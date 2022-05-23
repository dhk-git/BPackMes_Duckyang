using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeEssLot;

namespace BPack.Pocket.App.PC.WoeEssLot
{
    public class WoeEssLotPocket : PocketBase
    {
        public WoeEssLotPocket()
        {
            InitPocket("WoeEssLot");
        }
        public List<WoeEssTreeModel> SelectWoeEssTreeModels(WoeEssLotModelArgs args)
        {
            return PocketQuery<WoeEssTreeModel>("PC.WoeEssLot.Bom.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_dt,
                END_DT = args.Select_Main_End_dt,
                ITEM_GROUP_CD =args.Select_Main_Item_Group_cd,
                ITEM_CD=args.Select_Main_Item_cd,
                DIRECTION=args.Select_Main_direction,
                BARCODE=args.Select_Main_Barcode

            });
        }
    }
}
