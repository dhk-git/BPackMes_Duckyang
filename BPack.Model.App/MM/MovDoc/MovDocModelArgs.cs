using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.MovDoc
{
    public class MovDocModelArgs : ModelArgsBase
    {
        
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Plant_Cd { get; set; }

        public string Select_Mov_No { get; set; }
        public string Select_Plant_Cd { get; set; }

        public string Select_Mod_No { get; set; }
    }
}
