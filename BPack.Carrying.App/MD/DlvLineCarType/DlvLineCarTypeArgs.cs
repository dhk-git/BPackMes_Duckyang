using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.DlvLineCarType;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class DlvLineCarTypeArgs : ArgsBase
    {
        public DlvLineCarTypeModelArgs DlvLineCarTypeModelArgs { get; set; } = new DlvLineCarTypeModelArgs();
    }
}
