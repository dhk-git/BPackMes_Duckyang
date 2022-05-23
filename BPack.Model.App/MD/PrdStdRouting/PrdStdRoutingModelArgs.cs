using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.PrdStdRouting
{
    public class PrdStdRoutingModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Item_Gr { get; set; }
        public DateTime? Select_Main_Apply_Dt { get; set; }

        public string Select_Str_No { get; set; }
        
    }
}
