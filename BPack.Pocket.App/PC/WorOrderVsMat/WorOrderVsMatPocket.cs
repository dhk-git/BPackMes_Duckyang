using System.Collections.Generic;
using System.Linq;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WorOrderVsMat;

namespace BPack.Pocket.App.PC.WorOrderVsMat
{
    public class WorOrderVsMatPocket : PocketBase
    {
        public WorOrderVsMatPocket()
        {
            InitPocket("WorOrderVsMat");
        }

        public List<WorOrderVsMatWorkOrderModel> SelectWorkOrderModels(WorOrderVsMatModelArgs args)
        {
            return PocketQuery<WorOrderVsMatWorkOrderModel>("PC.WorOrderVsMat.WorkOrder.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                WO_DT = args.Select_Main_Wo_Dt,
            });
        }

        public List<WorOrderVsMatMaterialModel> SelectMaterialModels(WorOrderVsMatModelArgs args)
        {
            return PocketQuery<WorOrderVsMatMaterialModel>("PC.WorOrderVsMat.Material.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WO_DT = args.Select_Main_Wo_Dt,
                WO_NO_LIST = args.Select_WorkOrder_WoNoList,
                LOC_CD_LIST = args.Select_Material_LocationList
            });
        }
    }
}
