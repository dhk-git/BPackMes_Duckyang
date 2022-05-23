using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.Annotation.Common;
namespace BPack.Model.App.PC.OperationMonthPlan
{
    public class MonthPlan : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public string SNOP_NO { get; set; }

        
        [StrapDisableParam]
        public string YEAR_CD { get; set; }
        [StrapDisableParam]
        public string MONTH_CD { get; set; }
        [StrapDisableParam]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        public string ITEM_NM { get; set; }

        public decimal SP_PLAN_QTY { get; set; }
        public decimal PP_PLAN_QTY { get; set; }
        public decimal IP_PLAN_QTY { get; set; }

        [StrapDisableParam]
        public string CUR_DATA { get; set; }



    }
}
