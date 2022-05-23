using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.MolItem;

namespace BPack.Pocket.App.MD.MolItem
{
    public class MolItemPocket : PocketBase
    {
        public MolItemPocket()
        {
            InitPocket("MolItem");
        }

        public void SaveItemListModel(ItemListModel itemListModel)
        {
            PocketExecute("MD.MolItem.ItemList.Save", GetParameters_StrapDisableParam(itemListModel));
        }

        public void SaveItemListModels(List<ItemListModel> itemListModels)
        {
            PocketExecute("MD.MolItem.ItemList.Save", GetParameters_StrapDisableParam(itemListModels) ); 
        }

        public string SelectItemCd(MolItemModelArgs args)
        {
            return PocketQuery<String>("MD.MolItem.ItemNm.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                ITEM_CD = args.Select_Item_Code
            }).FirstOrDefault();
        }

        public List<ItemListModel> SelectItemListModels(MolItemModelArgs args)
        {
            return PocketQuery<ItemListModel>("MD.MolItem.ItemList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                MOLD_CD = args.Select_Mold_Code
            });
        }

        public List<MoldListModel> SelectMoldListModels(MolItemModelArgs args)
        {
            return PocketQuery<MoldListModel>("MD.MolItem.MoldList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                MOLD_CD = args.Select_Main_Mold_Code,
                MOLD_NM = args.Select_Main_Mold_Name
            });
        }
    }
}
