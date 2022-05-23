using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.MolInfo;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class MolInfoArgs : ArgsBase
    {
        public MolInfoModelArgs MolInfoModelArgs { get; set; } = new MolInfoModelArgs();
    }
}
