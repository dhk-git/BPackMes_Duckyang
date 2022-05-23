using BPack.Model.App.MM.PurInboundHist;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MM.PurInboundHist
{
    public class PurInboundHistArgs : ArgsBase
    {
        public PurInboundHistModelArgs PurInboundHistModelArgs { get; set; } = new PurInboundHistModelArgs();
    }
}
