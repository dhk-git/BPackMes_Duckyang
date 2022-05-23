using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.ItmBom
{
    public class ItmBomModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Item_Code { get; set; }
        public string Select_Main_Item_Name { get; set; }
        public string Select_Main_Main_Model { get; set; }

        public string Select_Comp_Code { get; set; }
        public string Select_Plant_Code { get; set; }
        public string Select_Item_Code { get; set; }

        public string Select_Bom_No { get; set; }
        public string Select_EditForm_Item_Code { get; set; }
    }
}
