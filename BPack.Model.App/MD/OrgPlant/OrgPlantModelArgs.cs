using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.OrgPlant
{
    public class OrgPlantModelArgs : ModelArgsBase
    {
        public string Select_Comp_Code { get; set; }
        public string Select_Plant_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Plant_Name { get; set; }
    }
}
