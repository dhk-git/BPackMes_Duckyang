using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.GirEtc
{
    public class GirEtcModelArgs : ModelArgsBase
    {
        public string Select_Etg_No { get; set; }
        public string Select_Main_WH_CD { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Etg_Git_Status { get; set; }
    }
}
