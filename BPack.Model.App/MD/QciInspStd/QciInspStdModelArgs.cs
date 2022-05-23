using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.QciInspStd
{
    public class QciInspStdModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_Insp_Type { get; set; }
        public string Select_Main_Item_CD { get; set; }
        public string Select_Standard_Insp_Std_ID { get; set; }
        public string Select_Standard_Insp_type { get; set; }
        public string Select_Standard_Item_CD { get; set; }
        public int Select_Standard_Max_Revision { get; set; }
        public int? Select_Revision_Revision { get; set; }
        public string Select_Revision_FileGroupID { get; set; }


        //public string Select_Item_Item_Gr_1 { get; set; }
        //public string Select_Item_Item_Gr_2 { get; set; }
        //public string Select_Item_Item_Type { get; set; }
        //public string Select_Item_Item_Cd { get; set; }
        //public string Select_Item_Item_Nm { get; set; }
        
    }
}
