using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.SD.DlvPlan
{
    public class DlvPlanModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_End_Dt { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public bool Select_Main_Checked_Calc { get; set; }
    }
}
