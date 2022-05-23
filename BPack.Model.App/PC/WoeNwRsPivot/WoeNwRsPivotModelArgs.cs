using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WoeNwRsPivot
{
    public class WoeNwRsPivotModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }

        public string Select_Main_Wc_Cd { get; set; }

        public string Select_Main_SearchType { get; set; }

        public string Select_Sub_Wc_Cd { get; set; }

        public int Select_Sub_Year_Cd { get; set; }

        public int Select_Sub_Month_Cd { get; set; }

        public int Select_Sub_Week_Cd { get; set; }

        public DateTime Select_Sub_Work_dt { get; set; }




    }
}
