using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.NcrRegJudge;

namespace BPack.Pocket.App.QC.NcrRegJudge
{
    public class NcrRegJudgePocket : PocketBase
    {
        public NcrRegJudgePocket()
        {
            InitPocket("NcrRegJudge");
        }
        public List<NcrRegJudgHeaderModel> SelectNcrRegJudgHeaderModels(NcrRegJudgeModelArgs args)
        {
            return PocketQuery<NcrRegJudgHeaderModel>("QC.NcrRegJudge.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_Cd,
                    PLANT_CD = args.Select_Main_Plant_Cd,
                    START_DT = args.Select_Main_Start_dt,
                    END_DT = args.Select_Main_End_dt,
                    JUDGE_RESULT = args.Select_Main_Judge_Result
                });
        }

        public List<NcrRegJudgeDetailModel> SelectNcrRegJudgDetailModels(NcrRegJudgeModelArgs args)
        {
            return PocketQuery<NcrRegJudgeDetailModel>("QC.NcrRegJudge.Detail.Select",
              new
              {
                  COMP_CD = args.Select_Main_Comp_Cd,
                  PLANT_CD = args.Select_Main_Plant_Cd,
                  NCD_NO_KEY = args.NCD_NO_KEY
              });
        }
        public void SaveNcrRegJudgDetailModels(List<NcrRegJudgeDetailModel> models)
        {
            PocketExecute("QC.NcrRegJudge.Detail.Save", GetParameters_StrapDisableParam(models));
        }
        public void SaveNcrRegJudgDetailModel(NcrRegJudgeDetailModel model)
        {
            PocketExecute("QC.NcrRegJudge.Detail.Save", GetParameters_StrapDisableParam(model));
        }


        public void SaveNcrRegJudgConfirmModel(List<NcrRegJudgeConfirmModel> model)
        {
            PocketExecute("QC.NcrRegJudge.Confirm.BP", GetParameters_StrapDisableParam(model));
        }

    }
}
