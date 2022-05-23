using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.HumHuMaster
{
    public class HumHuMasterModelArgs : ModelArgsBase
    {
        public string Select_Main_Hu_Type { get; set; }
        public string Select_Main_Hu_No { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Comp_Cd { get; set; }
        public object Select_Hu_No { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Barcode_Text { get; set; }
    }
}
