using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.BpaGate
{
    public class BpaGateModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }

        public string Select_Main_Bp_Cd { get; set; }
        public string Select_Comp_Cd { get; set; }
        public string Select_Bp_Cd { get; set; }
    }
}
