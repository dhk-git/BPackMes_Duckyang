using BPack.Common.Pocket;
using BPack.Model.App.MD.GirWareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.GirWareHouse
{
    public class GirWareHousePocket : PocketBase
    {
        public GirWareHousePocket()
        {
            InitPocket("GirWareHouse");
        }

        public void SaveWareHouseModel(WareHouseModel wareHouseModel)
        {
            PocketExecute("MD.GirWareHouse.WhList.Save", wareHouseModel);
        }

        public void SaveLocationModel(LocationModel locationModel)
        {
            PocketExecute("MD.GirWareHouse.LocList.Save", locationModel);
        }

        public List<WareHouseModel> SelectWareHouseModels(GirWareHouseModelArgs args)
        {
            return PocketQuery<WareHouseModel>("MD.GirWareHouse.WhList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }

        public List<LocationModel> SelectLocationModels(GirWareHouseModelArgs args)
        {
            return PocketQuery<LocationModel>("MD.GirWareHouse.LocList.Select", new
            {
                COMP_CD = args.Select_Comp_Code,
                PLANT_CD = args.Select_Plant_Code,
                WH_CD = args.Select_WareHouse_Code
            });
        }

        public void SaveLocationModels(List<LocationModel> locationModels)
        {
            PocketExecute("MD.GirWareHouse.LocList.Save", locationModels);
        }
    }
}
