using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.GirStock;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class GirStockArgs : ArgsBase
    {
        public GirStockModelArgs GirStockModelArgs { get; set; } = new GirStockModelArgs();
    }
}
