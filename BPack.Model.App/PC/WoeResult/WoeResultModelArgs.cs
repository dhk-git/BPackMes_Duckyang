using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeResultModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Wc_Cd { get; set; }
        public string Select_Main_Wod_Status { get; set; }
        public string Select_Wo_No { get; set; }
        public string Select_Rst_No { get; set; }
        public int Select_Oper { get; set; }
        public string Select_Route_No { get; set; }
        public string Select_Item_Cd { get; set; }
        public string Select_Mat_Wh_Cd { get; set; }
        public string Select_Mat_Loc_Cd { get; set; }
        public string Select_Gd_Wh_Cd { get; set; }
        public string Select_Gd_Loc_Cd { get; set; }
        public string Scaned_Hu_No { get; set; }
        public string Select_Hu_No { get; set; }
        public string Select_Rst_Hu_Type { get; set; }
    }
}
