using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.InvOrder
{
    public class InvOrderModelArgs : ModelArgsBase
    {
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Inv_No { get; set; }
        public string Select_Invd_No { get; set; }
        public string Select_Inv_Type { get; set; }
        public string Select_Inv_Status { get; set; }
        public string Select_Item_Cd { get; set; }
        public string Select_Main_Target_Inv_Gr { get; set; }
        public string Select_Target_Wh_Cd { get; set; }
    }
}
