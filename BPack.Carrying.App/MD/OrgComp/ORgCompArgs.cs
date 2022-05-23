using BPack.Model.App.MD.OrgComp;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.OrgComp
{
    public class OrgCompArgs : ArgsBase
    {
        public OrgCompModelArgs orgCompModelArgs { get; set; } = new OrgCompModelArgs();
    }
}
