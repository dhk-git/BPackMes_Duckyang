using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WorOrderHuLabel;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WorOrderHuLabelArgs : ArgsBase
    {
        public WorOrderHuLabelModelArgs WorOrderHuLabelModelArgs { get; set; } = new WorOrderHuLabelModelArgs();
    }
}
