using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.SD.DlvOrder
{
    public class DlvOrderModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public string Select_Doh_No { get; set; }
        public object Select_Doh_Status { get; set; }
        public DateTime Select_Main_Plan_Start_Dt { get; set; }
        public DateTime Select_Main_Plan_End_Dt { get; set; }
        public string Select_Bp_Cd { get; set; }
        public string Select_Item_Cd { get; set; }
        public string Select_Dod_No { get; set; }
        public decimal Select_Dod_Qty { get; set; }
    }
}
