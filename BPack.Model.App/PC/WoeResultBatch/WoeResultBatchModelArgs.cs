using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WoeResultBatch
{
    public class WoeResultBatchModelArgs : ModelArgsBase
    {
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Wc_Cd { get; set; }
        public string Select_Wo_No { get; set; }
        public string Select_Comp_Cd { get; set; }
        public string Select_Route_No { get; set; }
    }
}
