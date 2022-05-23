using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationDayPlan
{
    public class DayPlanSumModel
    {
        public List<DayPlanGrModel> headerGrModel = new List<DayPlanGrModel>();
        public DataTable DetailGrModel_DataTable = new DataTable();
        public DataTable ChangedModel = new DataTable();
    }
}
