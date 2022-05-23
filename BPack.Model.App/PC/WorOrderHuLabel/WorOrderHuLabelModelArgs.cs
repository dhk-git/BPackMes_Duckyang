using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WorOrderHuLabel
{
    public class WorOrderHuLabelModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Wo_Dt { get; set; }
        public string Select_Main_Shift_Cd { get; set; }
        public string Select_Main_WorkCenter_Cd { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Wo_No { get; set; }

        public string Select_Pallet_Wo_No { get; set; }

        public string Select_Serial_Wo_No { get; set; }

    }
}
