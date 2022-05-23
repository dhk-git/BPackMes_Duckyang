using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.DlvJisTrtRule
{
    public class DlvJisTrtRuleModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Dlv_Plc_Cd { get; set; }
        public string Select_Comp_Cd { get; set; }
        public string Select_Plant_Cd { get; set; }
        public string Select_Dlv_Plc_Cd { get; set; }
        public string Select_Trt_Rule_ID { get; set; }
    }
}
