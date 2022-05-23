using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.PrdShift
{
    public class PrdShiftModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }

        public string SHIFT_GROUP_CD { get; set; }

    }
}
