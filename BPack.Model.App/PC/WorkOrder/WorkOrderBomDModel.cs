using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WorkOrder
{
    public class WorkOrderBomDModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WO_NO_KEY { get; set; }

        [StrapDisableParam]
        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }

        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [StrapDisableParam]
        [Display(Name = "TYPE")]
        public String ITEM_TYPE_CD { get; set; }

        [Display(Name = "소요량")]
        public float OPER_QTY { get; set; }

        [StrapDisableParam]
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }
    }
}
