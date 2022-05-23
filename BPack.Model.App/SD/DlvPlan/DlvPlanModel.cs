using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvPlan
{
    public class DlvPlanModel : ModelBase_CommonColumns
    {
        public string DPL_NO_KEY { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string ITEM_CD { get; set; }
        public string DPL_NO { get; set; }
        public string SOD_NO { get; set; }
        public DateTime PLAN_DT { get; set; }
        public int PLAN_QTY { get; set; }
        public string DPL_STATUS { get; set; }


    }
}
