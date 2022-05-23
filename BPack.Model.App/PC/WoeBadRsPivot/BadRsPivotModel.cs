using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeBadRsPivot
{
    public class BadRsPivotModel
    {
        [Display(Name = "회사")]
        public string COMP_CD { get; set; }

        [Display(Name = "공장")]
        public string PLANT_CD { get; set; }

        [Display(Name = "작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "작업장명")]
        public string WC_NM { get; set; }


        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "년도")]
        public int YEAR { get; set; }
        [Display(Name = "월")]
        public int MONTH_CD { get; set; }

        [Display(Name = "주차")]
        public int WEEK_CD { get; set; }

        [Display(Name = "일자")]
        public DateTime WORK_DT { get; set; }

        [Display(Name = "구분")]
        public string CLS_TYPE { get; set; }

        [Display(Name = "구분")]
        public string CLS_NAME { get; set; }

        public string SORT_NO { get; set; }

        [Display(Name = "수량")]
        public int QTY { get; set; }
    }
}
