using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MI.CommonCodeManager
{
    public class CommonCodeManagerModelArgs : ModelArgsBase
    {
        public string Select_PCode { get; set; }
        public string Select_Main_PCode { get; set; }
        public string Select_Comp_Code { get; set; }
    }
}
