using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdCaln;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdCalnArgs : ArgsBase
    {
        public PrdCalnModelArgs PrdCalnModelArgs { get; set; } = new PrdCalnModelArgs();
    }
}
