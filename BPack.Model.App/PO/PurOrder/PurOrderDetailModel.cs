using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PO.PurOrder
{
    public class PurOrderDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string POD_NO_KEY { get; set; }
        [Display(Name = "발주번호")]
        [StrapVisible(false, false, false)]
        public string POH_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapMinWidth(120)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        [StrapMinWidth(150)]
        [StrapDenyEdit]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapDisableParam]
        [StrapMinWidth(100)]
        [StrapDenyEdit]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "품목유형")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "구매단위수량")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public decimal PUR_SIZE { get; set; }
        [Display(Name = "발주수량")]
        [StrapGridSummary(Sum = true)]
        public decimal POD_QTY { get; set; }
        [Display(Name = "납기일")]
        [StrapMinWidth(100)]
        public DateTime DUE_DT { get; set; }
        [Display(Name = "단가")]
        public decimal POD_PRICE { get; set; }
        [Display(Name = "금액")]
        //[StrapGridSummary(Sum = true)]
        [StrapDisableParam]
        [StrapDenyEdit]
        public decimal POD_AMOUNT { get; set; }
        [Display(Name = "통화")]
        public string CURRENCY_TYPE { get; set; }
        [Display(Name = "상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "POD_STATUS")]
        [StrapDenyEdit]
        public string POD_STATUS { get; set; }
        [Display(Name = "발주상세번호")]
        [StrapDenyEdit]
        public string POD_NO { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
        [Display(Name = "구매요청번호")]
        public string POR_NO { get; set; }
        [Display(Name = "구매요청상세번호")]
        public string POE_NO { get; set; }
        [Display(Name = "구매요청으로부터일괄등록")]
        [StrapVisible(false, false, false)]
        public string IS_BATCH_FROM_POR { get; set; } = "N";
    }
}
