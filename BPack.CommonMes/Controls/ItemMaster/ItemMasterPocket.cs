using BPack.Common.Pocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.ItemMaster
{
    public class ItemMasterPocket : PocketBase
    {
        public ItemMasterPocket()
        {
            InitPocket("MasterDataControls");
        }

        public List<ItemMasterModel> SelectItemMasterModels(ItemMasterModelArgs args)
        {
            return PocketQuery<ItemMasterModel>("MasterDataControls.Item.ItemList.Select", new
            {
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Plant_Cd,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                ITEM_GR_2 = args.Select_Main_Item_Gr_2,
                ITEM_TYPE = args.Select_Main_Item_Type,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
            });
        }

        public ItemMasterModel SelectItemMasterModel(ItemMasterModelArgs args)
        {
            return PocketQuery<ItemMasterModel>("MasterDataControls.Item.Item.Select", new
            {
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Plant_Cd,
                ITEM_CD = args.Select_Item_Cd
            }).SingleOrDefault();
        }

    }
}
