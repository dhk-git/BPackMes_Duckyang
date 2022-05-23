using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.NcrHist
{
    public class NcrHistModelArgs : ModelArgsBase
    {
        public string Select_Main_CompCode { get; set; }
        public string Select_Main_PlantCode { get; set; }
        public string Select_Main_InspDateFrom { get; set; }
        public string Select_Main_InspDateTo { get; set; }
        public string Select_Main_ShiftCode { get; set; }
        public string Select_Main_ItemType { get; set; }
        public string Select_Main_WorkCenterCode { get; set; }
        public string Select_Main_ItemGroup1 { get; set; }
        public string Select_Main_ItemCode { get; set; }
        public string Select_Main_NcrStatus { get; set; }

        public string Select_Header_NcrNo { get; set; }
        public string Select_Header_NcrStatus { get; set; }
        public string Select_Detail_TrtFlag { get; set; }

    }
}
