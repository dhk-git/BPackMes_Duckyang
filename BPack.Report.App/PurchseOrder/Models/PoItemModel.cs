using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.PurchseOrder.Models
{
    public class PoItemModel
    {
        public int ROW_NUM { get; set; }
        public string POD_NO { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public string ITEM_SPEC { get; set; }
        public decimal POD_QTY { get; set; }
        public string BASE_UNIT { get; set; }
        public DateTime DUE_DT { get; set; }

    }
}
