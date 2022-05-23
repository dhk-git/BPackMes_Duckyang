using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PO.PurPack;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PO
{
    public class PurPackArgs : ArgsBase
    {
        public PurPackModelArgs PurPackModelArgs { get; set; } = new PurPackModelArgs();
    }
}
