using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationWeekPlan
{
    public class WeekPlanSumModel
    {
        public List<WeekPlanGrModel> headerGrModel = new List<WeekPlanGrModel>();
        public DataTable DetailGrModel_DataTable = new DataTable();
        //public DataTable OriginModel = new DataTable();
        public DataTable ChangedModel = new DataTable();

    }
}
