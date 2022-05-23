using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class dy_MPackingDetailModel
    {
        public string D_TITLE { get; set; }
        public string D_SUPPLIER { get; set; }

        public string D_ITEM_CD { get; set; }

        public string D_ITEM_NM { get; set; }

        public string D_QTY { get; set; }

        public string D_WORK_DT { get; set; }

        public string D_SEQ { get; set; }

        public string D_BARCODE_TEXT { get; set; }
        public string HU_NO { get; set; }
    }
}
