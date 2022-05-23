using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.MovLoc;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class MovLocArgs : ArgsBase
    {
        public MovLocModelArgs MovLocModelArgs { get; set; } = new MovLocModelArgs();
    }
}
