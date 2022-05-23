using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdWcOper;

namespace BPack.Pocket.App.MD.PrdWcOper
{
    public class PrdWcOperPocket : PocketBase
    {
        public PrdWcOperPocket()
        {
            InitPocket("PrdWcOper");
        }

        public void SavePrdWcOperOperatorModel(PrdWcOperOperatorModel model)
        {
            PocketExecute("MD.PrdWcOper.Operator.Save", GetParameters_StrapDisableParam(model));
        }

        public void SavePrdWcOperOperatorModels(List<PrdWcOperOperatorModel> models)
        {
            PocketExecute("MD.PrdWcOper.Operator.Save", GetParameters_StrapDisableParam(models));
        }

        public List<PrdWcOperWorkCenterModel> SelectPrdWcOperWorkCenterModels(PrdWcOperModelArgs args)
        {
            return PocketQuery<PrdWcOperWorkCenterModel>("MD.PrdWcOper.WorkCenter.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }

        public List<PrdWcOperOperatorModel> SelectPrdWcOperOperatorModels(PrdWcOperModelArgs args)
        {
            return PocketQuery<PrdWcOperOperatorModel>("MD.PrdWcOper.Operator.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                WC_CD = args.Select_WorkCenter_Code
            });
        }
    }
}
