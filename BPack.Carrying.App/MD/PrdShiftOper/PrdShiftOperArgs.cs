using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdShiftOper;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdShiftOperArgs : ArgsBase
    {
        public PrdShiftOperModelArgs PrdShiftOperModelArgs { get; set; } = new PrdShiftOperModelArgs();
    }
}
