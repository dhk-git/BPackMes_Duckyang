using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.QchFmlRead
{
    public class QchFmlReadModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_WorkOrderDate_From { get; set; }
        public string Select_Main_WorkOrderDate_To { get; set; }
        public string Select_Main_Shift_CD { get; set; }
        public string Select_Main_WorkCenter_CD { get; set; }
        public string Select_Main_ItemGroup_CD { get; set; }
        public string Select_Main_Item_CD { get; set; }
        public string Select_Main_Insp_Sub_Type_F { get; set; }
        public string Select_Main_Insp_Sub_Type_M { get; set; }
        public string Select_Main_Insp_Sub_Type_L { get; set; }
        public string Select_Main_Insp_Judge { get; set; }
        public string Select_Insp_No { get; set; }
    }
}
