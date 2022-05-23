using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.GirWareHouse
{
    public class GirWareHouseModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Comp_Code { get; set; }
        public string Select_Plant_Code { get; set; }
        public string Select_WareHouse_Code { get; set; }
        public string Select_WareHouse_Group { get; set; }
    }
}
