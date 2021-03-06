using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MM.PurInbound
{
    public class PurPackModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PAC_NO_KEY { get; set; }
        [Display(Name = "등록번호")]
        [StrapDenyEdit]
        public string PAC_NO { get; set; }
        [Display(Name = "INVOICE NO")]
        [StrapHidden]
        public string INVOICE_NO { get; set; }
        [Display(Name = "오더번호")]
        public string INVOICE_NO_2 { get; set; }
        [Display(Name = "컨테이너NO")]
        public string CONTAINER_NO { get; set; }

        [Display(Name = "선적일자")]
        public DateTime INVOICE_DT { get; set; }

        [Display(Name = "DY발주번호")]
        [StrapHidden]
        public string DY_PO_NO { get; set; }
        [Display(Name = "발주상세번호")]
        [StrapVisible(false, false, false)]
        public string POD_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "적입수량")]
        public decimal PAC_QTY { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "대포장바코드번호")]
        public string BARCODE_NO { get; set; }
        [Display(Name = "작업일")]
        public DateTime CREATE_DT { get; set; }
        [Display(Name = "도착일자")]
        public DateTime ARRIVAL_DT { get; set; }
        [Display(Name = "도착처리일시")]
        public DateTime ARRIVAL_DTTM { get; set; }
        [Display(Name = "상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "PAC_STATUS", false)]
        public string PAC_STATUS { get; set; }
    }

}
