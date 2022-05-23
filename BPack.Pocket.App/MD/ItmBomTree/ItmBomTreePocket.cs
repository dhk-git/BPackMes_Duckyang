using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmBomTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.ItmBomTree
{
    public class ItmBomTreePocket : PocketBase
    {
        public ItmBomTreePocket()
        {
            InitPocket("ItmBomTree");
        }

        public List<ItemBomModel> SelectItemBomModels(ItmBomTreeModelArgs args)
        {
            return PocketQuery<ItemBomModel>("MD.ItmBomTree.ItemBomList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                ITEM_CD = args.Select_Main_Item_Code,
                ITEM_NM = args.Select_Main_Item_Name,
                APPLY_DT=args.Select_Main_Apply_Date
                //ITEM_GR_1 = args.Select_Main_Item_Group_1,
                //ALC_CD = args.Select_Main_ALC_Code
            });
        }

        public List<BomTreeModel> SelectBomTreeModels(ItmBomTreeModelArgs args)
        {
            return PocketQuery<BomTreeModel>("MD.ItmBomTree.BomListTree.Select", new
            {
                COMP_CD = args.Select_ItemBom_Comp_Code,
                PLANT_CD = args.Select_ItemBom_Plant_Code,
                ITEM_CD = args.Select_ItemBom_Item_Code,
                APPLY_DT = args.Select_Main_Apply_Date,
                BOM_NO  = args.Select_ItemBom_Bom_No
                //APPLY_DT = args.Select_ItemBom_Apply_Date

            });
        }

        public List<BomTreeReverseModel> SelectBomTreeReverseModels(ItmBomTreeModelArgs args)
        {
            return PocketQuery<BomTreeReverseModel>("MD.ItmBomTree.BomListTreeReverse.Select", new
            {
                COMP_CD = args.Select_BomTree_Comp_Code,
                PLANT_CD = args.Select_BomTree_Plant_Code,
                ITEM_CD = args.Select_BomTree_Item_Code,
                CHILD_ITEM_CD = args.Select_BomTree_Child_Item_Code,
                APPLY_DT = args.Select_BomTree_Apply_Date
            });
        }

    }
}
