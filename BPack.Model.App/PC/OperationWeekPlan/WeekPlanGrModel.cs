using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationWeekPlan
{
    public class WeekPlanGrModel : ModelBase
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

        [Display(Name = "품목유형그룹")]
        public string ITEM_TYPE_CLS { get; set; }

    }
}
