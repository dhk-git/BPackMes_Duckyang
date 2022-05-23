using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.GirLocStock
{
    public class GirLocStockModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Wh_Cd { get; set; }
        public string Select_Main_Loc_Cd { get; set; }
        public string Select_Main_Item_Type { get; set; }

        public string Select_Stock_Item_Cd { get; set; }
        public decimal Select_Item_Stock_Qty { get; set; }

        public Boolean TestPrint { get; set; }

        public string Select_Adjust_GirType { get; set; }
        public string Select_Adjust_Wh_Cd { get; set; }
        public string Select_Adjust_Loc_Cd { get; set; }
        public decimal Select_Adjust_Qty { get; set; }
    }
}
