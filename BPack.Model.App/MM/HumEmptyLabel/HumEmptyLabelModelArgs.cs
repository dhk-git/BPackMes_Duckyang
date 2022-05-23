using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.HumEmptyLabel
{
    public class HumEmptyLabelModelArgs : ModelArgsBase
    {
        public string Select_Main_Barcode_Kind { get; set; }
        public string Select_Main_Barcode_Full_No { get; set; }

        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_WorkCenter_CD { get; set; }
        public string Select_Main_Device_ID { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
    }
}
