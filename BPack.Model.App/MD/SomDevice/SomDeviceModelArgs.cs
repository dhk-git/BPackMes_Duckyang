using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MD.SomDevice
{
    public class SomDeviceModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Plant_CD { get; set; }
        public string Select_Dvc_ID { get; set; }
        public string Select_Mode_ID { get; set; }
        public string Select_Dvcs_CD { get; set; }
    }
}
