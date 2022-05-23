using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeBadRsPivot;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeBadRsPivotArgs : ArgsBase
    {
        public WoeBadRsPivotModelArgs WoeBadRsPivotModelArgs { get; set; } = new WoeBadRsPivotModelArgs();
    }
}
