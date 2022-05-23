using BPack.Model.App.MD.ItmBom;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.ItmBom
{
    public class ItmBomArgs : ArgsBase
    {
        public ItmBomModelArgs itmBomModelArgs { get; set; } = new ItmBomModelArgs();
    }
}
