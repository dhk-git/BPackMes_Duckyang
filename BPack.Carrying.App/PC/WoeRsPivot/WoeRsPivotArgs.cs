using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeRsPivot;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeRsPivotArgs : ArgsBase
    {
        public WoeRsPivotModelArgs WoeRsPivotModelArgs { get; set; } = new WoeRsPivotModelArgs();
    }
}
