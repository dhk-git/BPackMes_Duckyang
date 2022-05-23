using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PO.PurOrder;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PO.PurOrder
{
    public class PurOrderArgs : ArgsBase
    {
        public PurOrderModelArgs PurOrderModelArgs { get; set; } = new PurOrderModelArgs();
    }
}
