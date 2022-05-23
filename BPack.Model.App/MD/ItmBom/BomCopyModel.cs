using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.ItmBom
{
    public class BomCopyModel : ModelBase_CommonColumns
    {
        
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string BOM_NO_KEY { get; set; }
        public string ITEM_CD { get; set; }

        public DateTime VALID_FROM_DT { get; set; }
    }
}
