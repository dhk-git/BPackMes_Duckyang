using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PO.PurOrderInp
{
    public class PurOrderInpModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Item_Cd { get; set; }
        public DateTime Select_Poh_Dt { get; set; }
    }
}
