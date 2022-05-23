using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeRsPivotDayPlan;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeRsPivotDayPlanArgs : ArgsBase
    {
        public WoeRsPivotDayPlanModelArgs WoeRsPivotDayPlanModelArgs { get; set; } = new WoeRsPivotDayPlanModelArgs();
    }
}
