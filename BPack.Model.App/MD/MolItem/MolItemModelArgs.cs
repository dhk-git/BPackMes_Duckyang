using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.MolItem
{
    public class MolItemModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Mold_Code { get; set; }
        public string Select_Main_Mold_Name { get; set; }

        public string Select_Mold_Code { get; set; }
        public string Select_Item_Code { get; set; }
    }
}
