using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.CT.PjtAct;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.CT
{
    public class PjtActArgs : ArgsBase
    {
        public PjtActModelArgs PjtActModelArgs { get; set; } = new PjtActModelArgs();
    }
}
