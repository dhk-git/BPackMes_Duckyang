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
    public class WeekItemModel : ModelBase_CommonColumns
    {
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "계획년도")]
        public string YEAR_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
    }
}
