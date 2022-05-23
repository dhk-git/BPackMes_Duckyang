using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.GirInv
{
    public class GirInvModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Wh_Cd { get; set; }
        public string Select_Inv_No { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public string Select_Inv_Status { get; set; }
        public string Select_Wh_Cd { get; set; }
        public DateTime Select_Inv_Gir_Dt { get; set; }
        public string Select_Is_Include_After_Gir { get; set; }
    }
}
