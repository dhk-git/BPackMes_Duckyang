using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.OperationWeekPlan
{
    public class OperationWeekPlanModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Plan_Start_dt { get; set; }
        public DateTime Select_Main_Plan_End_dt { get; set; }

        public string Select_Main_Item_Group_cd { get; set; }

        public string Select_Main_Item_cd { get; set; }

        public string Year_cd { get; set; }
    }
}
