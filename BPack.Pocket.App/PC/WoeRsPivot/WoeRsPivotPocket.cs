using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeRsPivot;

namespace BPack.Pocket.App.PC.WoeRsPivot
{
    public class WoeRsPivotPocket : PocketBase
    {
        public WoeRsPivotPocket()
        {
            InitPocket("WoeRsPivot");
        }

        public List<RsPivotModel> SelectRsPivotModels(WoeRsPivotModelArgs args)
        {
            return PocketQuery<RsPivotModel>("PC.WoeRsPivot.Hours.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                START_DT = args.START_DT,
                END_DT = args.END_DT,
                WC_CD = args.WC_CD,
                ITEM_CD = args.ITEM_CD,
                ITEM_NM=args.ITEM_NM,
                ITEM_GR_1 = args.ITEM_GR_1,
                ITEM_TYPE = args.ITEM_TYPE,
                SHIFT_GROUP_CD = args.SHIFT_GROUP_CD,
                SHIFT_CD=args.SHIFT_CD
            });
        }
        public List<RsBatchModel> SelectRsBatchModels(WoeRsPivotModelArgs args)
        {
            return PocketQuery<RsBatchModel>("PC.WoeRsPivot.Batch.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                START_DT = args.START_DT,
                END_DT = args.END_DT,
                WC_CD = args.WC_CD,
                ITEM_CD = args.ITEM_CD,
                ITEM_NM = args.ITEM_NM,
                ITEM_GR_1 = args.ITEM_GR_1,
                ITEM_TYPE = args.ITEM_TYPE,
                SHIFT_GROUP_CD = args.SHIFT_GROUP_CD,
                SHIFT_CD = args.SHIFT_CD
            });
        }
    }
}
