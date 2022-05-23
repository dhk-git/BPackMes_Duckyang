using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.GirEtc;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class GirEtcArgs : ArgsBase
    {
        public GirEtcModelArgs GirEtcModelArgs { get; set; } = new GirEtcModelArgs();
    }
}
