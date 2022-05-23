using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PO.PurOrder
{
    public class PurOrderModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Bp_Cd { get; set; }
        public string Select_Main_Poh_No { get; set; }
        public string Select_Poh_No { get; set; }
        public string Select_Poh_Status { get; set; }
        public string Select_Main_Poh_Inter_Cls { get; set; }
        public DateTime Select_Main_Por_Start_Dt { get; set; }
        public DateTime Select_Main_Por_End_Dt { get; set; }
        public string Select_Bp_Cd { get; set; }
    } 
}
