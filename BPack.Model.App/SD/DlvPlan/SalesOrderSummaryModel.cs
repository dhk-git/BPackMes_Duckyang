using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvPlan
{
    public class SalesOrderSummaryModel : ModelBase
    {
        [Display(Name = "주문상세번호")]
        [StrapHidden]
        public string SOD_NO { get; set; }
        [Display(Name = "주문번호")]
        [StrapHidden]
        public string SOR_NO { get; set; }
        [Display(Name = "거래처코드")]
        [StrapHidden]
        public string BP_CD { get; set; }
        [Display(Name = "거래처")]
        public string BP_NM { get; set; }
        [Display(Name = "고객사발주번호")]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapHidden]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapHidden]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "포장수량")]
        public decimal BOX_SIZE { get; set; }
        [Display(Name = "납기일")]
        public DateTime DUE_DT { get; set; }
        [Display(Name = "주문수량")]
        public decimal SOD_QTY { get; set; }
        [Display(Name = "납품수량")]
        public decimal DLV_RESULT_QTY { get; set; }
        [Display(Name = "발주잔량")]
        public decimal SOD_QTY_REMAIN { get; set; }
        [Display(Name = "DB계획잔량")]
        public decimal PLAN_QTY_REMAIN { get; set; }
        [Display(Name = "DB계획합계")]
        public decimal SUM_PLAN_QTY { get; set; }
        [Display(Name = "계획잔량")]
        public decimal DISPLAY_PLAN_QTY_REMAIN { get; set; }
        [Display(Name = "계획합계")]
        public decimal DISPLAY_SUM_PLAN_QTY { get; set; }


    }
}
