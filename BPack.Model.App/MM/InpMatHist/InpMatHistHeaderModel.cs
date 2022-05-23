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
    public class InpMatHistHeaderModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name ="거래처코드")]
        public string BP_CD { get; set; }
        [Display(Name = "거래처명")]
        [StrapGridGrouping]
        public string BP_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        [StrapGridGroupSummary(Sum = true)]
        public decimal PID_QTY { get; set; }
        //[Display(Name = "입고수량")]
        //[StrapGridSummary(Sum = true)]
        //[StrapGridGroupSummary(Sum = true)]
        //public decimal SUM_GR_QTY { get; set; }
        //[Display(Name = "단가")]
        //public string PRICE { get; set; }
        //[Display(Name = "단가합계")]
        //public string COST { get; set; }
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }

        [Display(Name = "금액")]
        [StrapGridSummary(Sum = true)]
        public decimal SUM_AMOUNT { get; set; }
        [Display(Name = "통화")]
        public string CURRENCY_TYPE { get; set; }
        //[Display(Name = "차이")]
        //[StrapGridSummary(Sum = true)]
        //[StrapGridGroupSummary(Sum = true)]
        //public decimal DIFF_QTY { get; set; }
        
    }
}
