using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdShift;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdShiftArgs : ArgsBase
    {
        public PrdShiftModelArgs PrdShiftModelArgs { get; set; } = new PrdShiftModelArgs();
    }
}
