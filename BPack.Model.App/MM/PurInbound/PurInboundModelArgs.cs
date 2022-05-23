using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.PurInbound
{
    public class PurInboundModelArgs : ModelArgsBase
    {
        public string Select_Comp_Cd { get; set; }
        public string Select_Extra_Plant_Cd { get; set; }
        public string Select_Main_Bp_Cd { get; set; }
        public string Select_Main_Pih_No { get; set; }
        public string Select_Pih_No { get; set; }
        public string Select_Pid_No { get; set; }

        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public DateTime Select_Main_PackingList_Start_Dt { get; set; }
        public DateTime Select_Main_PackingList_End_Dt { get; set; }

        public string Select_Pih_Status { get; set; }
    }
}
