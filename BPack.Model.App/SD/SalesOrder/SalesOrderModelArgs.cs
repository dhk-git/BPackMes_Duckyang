using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.SD.SalesOrder
{
    public class SalesOrderModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Sor_No { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Sor_Status { get; set; }
        public string Select_Bp_Cd { get; set; }
        public string Select_Main_Sor_No { get; set; }
        public string Select_Main_Custom_Po_No { get; set; }
    }
}
