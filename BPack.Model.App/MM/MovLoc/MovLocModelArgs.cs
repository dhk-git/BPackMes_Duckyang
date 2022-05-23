using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.MovLoc
{
    public class MovLocModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_cd { get; set; }
        public string Select_Main_Plant_cd { get; set; }
        public string Select_Main_MOV_NO { get; set; }
        public string Select_Main_FROM_WH_CD { get; set; }
        public string Select_Main_TO_WH_CD { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }

        public string MOV_STATUS { get; set; }
    }
}
