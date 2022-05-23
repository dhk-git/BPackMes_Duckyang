using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.OperationDayPlan
{
    public class OperationDayPlanModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }

        public DateTime Select_Main_Plan_Month_dt { get; set; }

        public int Select_Main_Month_Week_Cd { get; set; }

        public string Select_Main_Wc_Cd { get; set; }

        public string Select_Main_Snop_Status { get; set; }

        public string Select_Main_Item_Group_cd { get; set; }

        public string Select_Main_Item_cd { get; set; }


    }
}
