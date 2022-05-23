using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.GirClose
{
    public class GirCloseModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime? Select_Close_Dt { get; set; }
        public string Select_Wh_Cd { get; set; }
        public string Select_Gir_Close_Status { get; set; }
    }
}
