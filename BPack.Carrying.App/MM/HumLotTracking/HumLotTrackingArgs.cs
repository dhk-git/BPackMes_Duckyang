using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.HumLotTracking;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class HumLotTrackingArgs : ArgsBase
    {
        public HumLotTrackingModelArgs HumLotTrackingModelArgs { get; set; } = new HumLotTrackingModelArgs();
    }
}
