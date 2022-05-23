using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MD.WcWorkTime
{
    public class WcWorkTimeWorkTimeModel : ModelBase_CommonColumns
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
        public string SHIFT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? VALID_DT_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        //[DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public TimeSpan START_TM_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "근무조코드")]
        [StrapMinWidth(80)]
        public string SHIFT_CD { get; set; }
        [Display(Name = "조업형태")]
        [StrapMinWidth(120)]
        //[StrapLookUpEditCode(CoreOrApp.Core, "WTM_TYPE", false)]
        public string WTM_TYPE { get; set; }
        [Display(Name = "타임명")]
        public string TM_NM { get; set; }
        [Display(Name = "시작시간")]
        //[DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public TimeSpan START_TM { get; set; }
        [Display(Name = "종료시간")]
        //[DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public TimeSpan END_TM { get; set; }

        [Display(Name = "시간(분)")]
        public int WTM_MIN { get; set; }
        [Display(Name = "적용일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? VALID_DT { get; set; } = DateTime.Now;


        //[Display(Name = "유효시작일")]
        //[StrapVisible(false, false, false)]
        //public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        //[Display(Name = "유효종료일")]
        //[StrapVisible(false, false, false)]
        //public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);

        //[Display(Name = "삭제FLAG(Y=삭제)")]
        //[StrapVisible(false, false, false)]
        //public override string DEL_FG { get; set; } = "N";


    }
}
