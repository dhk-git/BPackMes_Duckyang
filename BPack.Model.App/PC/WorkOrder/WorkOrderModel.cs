using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WorkOrder
{
    //public class WorkOrderModel : ModelBase_CommonColumns_With_DelFlag
    public class WorkOrderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WO_NO_KEY { get; set; }

        [ReadOnly(true)]
        [StrapDisableParam()]
        [Display(Name = "작업지시")]
        public string WO_NO { get; set; }

        [Display(Name = "유형")]
        public string ORDER_TYPE { get; set; }

        [StrapDisableParam]
        [Display(Name = "상태")]
        public string ORDER_STATUS { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "회사")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공장")]
        public string  PLANT_CD { get; set; }

        [Display(Name = "작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        [StrapDisableParam()]
        public string ITEM_NM { get; set; }

        [ReadOnly(true)]
        [StrapDisableParam()]
        [Display(Name = "BOM")]
        public string BOM_NO { get; set; }

        [StrapVisible(false,false,false)]
        [Range(1,Int32.MaxValue)]
        [Display(Name = "용기 SIZE")]
        public float LOT_SIZE { get; set; }


        [Required(AllowEmptyStrings = false)]
        [Display(Name = "근무조 그룹")]
        public string SHIFT_GROUP_CD { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "근무조")]
        public string SHIFT_CD { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "일자")]
        public DateTime WO_DT { get; set; }

        [Display(Name = "지시 수량")]
        public float WOR_QTY { get; set; }

        [Required]
        [Display(Name = "UPH 수량")]
        public float UPH_QTY { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "투입")]
        public string MAT_WH_CD { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "생산")]
        public string GD_WH_CD { get; set; }

        [Display(Name = "삭제유무")]
        public string DEL_FG { get; set; }

        

    }
}
