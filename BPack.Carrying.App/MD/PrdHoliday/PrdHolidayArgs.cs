using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdHoliday;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdHolidayArgs : ArgsBase
    {
        public PrdHolidayModelArgs PrdHolidayModelArgs { get; set; } = new PrdHolidayModelArgs();
    }
}
