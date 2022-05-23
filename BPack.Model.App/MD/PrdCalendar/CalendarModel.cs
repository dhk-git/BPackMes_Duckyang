using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdCalendar
{
    public class CalendarModel : ModelBase_CommonColumns
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
        public DateTime WORK_DT_KEY { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd (ddd)}")]
        [Display(Name = "기준일자")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "근무유형")]
        public string WORK_TYPE { get; set; }
        [Display(Name = "근무시작시간")]
        [StrapVisible(false, false, false)]
        public string WORK_FROM_TM { get; set; }
        [Display(Name = "근무종료시간")]
        [StrapVisible(false, false, false)]
        public string WORK_TO_TM { get; set; }
        [Display(Name = "익일종료")]
        [StrapVisible(false, false, false)]
        public bool IS_NEXT_DAY { get; set; }
    }
}
