using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.DlvPlan;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class DlvPlanArgs : ArgsBase
    {
        public DlvPlanModelArgs DlvPlanModelArgs { get; set; } = new DlvPlanModelArgs();
    }
}
