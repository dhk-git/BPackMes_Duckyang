using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeNwRsPivot
{
    public class NwRsPivotNotworkModel : ModelBase_CommonColumns
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

        [Display(Name = "근무조 코드")]
        public string SHIFT_GROUP_CD { get; set; }

        [Display(Name = "근무조 상세 코드")]
        public string SHIFT_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "비가동 그룹 코드")]
        public string NOTWORK_GROUP_CD { get; set; }

        [Display(Name = "비가동 상세 코드")]
        public string NOTWORK_CD { get; set; }

        [Display(Name = "시작 시간")]
        public TimeSpan START_DTTM { get; set; }

        [Display(Name = "종료 시간")]
        public TimeSpan END_DTTM { get; set; }


        [Display(Name = "비가동 시간(분)")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public int TOTAL_TIME { get; set; }

        //[Display(Name = "비가동 실제 시간")]
        //[StrapVisible(false,false,false)]
        //[StrapDisableParam]
        //public int DURATION_TIME { get; set; }

    }
}
