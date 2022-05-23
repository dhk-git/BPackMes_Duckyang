using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WorOrderHuLabel
{
    public class WorOrderHuLabelSerialDetailModel : ModelBase
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WO_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [Display(Name = "작업지시번호")]
        [StrapVisible(false, false, false)]
        public string WO_NO { get; set; }


        [Display(Name = "로트번호")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string LOT_NO { get; set; }

        [Display(Name = "식별표바코드")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string HU_BARCODE { get; set; }

        [Display(Name = "식별표번호")]
        [StrapDenyEdit]
        public string HU_NO { get; set; }

        [Display(Name = "생성일시")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public DateTime CREATE_DTTM { get; set; }
    }
}
