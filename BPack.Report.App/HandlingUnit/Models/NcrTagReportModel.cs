using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class NcrTagReportModel
    {
        public string NCR_TAG_NO { get; set; }
        public string NCR_TAG_NO_BARCODE { get; set; }
        public string HU_BARCODE { get; set; }
        public string REPORT_TITLE{ get; set; }
        public string ITEM_GROUP { get; set; }
        public string NCR_QTY { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public string WC_NM { get; set; }
        public string JUDGE_DTTM { get; set; }
        public string JUDGE_USER { get; set; }
        public string NCR_TYPE { get; set; }
        public string ACT_DESC { get; set; }
        public string NCR_DESC { get; set; }
        public string REPORT_TYPE { get; set; }

    }
}
