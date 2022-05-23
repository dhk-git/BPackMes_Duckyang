using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.CT.PjtAct
{
    public class PjtActModelArgs : ModelArgsBase
    {
        public DateTime Select_Start_Dt { get; set; }
        public DateTime Select_End_Dt { get; set; }
    }
}
