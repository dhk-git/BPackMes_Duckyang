using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.OperationMonthPlan;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class OperationMonthPlanArgs : ArgsBase
    {
        public OperationMonthPlanModelArgs OperationMonthPlanModelArgs { get; set; } = new OperationMonthPlanModelArgs();
    }
}
