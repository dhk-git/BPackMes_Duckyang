using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.HumLocInfo
{
    public class HumLocInfoModelArgs : ModelArgsBase
    {
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Ware_House { get; set; }
        public string Select_Main_Location { get; set; }
        public string Select_Main_Item_Code { get; set; }
        public string Select_Main_Hu_No { get; set; }
    }
}
