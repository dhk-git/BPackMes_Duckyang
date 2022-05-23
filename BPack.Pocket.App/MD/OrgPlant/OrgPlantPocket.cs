using BPack.Common.Pocket;
using BPack.Model.App.MD.OrgPlant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.OrgPlant
{
    public class OrgPlantPocket : PocketBase
    {
        public OrgPlantPocket()
        {
            InitPocket("orgPlant");
        }

        public void SavePlantModel(PlantModel plantModel)
        {
            PocketExecute("MD.OrgPlant.PlantList.Save", GetParameters_StrapDisableParam(plantModel));
        }

        public List<CompModel> SelectCompModels(OrgPlantModelArgs args)
        {
            return PocketQuery<CompModel>("MD.OrgPlant.CompList.Select", new
            {
            });
        }

        public List<PlantModel> SelectPlantModels(OrgPlantModelArgs args)
        {
            return PocketQuery<PlantModel>("MD.OrgPlant.PlantList.Select", new
            {
                COMP_CD = args.Select_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                PLANT_NM = args.Select_Main_Plant_Name
            });
        }

        public List<PlantWkModel> SelectPlantWKModels(OrgPlantModelArgs args)
        {
            return PocketQuery<PlantWkModel>("MD.OrgPlant.PlantWKList.Select", new
            {
                COMP_CD = args.Select_Comp_Code,
                PLANT_CD = args.Select_Plant_Code
            });
        }

        public void SavePlantWKModels(List<PlantWkModel> plantWkModels)
        {
            PocketExecute("MD.OrgPlant.PlantWKList.Save", GetParameters_StrapDisableParam(plantWkModels));
        }
    }
}
