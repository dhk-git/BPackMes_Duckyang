using BPack.Common.Pocket;
using BPack.Model.App.MD.BpaInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.BpaInfo
{
    public class BpaInfoPocket : PocketBase
    {
        public BpaInfoPocket()
        {
            InitPocket("BpaInfo");
        }

        public void SaveBparModel(BparModel bparModel)
        {
            PocketExecute("MES.MD.BPA.BPA_CUD", bparModel);
        }

        public void SaveContModel(ContModel contModel)
        {
            PocketExecute("MES.MD.BPA.CONT_CUD", contModel);
        }

        public void SaveContMode(List<ContModel> contModels)
        {
            PocketExecute("MES.MD.BPA.CONT_CUD", contModels);
        }

        public List<BparModel> SelectBparModels(BpaInfoModelArgs args)
        {
            return PocketQuery<BparModel>("MES.MD.BPA.BPA_R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                BP_CD   = args.Select_Main_Bp_Cd,
                BP_NM   = args.Select_Main_Bp_Nm
            });
        }

        public List<ContModel> SelectContModels(BpaInfoModelArgs args)
        {
            return PocketQuery<ContModel>("MES.MD.BPA.CONT_R", new
            {
                COMP_CD = args.Select_Comp_Cd,
                BP_CD = args.Select_Bp_Cd
            });
        }

        public void SaveContModels(List<ContModel> contModels)
        {
            PocketExecute("MES.MD.BPA.CONT_CUD", contModels);
        }
    }
}
