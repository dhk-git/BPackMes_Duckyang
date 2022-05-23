using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.GirTotalStock;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class GirTotalStockArgs : ArgsBase
    {
        public GirTotalStockModelArgs GirTotalStockModelArgs { get; set; } = new GirTotalStockModelArgs();
    }
}
