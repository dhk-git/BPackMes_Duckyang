using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.OperationMonthPlan
{
    public class MonthPlanGrModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapHidden]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapHidden]
        public string PLANT_CD { get; set; }

        [Display(Name = "대상년도")]
        //[StrapHidden]
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
        [Display(Name = "구분")]
        public string SNOP_TYPE { get; set; }

        [Display(Name = "구분")]
        public string SNOP_TYPE_NM { get; set; }

        [StrapHidden]
        [Display(Name = "SORT")]
        public int SORT_NO { get; set; }


    }
}
