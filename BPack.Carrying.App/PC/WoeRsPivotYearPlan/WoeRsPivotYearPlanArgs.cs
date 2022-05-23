using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeRsPivotYearPlan;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeRsPivotYearPlanArgs : ArgsBase
    {
        public WoeRsPivotYearPlanModelArgs WoeRsPivotYearPlanModelArgs { get; set; } = new WoeRsPivotYearPlanModelArgs();
    }
}
