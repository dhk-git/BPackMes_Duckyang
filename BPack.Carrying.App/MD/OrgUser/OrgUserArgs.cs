using BPack.Model.App.MD.OrgUser;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.OrgUser
{
    public class OrgUserArgs : ArgsBase
    {
        public OrgUserModelArgs orgUserModelArgs { get; set; } = new OrgUserModelArgs();
    }
}
