using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WoeResultPivot
{
    public class WoeResultPivotModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Shift_Cd { get; set; }
        public string Select_Main_Wc_Cd { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public string Select_Main_Alc_Cd { get; set; }
        public string Select_Main_Item_Type_Cd { get; set; }
    }
}
