using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.InvAmount
{
    public class InvAmountModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        public string WH_CD { get; set; }
        [Display(Name = "창고명")]
        public string WH_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "품목유형코드")]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "현재고")]
        public decimal WH_STOCK_QTY { get; set; }
        [Display(Name = "단가")]
        public decimal? PRICE { get; set; }
        [Display(Name = "금액")]
        [StrapGridSummary(Sum = true)]
        public decimal? AMOUNT { get; set; }
    }
}
