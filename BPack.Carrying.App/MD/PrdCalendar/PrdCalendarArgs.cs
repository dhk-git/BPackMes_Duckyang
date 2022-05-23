using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdCalendar;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdCalendarArgs : ArgsBase
    {
        public PrdCalendarModelArgs PrdCalendarModelArgs { get; set; } = new PrdCalendarModelArgs();
    }
}
