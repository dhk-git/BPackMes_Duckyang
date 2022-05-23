using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.DlvOrder.Models
{
    public class ReservedHuModel
    {
        public string DOD_NO { get; set; }
        public string HU_NO { get; set; }
        public string BARCODE_TEXT { get; set; }
        public string COMP_CD { get; set; }
        public string PLNAT_CD { get; set; }
        public string WH_CD { get; set; }
        public string WH_NM { get; set; }
        public string LOC_CD { get; set; }
        public string LOC_NM { get; set; }
        public decimal STOCK_QTY { get; set; }
        public DateTime WORK_DT { get; set; }
        public string REMARK { get; set; }
    }
}
