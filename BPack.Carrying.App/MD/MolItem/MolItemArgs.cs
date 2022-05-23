using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.MolItem;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class MolItemArgs : ArgsBase
    {
        public MolItemModelArgs MolItemModelArgs { get; set; } = new MolItemModelArgs();
    }
}
