using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.PrdCaln
{
    public class PrdCalnModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Wc_Code { get; set; }

        public string Year_CD { get; set; }

        public string Month_CD { get; set; }

    }
}
