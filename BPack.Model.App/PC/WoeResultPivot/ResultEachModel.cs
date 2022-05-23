using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResultPivot
{
    public class ResultEachModel : ModelBase
    {
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "생산일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "생산일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm:ss")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "근무조코드")]
        [StrapVisible(false, false, false)]
        public string SHIFT_CD { get; set; }
        [Display(Name = "근무조")]
        public string SHIFT_NM { get; set; }
        [Display(Name = "작업시간")]
        [StrapVisible(false, false, false)]
        public string WORK_TM { get; set; }
        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }
        [Display(Name = "작업장")]
        public string WC_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "수량")]
        [StrapGridSummary(Sum =true)]
        public decimal HU_INIT_QTY { get; set; }
        [Display(Name = "OK/NG")]
        [StrapVisible(false, false, false)]
        public string OK_NG { get; set; }
        [Display(Name = "바코드")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "실적번호")]
        public string RST_NO { get; set; }
        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }
        [Display(Name = "지시일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime WO_DT { get; set; }
    }
}
