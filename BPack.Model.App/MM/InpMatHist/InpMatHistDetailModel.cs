using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.InpMatHist
{
    public class InpMatHistDetailModel : ModelBase_CommonColumns_With_CompCD_PlantCD
    {
        [Display(Name = "입고일자")]
        public DateTime GIR_DT { get; set; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "거래처명")]
        [StrapVisible(false, false, false)]
        public string BP_NM { get; set; }
    
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal GR_QTY { get; set; }
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }
        [Display(Name = "단가")]
        public decimal PRICE { get; set; }
        [Display(Name = "금액")]
        [StrapGridSummary(Sum = true)]
        public decimal AMOUNT { get; set; }
        [Display(Name = "통화")]
        public string CURRENCY_TYPE { get; set; }
        
        [Display(Name = "바코드번호")]
        public string BARCODE_TEXT { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }

        [Display(Name = "입고처리일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime CLOSE_DTTM { get; set; }

    }
}
