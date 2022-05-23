using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.GirTotalGirType
{
    public class GirTotalGirTypeModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime? Select_Main_From_Dt { get; set; }
        public DateTime? Select_Main_To_Dt { get; set; }

        public string Select_Main_Wh_Cd_List { get; set; }
        public string Select_Main_Item_Type { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Group_1 { get; set; }
        public string Select_Main_Item_Group_3 { get; set; }
    }
}
