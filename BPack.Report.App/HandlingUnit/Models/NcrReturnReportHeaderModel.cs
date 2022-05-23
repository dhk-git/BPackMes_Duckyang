using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class NcrReturnReportHeaderModel
    {
        public string REPORT_TYPE_SEQ { get; set; }
        public string REPORT_TITLE { get; set; }
        public string BP_CD { get; set; }
        public string BP_NM { get; set; }
        public string JUDGE_USER { get; set; }
        public string REPORT_DATE { get; set; }
        public string REJECTED_DATE { get; set; }
        public string INCOMING_DATE { get; set; }
        public List<NcrReturnReportDetailModel> detailModels { get; set; }
    }
    
    //public class NcrHistReturnReportHeaderGroupModel
    //{
    //    public string REPORT_TYPE_SEQ { get; set; }
    //    public string REPORT_TITLE { get; set; }
    //    public List<NcrHistReturnReportHeaderModel> headerModels { get; set; }
    //}
}
