using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.SD.SalesOrderHist
{
    public class SalesOrderHistModelArgs : ModelArgsBase
    {
        public DateTime Search_Main_START_DT { get; set; }
        public DateTime Search_Main_END_DT { get; set; }
        public string Search_Main_ITEM_CD { get; set; }
        public string Search_Main_ITEM_NM { get; set; }
        public string Search_Main_ITEM_GR1_CD { get; set; }
        public string Search_Main_ITEM_BP_CD { get; set; }

        public DateTime Select_Main_Sor_Dt { get; set; }
        public string Select_Main_BP_CD { get; set; }
        public string Select_Main_ITEM_CD { get; set; }
    }
}
