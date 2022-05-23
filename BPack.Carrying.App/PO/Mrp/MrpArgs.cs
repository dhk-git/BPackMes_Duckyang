using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PO.Mrp;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PO
{
    public class MrpArgs : ArgsBase
    {
        public MrpModelArgs MrpModelArgs { get; set; } = new MrpModelArgs();
        public bool IsAutoRunAndSendMailMode { get; set; } = false;
    }
}
