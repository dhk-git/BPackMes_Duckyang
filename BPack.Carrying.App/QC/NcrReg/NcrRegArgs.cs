using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.NcrReg;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class NcrRegArgs : ArgsBase
    {
        public NcrRegModelArgs NcrRegModelArgs { get; set; } = new NcrRegModelArgs();
    }
}
