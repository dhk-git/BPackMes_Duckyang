using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class SerialGoodsBarcodeReportModel
    {
        public string CUSTOMER_BARCODE { get; set; }
        public string HU_BARCODE { get; set; }
        public string VENDOR { get; set; }
        public string SYMBOL { get; set; }
        public string PARTNO { get; set; }
        public string ALC_CD { get; set; }
        public string TRACE { get; set; }
        public string CAR_CD { get; set; }
        public string TEXTURE1 { get; set; }
        public string TEXTURE2 { get; set; }
        public string TEXTURE3 { get; set; }
        public string WORK_DT { get; set; }
        public string WORKER { get; set; }
    }
}
