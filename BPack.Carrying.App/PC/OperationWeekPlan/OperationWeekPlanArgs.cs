using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.OperationWeekPlan;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class OperationWeekPlanArgs : ArgsBase
    {
        public OperationWeekPlanModelArgs OperationWeekPlanModelArgs { get; set; } = new OperationWeekPlanModelArgs();
    }
}
