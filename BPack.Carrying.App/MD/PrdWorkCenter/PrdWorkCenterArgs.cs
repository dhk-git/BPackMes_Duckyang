using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdWorkCenterArgs : ArgsBase
    {
        public PrdWorkCenterModelArgs PrdWorkCenterModelArgs { get; set; } = new PrdWorkCenterModelArgs();
    }
}
