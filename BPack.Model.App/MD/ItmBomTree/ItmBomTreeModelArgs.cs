using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.ItmBomTree
{
    public class ItmBomTreeModelArgs : ModelArgsBase
    {
        // ItmBomTreeMain
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Item_Code { get; set; }
        public string Select_Main_Item_Name { get; set; }
        public DateTime Select_Main_Apply_Date { get; set; }
        public string Select_ItemBom_Bom_No { get; set; }


        // ItemBomList
        public string Select_ItemBom_Comp_Code { get; set; }
        public string Select_ItemBom_Plant_Code { get; set; }
        public string Select_ItemBom_Item_Code { get; set; }
        public string Select_ItemBom_Apply_Date { get; set; }

        // BomTreeList
        public string Select_BomTree_Comp_Code { get; set; }
        public string Select_BomTree_Plant_Code { get; set; }
        public string Select_BomTree_Item_Code { get; set; }
        public string Select_BomTree_Child_Item_Code { get; set; }
        public string Select_BomTree_Apply_Date { get; set; }

    }
}
