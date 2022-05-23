using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeNwRsPivot;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeNwRsPivotArgs : ArgsBase
    {
        public WoeNwRsPivotModelArgs WoeNwRsPivotModelArgs { get; set; } = new WoeNwRsPivotModelArgs();
    }
}
