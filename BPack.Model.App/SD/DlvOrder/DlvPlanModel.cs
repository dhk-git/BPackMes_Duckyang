using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;

namespace BPack.Model.App.SD.DlvOrder
{
    public class DlvPlanModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DPL_NO_KEY { get; set; }
        [Display(Name = "출하계획번호")]
        public string DPL_NO { get; set; }
        [Display(Name = "주문접수상세번호")]
        public string SOD_NO { get; set; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "거래처")]
        public string BP_NM { get; set; }
        [Display(Name = "고객사발주번호")]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "계획일자")]
        public DateTime PLAN_DT { get; set; }
        [Display(Name = "계획수량")]
        [StrapGridSummary(Sum = true)]
        public decimal PLAN_QTY { get; set; }
        [Display(Name = "계획잔량")]
        [StrapGridSummary(Sum = true)]
        public decimal DIFF_QTY { get; set; }
        [Display(Name = "단위")]
        [StrapDisableParam]
        [StrapLookUpEditCode(CoreOrApp.App, "UNIT", false)]
        public string BASE_UNIT { get; set; }
        [Display(Name = "출하계획상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "DPL_STATUS", false)]
        public string DPL_STATUS { get; set; }
    }
}
