using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.CT.ProjectManager
{
    public class ProjectDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PJD_NO_KEY { get; set; }
        [Display(Name = "작업번호")]
        [ReadOnly(true)]
        public string PJD_NO { get; set; }
        [ReadOnly(true)]
        [Display(Name = "프로젝트번호")]
        [StrapVisible(false, false, false)]
        public string PJT_NO { get; set; }
        [Display(Name = "작업명")]
        public string PJT_TASK { get; set; }
        [Display(Name = "작업코드")]
        public string PJT_TASK_CD { get; set; }
        [Display(Name = "분류1")]
        public string PJT_TASK_CLS { get; set; }
        [Display(Name = "분류2")]
        public string PJT_TASK_CLS_2 { get; set; }
        [Display(Name = "분류3")]
        public string PJT_TASK_CLS_3 { get; set; }
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
        [Display(Name = "실적시작일자")]
        public DateTime? ACT_START_DT { get; set; }
        [Display(Name = "실적종료일자")]
        public DateTime? ACT_END_DT { get; set; }
        [Display(Name = "계획M/D")]
        [StrapGridSummary(Sum = true)]
        public decimal? PLAN_MD { get; set; }
        [Display(Name = "실적M/D")]
        [StrapGridSummary(Sum = true)]
        public decimal? ACT_MD { get; set; }
        [Display(Name = "상태")]
        public string PJT_DETAIL_STATUS { get; set; }
    }
}
