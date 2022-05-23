using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.OperationMonthPlan
{
    public class OperationMonthPlanModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public string Select_Main_Plan_Year_cd { get; set; }

        public string Select_Main_Item_Group_cd { get; set; }

        public string Select_Main_Item_cd { get; set; }
    }
}
