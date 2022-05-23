using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvOrder
{
    public class SaveReservedHuModel : ModelBase_CommonColumns
    {
        public string DOD_NO { get; set; }
        public string DOH_NO { get; set; }
        public string HU_NO { get; set; }
    }
}
