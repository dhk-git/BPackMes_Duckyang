using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.InpMatHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class InpMatHistArgs : ArgsBase
    {
        public InpMatHistModelArgs InpMatHistModelArgs { get; set; } = new InpMatHistModelArgs();
    }
}
