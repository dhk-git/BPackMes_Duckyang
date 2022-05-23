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
    public class ProjectActivityModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PJA_NO_KEY { get; set; }
        [Display(Name = "진행이력번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string PJA_NO { get; set; }
        [Display(Name = "작업번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string PJD_NO { get; set; }
        [Display(Name = "구성원명")]
        public string MEMB_NM { get; set; }
        [Display(Name = "시작일시")]
        [StrapDateEdit(FormatString ="yyyy-MM-dd")]
        public DateTime? START_DTTM { get; set; }
        [Display(Name = "종료일시")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime? END_DTTM { get; set; }
        [Display(Name = "투입시간")]
        public decimal ACT_HOUR { get; set; }
        [Display(Name = "분류")]
        public string PJT_ACT_CLS { get; set; }
        [Display(Name = "내용")]
        public string ACT_DESC { get; set; }
    }
}
