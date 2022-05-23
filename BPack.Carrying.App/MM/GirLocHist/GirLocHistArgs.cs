using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.GirLocHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class GirLocHistArgs : ArgsBase
    {
        public GirLocHistModelArgs GirLocHistModelArgs { get; set; } = new GirLocHistModelArgs();
    }
}
