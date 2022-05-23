using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.MaterialRequest
{
    public class MaterialRequestModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }

        public DateTime START_DT { get; set; }

        public DateTime END_DT { get; set; }

        public string MRH_STATUS { get; set; }

        public string MRH_NO_KEY { get; set; }

        public string MRD_NO_KEY { get; set; }
    }
}
