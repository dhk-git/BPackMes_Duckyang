using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.NcrReg
{
    public class NcrRegModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }

        public DateTime Select_Main_Start_dt { get; set; }
        public DateTime Select_Main_End_dt { get; set; }

        public string Select_Main_Nch_Status { get; set; }

        public string Comp_cd { get; set; }
        public string Plant_cd { get; set; }

        public string NCH_NO_KEY { get; set; }

        public string ITEM_CD { get; set; }

        public string BOM_NO { get; set; }

        public string NCH_STATUS { get; set; }
    }
}
