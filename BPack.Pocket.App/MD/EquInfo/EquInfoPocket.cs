using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.EquInfo;

namespace BPack.Pocket.App.MD.EquInfo
{
    public class EquInfoPocket : PocketBase
    {
        public EquInfoPocket()
        {
            InitPocket("EquInfo");
        }

        public void SaveCheckModel(EquInfoCheckModel checkModel)
        {
            PocketExecute("MD.EquInfo.CheckList.Save", GetParameters_StrapDisableParam(checkModel));
        }

        public void SaveCheckModels(List<EquInfoCheckModel> checkModels)
        {
            PocketExecute("MD.EquInfo.CheckList.Save", GetParameters_StrapDisableParam(checkModels));
        }

        public void SaveEquModel(EquInfoEquipModel equModel)
        {
            PocketExecute("MD.EquInfo.EquList.Save", GetParameters_StrapDisableParam(equModel));
        }

        public void SaveEquModels(List<EquInfoEquipModel> equModels)
        {
            PocketExecute("MD.EquInfo.EquList.Save", GetParameters_StrapDisableParam(equModels));
        }

        public List<EquInfoCheckModel> SelectCheckModels(EquInfoModelArgs args)
        {
            return PocketQuery<EquInfoCheckModel>("MD.EquInfo.CheckList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                EQUIP_CD = args.Select_Equip_Code
            });
        }

        public List<EquInfoEquipModel> SelectEquModels(EquInfoModelArgs args)
        {
            return PocketQuery<EquInfoEquipModel>("MD.EquInfo.EquList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }
    }
}
