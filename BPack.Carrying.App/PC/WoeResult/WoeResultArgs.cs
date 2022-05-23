using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeResult;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeResultArgs : ArgsBase
    {
        public WoeResultModelArgs WoeResultModelArgs { get; set; } = new WoeResultModelArgs();
        public string Ok_Ng { get; set; }
        public decimal HuQty { get; internal set; }
    }
}
