using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdStdRouting;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdStdRoutingArgs : ArgsBase
    {
        public PrdStdRoutingModelArgs PrdStdRoutingModelArgs { get; set; } = new PrdStdRoutingModelArgs();
    }
}
