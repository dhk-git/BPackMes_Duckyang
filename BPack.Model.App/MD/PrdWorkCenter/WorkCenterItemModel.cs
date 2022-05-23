using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdWorkCenter
{
    public class WorkCenterItemModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WC_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ITEM_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public DateTime VALID_DT_KEY { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [StrapDisableParam]
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }


        [Display(Name = "적용일자")]
        public DateTime VALID_DT { get; set; }
        [Display(Name = "자재출고창고")]
        public string MAT_WH_CD { get; set; }
        [Display(Name = "생산입고창고")]
        public string GD_WH_CD { get; set; }

        [Display(Name = "생산입고위치")]
        public string GD_LOC_CD { get; set; }

        [Display(Name = "UPH")]
        [StrapVisible(false, false, false)]
        public decimal UPH { get; set; }

    }
}
