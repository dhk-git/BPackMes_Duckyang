using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.CT.ProjectManager
{
    public class ProjectDetailUploadModel
    {
        [Display(Name = "분류")]
        public string PJT_CLS { get; set; }
        [Display(Name = "작업명")]
        public string PJT_TASK { get; set; }
        [Display(Name = "담당자1")]
        public string MEMB_NM_1 { get; set; }
        [Display(Name = "담당자2")]
        public string MEMB_NM_2 { get; set; }
        [Display(Name = "상위작업번호")]
        public string PARENT_PJD_NO { get; set; }
        [Display(Name = "계획시작일자")]
        public DateTime? PLAN_START_DT { get; set; }
        [Display(Name = "계획종료일자")]
        public DateTime? PLAN_END_DT { get; set; }
        [Display(Name = "실제시작일자")]
        public DateTime? ACT_START_DT { get; set; }
        [Display(Name = "실제종료일자")]
        public DateTime? ACT_END_DT { get; set; }
        [Display(Name = "상태")]
        public string PJT_DETAIL_STATUS { get; set; }
        [Display(Name = "비고")]
        public string REMARK { get; set; }
    }
}
