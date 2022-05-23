using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.BpaGate
{
    public class BpaGateArgs : ArgsBase
    {
        public Model.App.MD.BpaGate.BpaGateModelArgs bpaGateModelArgs { get; set; } = new Model.App.MD.BpaGate.BpaGateModelArgs();
    }
}
