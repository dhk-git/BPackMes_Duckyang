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
    public class ProjectMemberModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PJT_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int MEMB_SEQ_KEY { get; set; }
        [Display(Name = "프로젝트번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string PJT_NO { get; set; }
        [Display(Name = "NO.")]
        public int MEMB_SEQ { get; set; }
        [Display(Name = "역할")]
        public string PJT_MEMB_ROLE { get; set; }
        [Display(Name = "구성원명")]
        public string MEMB_NM { get; set; }
        [Display(Name = "계획투입일자")]
        public DateTime? PLAN_START_DT { get; set; }
        [Display(Name = "계획종료일자")]
        public DateTime? PLAN_END_DT { get; set; }
        [Display(Name = "실제투입일자")]
        public DateTime? ACT_START_DT { get; set; }
        [Display(Name = "실제종료일자")]
        public DateTime? ACT_END_DT { get; set; }
        [Display(Name = "상태")]
        public string PJT_MEMB_STATUS { get; set; }
    }
}
