using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;

namespace BPack.Model.App.SD.SalesOrder
{
    public class SalesOrderDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string SOD_NO_KEY { get; set; }
        [Display(Name = "주문접수상세번호")]
        [StrapVisible(false, false, false)]
        public string SOD_NO { get; set; }
        [Display(Name = "주문접수번호")]
        [StrapVisible(false, false, false)]
        public string SOR_NO { get; set; }
        [Display(Name = "순번")]
        public int SOD_SEQ { get; set; }
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
        [StrapDenyEdit]
        [StrapMinWidth(120)]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "주문일자")]
        public DateTime SOR_DT { get; set; }
        [Display(Name = "주문수량")]
        public decimal SOD_QTY { get; set; }
        [Display(Name = "단가")]
        public decimal SOD_PRICE { get; set; }
        [Display(Name = "금액")]
        //[StrapGridSummary(Sum = true)]
        [StrapDisableParam]
        [StrapDenyEdit]
        public decimal SOD_AMOUNT { get; set; }
        [Display(Name = "통화")]
        public string CURRENCY_TYPE { get; set; }
        [Display(Name = "납기일")]
        public DateTime DUE_DT { get; set; }
        [Display(Name = "고객발주번호")]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "SOD_STATUS")]
        [StrapDenyEdit]
        public string SOD_STATUS { get; set; }
        [Display(Name = "납품진행상태")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string SOD_DLV_STATUS { get; set; }
    }
}
