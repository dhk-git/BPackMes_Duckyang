using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationWeekPlan
{
    public class WeekPlanModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }
        public string SNOP_WK_NO { get; set; }

        public decimal PLAN_QTY { get; set; }
    }
}
