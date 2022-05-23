using BPack.Common.Model;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WoeRsltInfo
{
    public class WoeRsltInfoHuModel : ModelBase
    {
        [Display(Name = "생산일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm:ss")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "생산실적번호")]
        public string RST_NO { get; set; }
        [Display(Name = "수량")]
        [StrapGridSummary(Sum =true)]
        public float HU_INIT_QTY { get; set; }
        [Display(Name = "식별표바코드")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "작업자")]
        [StrapLookUpEditAllUsers]
        public string CREATE_USER_ID { get; set; }
    }
}
