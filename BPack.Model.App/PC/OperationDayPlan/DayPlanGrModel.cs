using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationDayPlan
{
    public class DayPlanGrModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapHidden]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapHidden]
        public string PLANT_CD { get; set; }

        [Display(Name = "대상년도")]
        public string YEAR_CD { get; set; }

        [Display(Name = "유형")]
        public string ITEM_TYPE_NM { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_NM { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [StrapHidden]
        [Display(Name = "작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "작업장")]
        public string WC_NM { get; set; }

        [StrapHidden]
        [Display(Name = "근무조그룹")]
        public string SHIFT_GROUP_CD { get; set; }

        [StrapHidden]
        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }


        [Display(Name = "근무조")]
        public string SHIFT_NM { get; set; }

        [Display(Name = "UPH")]
        public string UPH { get; set; }


        [Display(Name = "가동시간(분)")]
        public int SHIFT_MINUTES { get; set; }

        [Display(Name = "생산가능수량")]
        public decimal SHIFT_UPH { get; set; }

    }
}
