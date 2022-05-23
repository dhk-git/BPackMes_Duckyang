using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.QchNcrRegRead
{
    public class QchNcrRegReadModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_dt { get; set; }
        public DateTime Select_Main_End_dt { get; set; }

        public string   Select_Main_Item_Cd { get; set; }

        public string Select_Main_Item_Group1 { get; set; }

        public string   Select_Main_Item_Nm { get; set; }

        public string Select_Main_Nch_Type { get; set; }

        public string Comp_cd { get; set; }
        public string Plant_cd { get; set; }

        public string Item_cd { get; set; }

        public DateTime Start_dt { get; set; }


    }
}
