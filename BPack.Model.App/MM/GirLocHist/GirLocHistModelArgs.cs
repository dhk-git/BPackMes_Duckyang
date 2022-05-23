using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.GirLocHist
{
    public class GirLocHistModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }

        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Wh_Cd { get; set; }
        public string Select_Main_Item_Type_Cd { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public string Select_Main_BarcodeText { get; set; }

        public string Select_Main_LocOutType { get; set; }

        public string Select_Main_LocInType { get; set; }

    }
}
