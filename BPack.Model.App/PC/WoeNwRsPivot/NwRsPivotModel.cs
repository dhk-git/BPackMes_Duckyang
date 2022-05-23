using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeNwRsPivot
{
    public class NwRsPivotModel
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }
        public string WC_CD { get; set; }
        public string WC_NM { get; set; }
        
        [Display(Name ="년도")]
        public int YEAR { get; set; }
        [Display(Name = "월")]
        public int MONTH_CD { get; set; }

        [Display(Name = "주차")]
        public int WEEK_CD { get; set; }

        [Display(Name = "일자")]
        public DateTime WORK_DT { get; set; }

        public string CLS_TYPE { get; set; }

        public string CLS_NAME { get; set; }

        public string SORT_NO { get; set; }

        public int QTY { get; set; }
    }
}
