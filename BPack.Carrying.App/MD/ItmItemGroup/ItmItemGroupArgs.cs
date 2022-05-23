using BPack.Model.App.MD.ItmItemGroup;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.ItmItemGroup
{
    public class ItmItemGroupArgs : ArgsBase
    {
        public ItmItemGroupModelArgs itmItemGroupModelArgs { get; set; } = new ItmItemGroupModelArgs();
    }
}
