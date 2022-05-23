using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeUsedMaterialBpModel : ModelBase_CommonColumns
    {
        public string WO_NO { get; set; }
        public int OPER { get; set; }
        public string RST_NO { get; set; }
        public string HU_NO { get; set; }
        public decimal RST_QTY { get; set; }
    }
}
