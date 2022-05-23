using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.InvAdjust;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class InvAdjustArgs : ArgsBase
    {
        public InvAdjustModelArgs InvAdjustModelArgs { get; set; } = new InvAdjustModelArgs();
    }
}
