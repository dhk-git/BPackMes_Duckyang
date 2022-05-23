using BPack.Common.Pocket;
using BPack.Model.App.MD.DlvJisTrtRule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.DlvJisTrtRule
{
    public class DlvJisTrtRulePocket : PocketBase
    {
        public DlvJisTrtRulePocket()
        {
            InitPocket("DlvJisTrtRule");
        }

        public List<DlvJisTrtRuleHeaderModel> SelectDlvJisTrtRuleHeaderModels(DlvJisTrtRuleModelArgs args)
        {
            return PocketQuery<DlvJisTrtRuleHeaderModel>("MD.DlvJisTrtRule.Header.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                DLV_PLC_CD = args.Select_Main_Dlv_Plc_Cd
            });
        }

        public List<DlvJisTrtRuleDetailModel> SelectDlvJisTrtRuleDetailModels(DlvJisTrtRuleModelArgs args)
        {
            return PocketQuery<DlvJisTrtRuleDetailModel>("MD.DlvJisTrtRule.Detail.Select", new
            {
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Plant_Cd,
                DLV_PLC_CD = args.Select_Dlv_Plc_Cd,
                TRT_RULE_ID = args.Select_Trt_Rule_ID
            });
        }

        public void SaveDlvJisTrtRuleHeaderModel(DlvJisTrtRuleHeaderModel dlvJisTrtRuleHeaderModel)
        {
            PocketExecute("MD.DlvJisTrtRule.Header.Save", dlvJisTrtRuleHeaderModel);
        }

        public void SaveDlvJisTrtRuleDetailModel(DlvJisTrtRuleDetailModel dlvJisTrtRuleDetailModel)
        {
            PocketExecute("MD.DlvJisTrtRule.Detail.Save", dlvJisTrtRuleDetailModel);
        }

        public void SaveDlvJisTrtRuleDetailModels(List<DlvJisTrtRuleDetailModel> dlvJisTrtRuleDetailModels)
        {
            PocketExecute("MD.DlvJisTrtRule.Detail.Save", dlvJisTrtRuleDetailModels);
        }
    }
}
