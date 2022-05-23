using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PC.WoeRsPivot
{
    public class WoeRsPivotModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }

        public DateTime START_DT { get; set; }

        public DateTime END_DT { get; set; }

        public string WC_CD { get; set; }

        public string ITEM_GR_1 { get; set; }

        public string ITEM_TYPE { get; set; }

        public string ITEM_CD { get; set; }

        public string ITEM_NM { get; set; }

        public string SHIFT_GROUP_CD { get; set; }

        public string SHIFT_CD { get; set; }
    }
}
