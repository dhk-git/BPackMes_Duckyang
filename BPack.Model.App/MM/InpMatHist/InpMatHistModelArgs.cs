using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.InpMatHist
{
    public class InpMatHistModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Bp_Cd { get; set; }
        public string Select_Main_Bp_Nm { get; set; }

        public string Select_Item_Cd { get; set; }
        public string Select_Bp_Cd { get; set; }

    }
}
