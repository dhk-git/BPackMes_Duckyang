using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.MaterialRequest
{
    public class MaterialRequestDetailModel
    {
        public int SEQ { get; set; }

        public string ITEM_CD { get; set; }

        public string ITEM_NM { get; set; }

        public string ITEM_GROUP { get; set; }

        public string ITEM_TYPE { get; set; }

        public string ITEM_TYPE_NM { get; set; }

        public string LOC_NM { get; set; }

        public int MRD_QTY { get; set; }

        public string HU_NO { get; set; }

        public string REMARK { get; set; }

    }
}
