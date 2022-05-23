using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.CT.ProjectManager
{
    public class ProjectHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PJT_NO_KEY { get; set; }
        [Display(Name = "프로젝트번호")]
        [ReadOnly(true)]
        public string PJT_NO { get; set; }
        [Display(Name = "프로젝트명")]
        public string PJT_NM { get; set; }
        [Display(Name = "프로젝트설명")]
        public string PJT_DESC { get; set; }
        [Display(Name = "프로젝트분류")]
        public string PJT_CLS { get; set; }
        [Display(Name = "계획시작일자")]
        public DateTime? PLAN_START_DT { get; set; }
        [Display(Name = "계획종료일자")]
        public DateTime? PLAN_END_DT { get; set; }
        [Display(Name = "실적시작일자")]
        public DateTime? ACT_START_DT { get; set; }
        [Display(Name = "실적종료일자")]
        public DateTime? ACT_END_DT { get; set; }
        [Display(Name = "상태")]
        public string PJT_STATUS { get; set; }
    }
}
