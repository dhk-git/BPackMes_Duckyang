using BPack.Model.App.MD.OrgDept;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.OrgDept
{
    public class OrgDeptArgs : ArgsBase
    {
        public OrgDeptModelArgs orgDeptModelArgs { get; set; } = new OrgDeptModelArgs();
    }
}
