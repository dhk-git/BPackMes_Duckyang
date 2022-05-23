using BPack.Common.Pocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.BpaGate
{
    public class BpaGatePocket : PocketBase
    {
        public BpaGatePocket()
        {
            InitPocket("BpaGate");
        }

        public List<Model.App.MD.BpaGate.BparModel> SelectBparModels(Model.App.MD.BpaGate.BpaGateModelArgs args)
        {
            return PocketQuery<Model.App.MD.BpaGate.BparModel>("MES.MD.BPA.BPA_R2", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                BP_CD = "",
                BP_NM = ""
            });
        }

        public List<Model.App.MD.BpaGate.GateModel> SelectGateModels(Model.App.MD.BpaGate.BpaGateModelArgs args)
        {
            return PocketQuery<Model.App.MD.BpaGate.GateModel>("MES.MD.BPA.GATE_R", new
            {
                COMP_CD = args.Select_Comp_Cd,
                BP_CD = args.Select_Bp_Cd
            });
        }

        public void SaveGateModel(Model.App.MD.BpaGate.GateModel gateModel)
        {
            PocketExecute("MES.MD.BPA.GATE_CUD", gateModel);
        }

        public void SaveGateModels(List<Model.App.MD.BpaGate.GateModel> gateModels)
        {
            PocketExecute("MES.MD.BPA.GATE_CUD", gateModels);
        }

    }
}
