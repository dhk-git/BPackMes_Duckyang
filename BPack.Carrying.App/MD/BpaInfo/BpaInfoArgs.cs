using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.BpaInfo
{
    public class BpaInfoArgs : ArgsBase
    {
        public Model.App.MD.BpaInfo.BpaInfoModelArgs bpaInfoModelArgs { get; set; } = new Model.App.MD.BpaInfo.BpaInfoModelArgs();
    }
}
