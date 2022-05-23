using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class HuSampleModel
    {
        public string HU_NO { get; set; }
        public string BARCODE_TEXT { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public decimal INIT_QTY { get; set; }
        public decimal STOCK_QTY { get; set; }
    }
}
