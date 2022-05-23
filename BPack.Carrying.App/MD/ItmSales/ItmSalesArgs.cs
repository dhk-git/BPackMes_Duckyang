using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.ItmSales;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class ItmSalesArgs : ArgsBase
    {
        public ItmSalesModelArgs ItmSalesModelArgs { get; set; } = new ItmSalesModelArgs();
    }
}
