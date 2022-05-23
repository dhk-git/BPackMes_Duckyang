using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdWorkCenter;

namespace BPack.Pocket.App.MD.PrdWorkCenter
{
    public class PrdWorkCenterPocket : PocketBase
    {
        public PrdWorkCenterPocket()
        {
            InitPocket("PrdWorkCenter");
        }

        public void SaveItemModel(WorkCenterItemModel workCenterItemModel)
        {
            PocketExecute("MD.PrdWorkCenter.WorkCenterItem.Save", GetParameters_StrapDisableParam(workCenterItemModel));
        }
        public void SaveItemModels(List<WorkCenterItemModel> workCenterItemModels)
        {
            PocketExecute("MD.PrdWorkCenter.WorkCenterItem.Save", GetParameters_StrapDisableParam(workCenterItemModels));
        }

        public void SaveOPModel(WorkCenterOPModel workCenterOPModel)
        {
            PocketExecute("MD.PrdWorkCenter.WorkCenterOP.Save", GetParameters_StrapDisableParam(workCenterOPModel));
        }
        public void SaveOPModels(List<WorkCenterOPModel> workCenterOPModels)
        {
            PocketExecute("MD.PrdWorkCenter.WorkCenterOP.Save", GetParameters_StrapDisableParam(workCenterOPModels));
        }

        public void SaveWorkCenterModel(WorkCenterModel workCenterModel)
        {
            PocketExecute("MD.PrdWorkCenter.WorkCenter.Save", GetParameters_StrapDisableParam(workCenterModel));
        }

        public void SaveWorkCenterModels(List<WorkCenterModel> workCenterModels)
        {
            PocketExecute("MD.PrdWorkCenter.WorkCenter.Save", GetParameters_StrapDisableParam(workCenterModels));
        }

        public void SaveEquipModel(EquipModel equipModel)
        {
            PocketExecute("MD.PrdWorkCenter.Equip.Save", GetParameters_StrapDisableParam(equipModel));
        }

        public void SaveEquipModels(List<EquipModel> equipModels)
        {
            PocketExecute("MD.PrdWorkCenter.Equip.Save", GetParameters_StrapDisableParam(equipModels));
        }

        public List<PlantModel> SelectPlantModels(PrdWorkCenterModelArgs args)
        {
            return PocketQuery<PlantModel>("MD.PrdWorkCenter.Plant.Select", new { COMP_CD = args.Select_Main_Comp_CD });
        }

        public List<WorkCenterModel> SelectWorkCenterModels(PrdWorkCenterModelArgs args)
        {
            return PocketQuery<WorkCenterModel>("MD.PrdWorkCenter.WorkCenter.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD
                });
        }

        public List<WorkCenterItemModel> SelectItemModels(PrdWorkCenterModelArgs args)
        {
            return PocketQuery<WorkCenterItemModel>("MD.PrdWorkCenter.Item.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    WC_CD = args.Select_WorkCenter_WC_CD
                });
        }
        public List<WorkCenterOPModel> SelectOPModels(PrdWorkCenterModelArgs args)
        {
            return PocketQuery<WorkCenterOPModel>("MD.PrdWorkCenter.OP.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    WC_CD = args.Select_WorkCenter_WC_CD
                });
        }

        public List<EquipModel> SelectEquipModels(PrdWorkCenterModelArgs args)
        {
            return PocketQuery<EquipModel>("MD.PrdWorkCenter.Equip.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    WC_CD = args.Select_WorkCenter_WC_CD
                });
        }

       
    }
}
