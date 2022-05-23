using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeBadRsPivot
{
    public class BadRsPivotBadModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int SEQ_KEY { get; set; }

        [Display(Name = "회사")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "년")]
        [StrapDisableParam]
        public string YEAR_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "월")]
        [StrapDisableParam]
        public int MONTH_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "주차")]
        [StrapDisableParam]
        public int WEEK_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "월별 주차")]
        [StrapDisableParam]
        public int MONTH_WEEK_CD { get; set; }

        [Display(Name = "일자")]
        public DateTime? WORK_DT { get; set; }

        
        [Display(Name = "작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [StrapDisableParam]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }


        [Display(Name = "불량")]
        public string DEFECT_CD { get; set; }

        [Display(Name = "수량")]
        public int BAD_QTY { get; set; }


    }
}
