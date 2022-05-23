using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;

namespace BPack.Model.App.SD.DlvOrder
{
    public class DlvOrderDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DOD_NO_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapMinWidth(100)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        [StrapMinWidth(150)]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "출하지시수량")]
        [StrapGridSummary(Sum = true)]
        public decimal DOD_QTY { get; set; }
        [Display(Name = "예약된수량")]
        [StrapGridSummary(Sum = true)]
        [StrapDisableParam]
        [StrapDenyEdit]
        public decimal RESERVED_QTY { get; set; }
        [Display(Name = "단위")]
        [StrapDisableParam]
        [StrapLookUpEditCode(CoreOrApp.App, "UNIT", false)]
        public string BASE_UNIT { get; set; }
        [Display(Name = "고객사발주번호")]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "출하지시상세번호")]
        [StrapDenyEdit]
        public string DOD_NO { get; set; }
        [Display(Name = "출하지시번호")]
        [StrapVisible(false, false, false)]
        public string DOH_NO { get; set; }
        [Display(Name = "출하계획번호")]
        [StrapDenyEdit]
        public string DPL_NO { get; set; }
    }

}
