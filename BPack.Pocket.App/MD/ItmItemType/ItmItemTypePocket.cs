using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmItemType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.ItmItemType
{
    public class ItmItemTypePocket : PocketBase
    {
        public ItmItemTypePocket()
        {
            InitPocket("ItmItemType");
        }

        public void SaveItemTypeModel(ItemTypeModel itemTypeModel)
        {
            PocketExecute("MD.ItmItemType.TypeList.Save", itemTypeModel);
        }

        public List<ItemTypeModel> SelectItemTypeModels(ItmItemTypeModelArgs args)
        {
            return PocketQuery<ItemTypeModel>("MD.ItmItemType.TypeList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code
            });
        }
        public List<ItemTypeItemModel> SelectItemTypeItemModels(ItmItemTypeModelArgs args)
        {
            return PocketQuery<ItemTypeItemModel>("MD.ItmItemType.TypeItemList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code
                ,ITEM_TYPE_CD = args.Select_ITEM_TYPE_CD
            });

        }
        public void SaveItemTypeItemModel(ItemTypeItemModel itemTypeModel)
        {
            PocketExecute("MD.ItmItemType.TypeItemList.Save", itemTypeModel);
        }

        public void SaveItemTypeItemModels(List<ItemTypeItemModel> itemTypeModels)
        {
            PocketExecute("MD.ItmItemType.TypeItemList.Save", GetParameters_StrapDisableParam(itemTypeModels));
        }
        public void SaveItemTypeItemDefaultModel(ItemTypeModel itemTypeModel)
        {
            PocketExecute("MD.ItmItemType.TypeItemListDefault.Save", itemTypeModel);
        }
    }
}
