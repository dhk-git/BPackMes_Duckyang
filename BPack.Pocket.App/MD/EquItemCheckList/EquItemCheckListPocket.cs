using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.EquItemCheckList;

namespace BPack.Pocket.App.MD.EquItemCheckList
{
    public class EquItemCheckListPocket : PocketBase
    {
        public EquItemCheckListPocket()
        {
            InitPocket("EquItemCheckList");
        }

        public void SaveItemModels(List<EquItemCheckListItemModel> models)
        {
            PocketExecute("MD.EquItemCheckList.Item.Save", GetParameters_StrapDisableParam(models));
        }

        public void SaveCheckListModels(List<EquItemCheckListCheckListModel> models)
        {
            PocketExecute("MD.EquItemCheckList.CheckList.Save", GetParameters_StrapDisableParam(models));
        }

        public List<EquItemCheckListEquipModel> SelectEquipModels(EquItemCheckListModelArgs args)
        {
            return PocketQuery<EquItemCheckListEquipModel>("MD.EquItemCheckList.Equip.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }

        public List<EquItemCheckListItemModel> SelectItemModels(EquItemCheckListModelArgs args)
        {
            return PocketQuery<EquItemCheckListItemModel>("MD.EquItemCheckList.Item.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                EQUIP_CD = args.Select_Equip_Code
            });
        }

        public List<EquItemCheckListCheckListModel> SelectCheckListModels(EquItemCheckListModelArgs args)
        {
            return PocketQuery<EquItemCheckListCheckListModel>("MD.EquItemCheckList.CheckList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                EQUIP_CD = args.Select_Equip_Code,
                ITEM_CD = args.Select_Item_Code
            });
        }

    }
}
