using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.QchDlvRead
{
    public class QchDlvReadModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_InspDate_From { get; set; }
        public string Select_Main_InspDate_To { get; set; }
        public string Select_Main_ItemGroup_CD { get; set; }
        public string Select_Main_Item_CD { get; set; }
        public string Select_Main_Insp_Judge { get; set; }
        public string Select_Header_Insp_No { get; set; }
    }
}
