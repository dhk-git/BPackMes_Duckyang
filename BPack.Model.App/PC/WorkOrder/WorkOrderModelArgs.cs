using BPack.Common.Model;
using System;

namespace BPack.Model.App.PC.WorkOrder
{
    public class WorkOrderModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }

        public string WO_NO_KEY { get; set; }
        public DateTime START_DT { get; set; }
        public DateTime END_DT { get; set; }

        public string WC_CD { get; set; }

        public string ITEM_CD { get; set; }

        public string ITEM_NM { get; set; }

        public string SHIFT_GROUP_CD { get; set; }

        public string SHIFT_CD { get; set; }

        public string DEL_FG { get; set; }

        public string Allow_Phantom { get; set; }

    }
}
