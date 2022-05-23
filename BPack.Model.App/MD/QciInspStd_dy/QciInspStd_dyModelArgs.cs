using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.QciInspStd_dy
{
    public class QciInspStd_dyModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }

        public string Select_Main_ITEM_GR_1 { get; set; }

        public string Select_Main_ITEM_TYPE_CD { get; set; }

        public string Select_Main_ITEM_CD { get; set; }

        public string Select_Main_ITEM_NM { get; set; }

        public string Select_Main_QCI_TYPE { get; set; }
    }
}
