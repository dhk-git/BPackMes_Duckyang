using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeEssLot;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeEssLotArgs : ArgsBase
    {
        public WoeEssLotModelArgs WoeEssLotModelArgs { get; set; } = new WoeEssLotModelArgs();
    }
}
