using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdRouting;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdRoutingArgs : ArgsBase
    {
        public PrdRoutingModelArgs PrdRoutingModelArgs { get; set; } = new PrdRoutingModelArgs();
    }
}
