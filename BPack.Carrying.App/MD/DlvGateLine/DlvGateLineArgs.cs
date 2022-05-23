using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.DlvGateLine;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class DlvGateLineArgs : ArgsBase
    {
        public DlvGateLineModelArgs DlvGateLineModelArgs { get; set; } = new DlvGateLineModelArgs();
    }
}
