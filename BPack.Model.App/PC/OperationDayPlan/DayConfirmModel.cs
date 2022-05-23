using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationDayPlan
{
    public class DayConfirmModel: ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public string WC_CD { get; set; }

        public string SNOP_TYPE { get; set; }

        public DateTime START_DT { get; set; }
        public DateTime END_DT { get; set; }



    }
}
