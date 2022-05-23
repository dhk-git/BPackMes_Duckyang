using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdWcOper;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdWcOperArgs : ArgsBase
    {
        public PrdWcOperModelArgs PrdWcOperModelArgs { get; set; } = new PrdWcOperModelArgs();
    }
}
