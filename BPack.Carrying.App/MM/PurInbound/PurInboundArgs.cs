using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.PurInbound;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class PurInboundArgs : ArgsBase
    {
        public PurInboundModelArgs PurInboundModelArgs { get; set; } = new PurInboundModelArgs();
        public string Select_Main_InTarget_Wh_Cd { get; set; }
        public string Select_Main_InTarget_Loc_Cd { get; set; }
        public string Select_Extra_Bp_Cd { get; set; }
        public string Select_Extra_Bp_Nm { get; set; }
    }
}
