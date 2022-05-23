using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeWorkResultCloseModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string RST_NO { get; set; }
        public string RST_HU_TYPE { get; set; }
        public string MAT_WH_CD { get; set; }
        public string MAT_LOC_CD { get; set; }
        public string GD_WH_CD { get; set; }
        public string GD_LOC_CD { get; set; }
    }
}
