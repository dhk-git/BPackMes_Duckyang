using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.NwtStatusInfo
{
    public class NwtStatusInfoModelArgs : ModelArgsBase
    {

        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_Wc_CD { get; set; }

        public string Select_Main_Start_Dt { get; set; }
        public string Select_Main_End_Dt { get; set; }

        //public string Select_Main_Shift_CD { get; set; }

        public DateTime Work_Dt { get; set; }

        public String Shift_Cd { get; set; }
    }
}
