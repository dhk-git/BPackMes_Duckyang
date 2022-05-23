using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.MebLot
{
    public class MebLotModelArgs : ModelArgsBase
    {
        public string Select_L_Pack_No { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_LPackNo { get; set; }
        public string Select_Main_MPackNo { get; set; }
        public string Select_Main_CaseNo { get; set; }
        public string Select_M_Pack_No { get; set; }
        public string Select_Main_Chk_All_MPack { get; set; }
        public string Select_Main_PartLotNo { get; set; }
    }
}
