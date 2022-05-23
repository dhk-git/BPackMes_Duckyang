using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class FmlTagReportModel
    {
        public string QR_CODE { get; set; }
        public string ITEM_GR_1 { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public string TRACEABILITY { get; set; } 
        public string INSP_SUB_TYPE_NM { get; set; }
        public string DATE { get; set; }
        public string SHIFT_NM { get; set; }
        public string PROCESS { get; set; }
    }
}
