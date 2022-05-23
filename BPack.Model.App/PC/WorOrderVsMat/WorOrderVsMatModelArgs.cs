using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WorOrderVsMat
{
    public class WorOrderVsMatModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Wo_Dt { get; set; }
        public string Select_Main_Wc_Cd { get; set; }
        public string Select_WorkOrder_WoNoList { get; set; }
        public string Select_Material_LocationList { get; set; }

    }
}
