using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.MovDocConfirm
{
    public class MovDocModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MOV_NO_KEY { get; set; }
        [Display(Name = "이동번호")]
        public string MOV_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "인계창고")]
        public string FROM_WH_CD { get; set; }
        [Display(Name = "인계위치")]
        public string FROM_LOC_CD { get; set; }
        [Display(Name = "인수창고")]
        public string TO_WH_CD { get; set; }
        [Display(Name = "인수위치")]
        public string TO_LOC_CD { get; set; }
        [Display(Name = "이동유형")]
        public string MOV_TYPE_CD { get; set; }
        [Display(Name = "재고이동상태")]
        public string MOV_STATUS { get; set; }
        [Display(Name = "발행일시")]
        public DateTime? PUBLISH_DTTM { get; set; }
        [Display(Name = "처리일시")]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "인계자")]
        public string FROM_USER_ID { get; set; }
        [Display(Name = "인수자")]
        public string TO_USER_ID { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
    }
}
