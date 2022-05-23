using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.DlvGateLine;

namespace BPack.Pocket.App.MD.DlvGateLine
{
    public class DlvGateLinePocket : PocketBase
    {
        public DlvGateLinePocket()
        {
            InitPocket("DlvGateLine");
        }

        public void SaveGateModel(DlvGateLineGateModel model)
        {
            PocketExecute("MD.DlvGateLine.Gate.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveGateModels(List<DlvGateLineGateModel> models)
        {
            PocketExecute("MD.DlvGateLine.Gate.Save", GetParameters_StrapDisableParam(models));
        }

        public List<DlvGateLineGateModel> SelectGateModels(DlvGateLineModelArgs args)
        {
            return PocketQuery<DlvGateLineGateModel>("MD.DlvGateLine.Gate.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_Code,
                    PLANT_CD = args.Select_Main_Plant_Code,
                    GATE_CD = args.Select_Partners_Gate_Code
                });
        }

        public List<DlvGateLinePartnerModel> SelectPartnerModels(DlvGateLineModelArgs args)
        {
            return PocketQuery<DlvGateLinePartnerModel>("MD.DlvGateLine.Partner.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_Code
                });
        }
    }
}
