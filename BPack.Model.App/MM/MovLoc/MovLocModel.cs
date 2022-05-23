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

namespace BPack.Model.App.MM.MovLoc
{
    public class MovLocModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MOV_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "재고이동번호")]
        public string MOV_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "회사")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공장")]
        public string PLANT_CD { get; set; }
        [Display(Name = "인계창고")]
        [Required]
        public string FROM_WH_CD { get; set; }
        [Display(Name = "인수창고")]
        [Required]
        public string TO_WH_CD { get; set; }
        [Display(Name = "이동유형")]
        [Required]
        public string MOV_TYPE_CD { get; set; }


        [Display(Name = "등록일")]
        public DateTime PUBLISH_DT { get; set; }

        [ReadOnly(true)]
        [StrapDisableParam]
        [Display(Name = "처리일")]
        public DateTime? GIR_DT { get; set; }

        [Display(Name = "재고이동상태")]
        [StrapDenyEdit]
        public string MOV_STATUS { get; set; }

        [ReadOnly(true)]
        [StrapDisableParam]
        [Display(Name = "처리일시")]
        public DateTime? CLOSE_DTTM { get; set; }
    }
}

