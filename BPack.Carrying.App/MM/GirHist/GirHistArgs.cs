using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.GirHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class GirHistArgs : ArgsBase
    {
        public GirHistModelArgs GirHistModelArgs { get; set; } = new GirHistModelArgs();
    }
}
