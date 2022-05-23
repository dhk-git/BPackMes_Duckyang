using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.ItmPurchase;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class ItmPurchaseArgs : ArgsBase
    {
        public ItmPurchaseModelArgs ItmPurchaseModelArgs { get; set; } = new ItmPurchaseModelArgs();
    }
}
