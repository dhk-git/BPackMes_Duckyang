using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.InvAmount
{
    public class InvAmountModelArgs : ModelArgsBase
    {
        public string Select_Main_Item_Type_Cd { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Price_Type { get; set; }
    }
}
