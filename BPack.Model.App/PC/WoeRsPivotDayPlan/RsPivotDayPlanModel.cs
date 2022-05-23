using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeRsPivotDayPlan
{
    public class RsPivotDayPlanModel
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public DateTime WORK_DT { get; set; }

        public string ITEM_TYPE_NM { get; set; }
        public string ITEM_GR_NM { get; set; }
        public string ITEM_CD { get; set; }

        public string ITEM_NM { get; set; }

        public string CLS_NAME { get; set; }

        public int TARGET_RATIO { get; set; }

        public int QTY { get; set; }


    }
}
