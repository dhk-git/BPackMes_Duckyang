using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.GirInv;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class GirInvArgs : ArgsBase
    {
        public GirInvModelArgs GirInvModelArgs { get; set; } = new GirInvModelArgs();
    }
}
