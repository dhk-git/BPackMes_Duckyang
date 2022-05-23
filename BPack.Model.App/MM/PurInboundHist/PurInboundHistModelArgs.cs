using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;

namespace BPack.Model.App.MM.PurInboundHist
{
    public class PurInboundHistModelArgs : ModelArgsBase
    {
        public string select_Main_Pih_no { get; set; }
        public string select_Main_Do_no { get; set; }
        public string select_Main_Item_cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        //public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        //public string Select_Plant_Cd { get; set; }

    }
}
