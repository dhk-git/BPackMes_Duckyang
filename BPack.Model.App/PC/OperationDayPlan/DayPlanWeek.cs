using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationDayPlan
{
    public class DayPlanWeek
    {
        public int? CODE { get; set; }
        public string NAME { get; set; }

        //public string DESC { get; set; }
        [DisplayName("Start Date")]
        public string START_DT { get; set; }
        [DisplayName("End Date")]
        public string END_DT { get; set; }

        public string TODAY { get; set; }

    }
}
