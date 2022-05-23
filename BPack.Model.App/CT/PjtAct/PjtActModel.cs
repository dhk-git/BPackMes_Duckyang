using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.CT.PjtAct
{
    public class PjtActModel : ModelBase
    {
        [Display(Name ="시작일자")]
        public DateTime? START_DTTM { get; set; }
        [Display(Name = "종료일자")]
        public DateTime? END_DTTM { get; set; }
        [Display(Name = "프로젝트명")]
        public string PJT_NM { get; set; }
        [Display(Name = "작업명")]
        public string PJT_TASK { get; set; }
        [Display(Name = "투입시간")]
        public decimal ACT_HOUR { get; set; }
        [Display(Name = "분류")]
        public string PJT_ACT_CLS { get; set; }
        [Display(Name = "내용")]
        public string ACT_DESC { get; set; }
        [Display(Name = "비고")]
        public string REMARK { get; set; }
    }
}
