using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.InvOrder;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class InvOrderArgs : ArgsBase
    {
        public InvOrderModelArgs InvOrderModelArgs { get; set; } = new InvOrderModelArgs();
    }
}
