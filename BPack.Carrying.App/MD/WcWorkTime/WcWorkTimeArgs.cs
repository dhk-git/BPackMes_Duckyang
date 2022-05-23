using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.WcWorkTime;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class WcWorkTimeArgs : ArgsBase
    {
        public WcWorkTimeModelArgs WcWorkTimeModelArgs { get; set; } = new WcWorkTimeModelArgs();
    }
}
