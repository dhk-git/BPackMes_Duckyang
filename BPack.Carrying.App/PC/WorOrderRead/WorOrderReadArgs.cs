using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WorOrderRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WorOrderReadArgs : ArgsBase
    {
        public WorOrderReadModelArgs WorOrderReadModelArgs { get; set; } = new WorOrderReadModelArgs();
    }
}
