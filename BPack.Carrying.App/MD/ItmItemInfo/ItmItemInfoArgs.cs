using BPack.Model.App.MD.ItmItemInfo;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.ItmItemInfo
{
    public class ItmItemInfoArgs : ArgsBase
    {
        public ItmItemInfoModelArgs itmItemInfoModelArgs { get; set; } = new ItmItemInfoModelArgs();
    }
}
