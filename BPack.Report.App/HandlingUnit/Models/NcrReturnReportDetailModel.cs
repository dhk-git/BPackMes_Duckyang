using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class NcrReturnReportDetailModel
    {
        public string ROW_NO { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public string LOT_NO { get; set; }
        public string INCOMING_QTY { get; set; }
        public string REJECTED_QTY { get; set; }
        public string NCR_NM { get; set; }
    }
}
