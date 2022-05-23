using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.OperationDayPlan;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class OperationDayPlanArgs : ArgsBase
    {
        public OperationDayPlanModelArgs OperationDayPlanModelArgs { get; set; } = new OperationDayPlanModelArgs();
    }
}
