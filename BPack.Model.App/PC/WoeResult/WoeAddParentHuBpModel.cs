using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeAddParentHuBpModel : ModelBase_CommonColumns
    {
        public string RST_NO { get; set; }
        public string OK_NG { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string ITEM_CD { get; set; }
        //public decimal HU_QTY { get; set; }
        public DateTime WORK_DT { get; set; }
        //public string HU_TYPE { get; set; }
    }
}
