using BPack.Common.Model;
using System;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Req_Dt_From { get; set; }
        public DateTime Select_Main_Req_Dt_To { get; set; }
        public string Select_Main_Dlv_Plc_Cd { get; set; }
        public string Select_Main_Car_No { get; set; }
        public string Select_Main_Doh_No { get; set; }
        public string Select_Main_Dlv_Status { get; set; }

        public string Select_Dlv_Type { get; set; }
        public string Select_Cp_No { get; set; }
        public int? Select_Cp_Seq { get; set; }
        public string Select_Doh_No { get; set; }
        public int? Select_Load_Seq { get; set; }
        public string Select_Drt_No { get; set; }
        public string Select_Dod_No { get; set; }
    }
}
