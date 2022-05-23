using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationWeekPlan
{
    public class WeekConfirmModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public string SNOP_STATUS { get; set; }

        public string ITEM_CDS { get; set; }
        public DateTime CONFIRM_DT { get; set; }


        
    }
}
