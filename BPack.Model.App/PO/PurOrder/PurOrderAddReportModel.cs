using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.PurOrder
{
    public class PurOrderAddReportModel
    {
        public string POH_NO { get; set; }
        public string PO_REPORT_HTML { get; set; }
        public byte[] PO_REPORT_PDF { get; set; }
        public string LANG_CODE { get; set; }
    }
}
