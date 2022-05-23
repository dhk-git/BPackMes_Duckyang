using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PO.PurOrder
{
    public class PurOrderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string POH_NO_KEY { get; set; }
        [Display(Name = "발주번호")]
        [StrapDenyEdit]
        public string POH_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "거래처")]
        [Required]
        public string BP_CD { get; set; }
        [Display(Name = "발주서상태")]
        [StrapDenyEdit]
        public string POH_STATUS { get; set; }
        [Display(Name = "납품장소")]
        [StrapVisible(false, false, false)]
        public string DVL_PLACE { get; set; }
        [Display(Name = "발주구분")]
        [StrapDenyEdit]
        public string POH_CREATE_CLS { get; set; }
        [Display(Name = "내/외자구분")]
        [StrapVisible(false, false, false)]
        public string POH_INTER_CLS { get; set; }
        [Display(Name = "발주일자")]
        public DateTime POH_DT { get; set; }
        [Display(Name = "확정일시")]
        [StrapVisible(true, false, false)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }

    }
}
