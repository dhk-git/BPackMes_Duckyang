using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PO.PurOrderInp;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PO
{
    public class PurOrderInpArgs : ArgsBase
    {
        public PurOrderInpModelArgs PurOrderInpModelArgs { get; set; } = new PurOrderInpModelArgs();
    }
}
