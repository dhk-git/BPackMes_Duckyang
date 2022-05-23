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

namespace BPack.Model.App.PO.PurPack
{
    public class InvoiceModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INVOICE_NO_KEY { get; set; }
        [Display(Name = "오더번호^#^컨테이너NO")]
        [StrapVisible(false, false, false)]
        public string INVOICE_NO { get; set; }
        [Display(Name = "오더번호")]
        [Required]
        public string INVOICE_NO_2 { get; set; }
        [Display(Name = "컨테이너NO")]
        [Required]
        public string CONTAINER_NO { get; set; }
        [Display(Name = "상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "INVOICE_STATUS")]
        [StrapDenyEdit]
        public string INVOICE_STATUS { get; set; }
        [Display(Name = "선적일자")]
        public DateTime INVOICE_DT { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "도착예정일")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        [Required]
        public DateTime ETA_DT { get; set; }
        [Display(Name = "도착일자")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        [StrapVisible(true, false, false)]
        public DateTime? ARRIVAL_DT { get; set; }
        [Display(Name = "도착처리일시")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        [StrapVisible(true, false, false)]
        public DateTime? ARRIVAL_DTTM { get; set; }
        [Display(Name = "거래처")]
        [Required]
        public string BP_CD { get; set; }
        [Display(Name = "완료일시")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        [StrapVisible(false, false, false)]
        public DateTime? CLOSE_DTTM { get; set; }

    }
}
