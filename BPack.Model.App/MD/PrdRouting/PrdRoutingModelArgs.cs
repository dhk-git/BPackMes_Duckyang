using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.PrdRouting
{
    public class PrdRoutingModelArgs : ModelArgsBase
    {
        // Main Condition
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Item_Code { get; set; }
        public string Select_Main_Route_No { get; set; }

        // RoutingList
        public string Select_RoutingList_Route_No { get; set; }
        public string Select_RoutingList_Item_Code { get; set; }

        // OperationList
        public int? Select_OperationList_Oper { get; set; }

        // Bom Main Condition
        public string Select_Bom_Main_Comp_Code { get; set; }
        public string Select_Bom_Main_Plant_Code { get; set; }
        public string Select_Bom_Main_Item_Code { get; set; }

        // BomHeaderList
        public string Select_Bom_BomHeaderList_Bom_No { get; set; }

        // BomDetailList

    }
}
