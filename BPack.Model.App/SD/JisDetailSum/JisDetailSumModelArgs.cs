using BPack.Common.Model;
using System;

namespace BPack.Model.App.SD.JisDetailSum
{
    public class JisDetailSumModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Dt_Opt { get; set; }
        public DateTime Select_Main_Dt_From { get; set; }
        public DateTime Select_Main_Dt_To { get; set; }
        public string Select_Main_Dlv_Plc_Cd { get; set; }
        public string Select_Main_Alc_Type { get; set; }
        public string Select_Main_Alc_Cd { get; set; }
        public string Select_Main_Item_Type { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
    }
}
