using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmItemInfo;
using BPack.Model.App.MD.ItmItemType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.ItmItemInfo
{
    public class ItmItemInfoPocket : PocketBase
    {
        public ItmItemInfoPocket()
        {
            InitPocket("ItmItemInfo");
        }

        public void SaveItemConvModel(ItemConvModel itemConvModel)
        {
            PocketExecute("MD.ItmItemInfo.ConvFactorList.Save", GetParameters_StrapDisableParam(itemConvModel));
        }

        public void SaveItemInfoModel(ItemInfoModel itemInfoModel)
        {
            PocketExecute("MD.ItmItemInfo.ItemList.Save", GetParameters_StrapDisableParam(itemInfoModel));
        }
        public void SaveItemInfoModels(List<ItemInfoModel> itemInfoModels)
        {
            PocketExecute("MD.ItmItemInfo.ItemList.Save", GetParameters_StrapDisableParam(itemInfoModels));
        }

        public List<ItemConvModel> SelectItemConvModels(ItmItemInfoModelArgs args)
        {
            return PocketQuery<ItemConvModel>("MD.ItmItemInfo.ConvFactorList.Select", new {
                COMP_CD = args.Select_Comp_Code,
                PLANT_CD = args.Select_Plant_Code,
                ITEM_CD = args.Select_Item_Code,
                CONV_CD = args.Select_Conv_Code
            });
        }

        public List<ItemInfoModel> SelectItemInfoModels(ItmItemInfoModelArgs args)
        {
            return PocketQuery<ItemInfoModel>("MD.ItmItemInfo.ItemList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                ITEM_CD = args.Select_Main_Item_Code,
                ITEM_NM = args.Select_Main_Item_Name,
               // MAIN_MODEL = args.Select_Main_Main_Model,
               // ITEM_TYPE_CLS = args.Select_Main_Item_Type_Class,
                ITEM_GR_1 = args.Select_Main_Item_Group1,
                ITEM_TYPE = args.Select_Main_Item_Type,
               // ALC_CD = args.Select_Main_Alc_Cd
            });
        }
           public List<ItemTypeItemModel> SelectItemInfoColumnsModels(ItemInfoModel args)
        {
            return PocketQuery<ItemTypeItemModel>("MD.ItmItemInfo.ItemList.ItemTypeVisible.Select", new
            {
                COMP_CD = args.COMP_CD,
                ITEM_TYPE_CD = args.ITEM_TYPE_CD

            });
        }
    }
}
