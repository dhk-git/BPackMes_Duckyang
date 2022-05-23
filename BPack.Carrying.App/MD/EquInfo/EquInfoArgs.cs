using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.EquInfo;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class EquInfoArgs : ArgsBase
    {
        public EquInfoModelArgs EquInfoModelArgs { get; set; } = new EquInfoModelArgs();
    }
}
