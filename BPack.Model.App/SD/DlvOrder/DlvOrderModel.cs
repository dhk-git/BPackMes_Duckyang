using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;

namespace BPack.Model.App.SD.DlvOrder
{
    public class DlvOrderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DOH_NO_KEY { get; set; }
        [Display(Name = "출하지시번호")]
        [StrapDenyEdit]
        public string DOH_NO { get; set; }
        [Display(Name = "출하회차")]
        [Required]
        public int? ORDER_SEQ { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "거래처")]
        [Required]
        public string BP_CD { get; set; }
        [Display(Name = "출하지시일자")]
        public DateTime DOH_DT { get; set; }
        [Display(Name = "출하지시상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "DOH_STATUS", false)]
        [StrapDenyEdit]
        public string DOH_STATUS { get; set; }
    }

}
