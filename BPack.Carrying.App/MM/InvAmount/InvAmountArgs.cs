using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.InvAmount;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class InvAmountArgs : ArgsBase
    {
        public InvAmountModelArgs InvAmountModelArgs { get; set; } = new InvAmountModelArgs();
    }
}
