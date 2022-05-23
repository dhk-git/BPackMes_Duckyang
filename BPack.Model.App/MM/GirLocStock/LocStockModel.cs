using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MM.GirLocStock
{
    public class LocStockModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }

        [Display(Name = "위치코드")]
        [StrapVisible(false, false, false)]
        public string LOC_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "규격")]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }

        [Display(Name = "품목유형")]
        public string ITEM_TYPE { get; set; }

        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_2 { get; set; }

        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }

        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }



        [Display(Name = "기초재고")]
        [StrapGridSummary(Sum = true)]
        public decimal BASE_STOCK_QTY { get; set; }

        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal SUM_GR_QTY { get; set; }

        [Display(Name = "출고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal SUM_GI_QTY { get; set; }

        [Display(Name = "기말재고")]
        [StrapGridSummary(Sum = true)]
        public decimal SUM_STOCK_QTY { get; set; }

        [Display(Name = "현재고")]
        [StrapGridSummary(Sum = true)]
        public decimal CUR_STOCK_QTY { get; set; }
    }
}
