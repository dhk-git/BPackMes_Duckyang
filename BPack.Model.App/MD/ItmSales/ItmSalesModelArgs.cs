using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.ItmSales
{
    public class ItmSalesModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_BP_CD{ get; set; }

        public string Select_Main_Item_CD { get; set; }

        public string Select_Bp_CD { get; set; }
    }
}
