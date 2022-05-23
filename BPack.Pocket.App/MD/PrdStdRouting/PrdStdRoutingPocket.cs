using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdStdRouting;

namespace BPack.Pocket.App.MD.PrdStdRouting
{
    public class PrdStdRoutingPocket : PocketBase
    {
        public PrdStdRoutingPocket()
        {
            InitPocket("PrdStdRouting");
        }

        public List<StdRoutingModel> SelectStdRoutingModels(PrdStdRoutingModelArgs args)
        {
            return PocketQuery<StdRoutingModel>("MD.PrdStdRouting.StdRoutingList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                ITEM_GR = args.Select_Main_Item_Gr
                
            });
        }
        public List<StdRoutingDetailModel> SelectStdRoutingDetailModels(PrdStdRoutingModelArgs args)
        {
            return PocketQuery<StdRoutingDetailModel>("MD.PrdStdRouting.StdRoutingDetailList.Select", new
            {
                STR_NO = args.Select_Str_No
            });
        }

        public void SaveStdRoutingModels(List<StdRoutingModel> stdRoutingModel)
        {
            PocketExecute("MD.PrdStdRouting.StdRoutingList.Save", GetParameters_StrapDisableParam(stdRoutingModel));
        }
        public void SaveStdRoutingDetailModels(List<StdRoutingDetailModel> stdRoutingDetailModel)
        {
            PocketExecute("MD.PrdStdRouting.StdRoutingDetailList.Save", GetParameters_StrapDisableParam(stdRoutingDetailModel));
        }

    }
}
