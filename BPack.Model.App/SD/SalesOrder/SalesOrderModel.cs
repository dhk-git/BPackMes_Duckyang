using System;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.SalesOrder
{
    public class SalesOrderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string SOR_NO_KEY { get; set; }
        [Display(Name = "주문접수번호")]
        [StrapDenyEdit]
        public string SOR_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "거래처")]
        [Required]
        public string BP_CD { get; set; }
        [Display(Name = "등록일자")]
        [StrapDenyEdit]
        public DateTime SOR_DT { get; set; }
        [Display(Name = "확정일시")]
        [StrapDenyEdit]
        [StrapDateEdit(FormatString ="MM-dd-yyyy HH:mm")]
        public DateTime? SOR_CLOSE_DTTM { get; set; }
        [Display(Name = "상태")]
        [StrapDenyEdit]
        public string SOR_STATUS { get; set; }
        
    }
}
