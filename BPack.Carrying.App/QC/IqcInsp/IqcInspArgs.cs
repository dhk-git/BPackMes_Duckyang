using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.IqcInsp;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class IqcInspArgs : ArgsBase
    {
        public IqcInspModelArgs IqcInspModelArgs { get; set; } = new IqcInspModelArgs();
    }
}
