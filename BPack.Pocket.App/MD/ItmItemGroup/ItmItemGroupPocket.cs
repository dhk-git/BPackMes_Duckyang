using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmItemGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.ItmItemGroup
{
    public class ItmItemGroupPocket : PocketBase
    {
        public ItmItemGroupPocket()
        {
            InitPocket("ItmItemGroup");
        }

        public void SaveItemGroupModel(ItemGroupModel itemGroupModel)
        {
            PocketExecute("MD.ItmItemGroup.ItemGroupList.Save", itemGroupModel);
        }

        public List<ItemGroupModel> SelectItemGroupModels(ItmItemGroupModelArgs args)
        {
            return PocketQuery<ItemGroupModel>("MD.ItmItemGroup.ItemGroupList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code
            });
        }
    }
}
