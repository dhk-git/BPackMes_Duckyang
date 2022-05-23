using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvConfirm2ModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Bp_Cd { get; set; }
        public string Select_Drh_No { get; set; }
        public string Select_Drh_Status { get; set; }
        public string Select_Cust_Doh_No { get; set; }
        public string Select_Drd_No { get; set; }

        //2021.12.28 정수교 추가
        public string Select_MIN_GR { get; set; }
        public string Select_MAX_GR { get; set; }

        public string Select_Doh_No { get; set; }

        public string Select_Item_cd { get; set; }

        public string Select_Pack_Date { get; set; }

        public string Select_Ship_Date { get; set; }
    }
}
