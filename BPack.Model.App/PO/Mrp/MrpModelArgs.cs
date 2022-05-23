using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PO.Mrp
{
    public class MrpModelArgs : ModelArgsBase
    {
        public string Select_Main_Mrh_No { get; set; }
        public string Select_Por_No { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Por_Status { get; set; }
        public string Select_New_Por_Status { get; set; }
        public string Select_Mrh_No { get; set; }
        public string Select_Mrh_Status { get; set; }
        public string Select_Por_Mrh_No { get; set; }
        public string Select_Main_Mrh_Dttm { get; set; }
        public string Select_Popup_YYYY_WK { get; set; }
        public string Selett_Popup_Item_Cd { get; set; }
    }
}
