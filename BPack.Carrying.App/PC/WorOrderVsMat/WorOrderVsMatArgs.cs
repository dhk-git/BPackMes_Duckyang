using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WorOrderVsMat;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WorOrderVsMatArgs : ArgsBase
    {
        public WorOrderVsMatModelArgs WorOrderVsMatModelArgs { get; set; } = new WorOrderVsMatModelArgs();
    }
}
