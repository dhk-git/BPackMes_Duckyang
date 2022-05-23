using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.SomDevice;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class SomDeviceArgs : ArgsBase
    {
        public SomDeviceModelArgs SomDeviceModelArgs { get; set; } = new SomDeviceModelArgs();
    }
}
