using BPack.Model.App.MD.ItmBomTree;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.ItmBomTree
{
    public class ItmBomTreeArgs : ArgsBase
    {
        public ItmBomTreeModelArgs itmBomTreeModelArgs{ get; set; } = new ItmBomTreeModelArgs();
    }
}
