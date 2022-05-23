using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdShiftOper
{
    public class ShiftModel : ModelBase_CommonColumns
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
        public string SHIFT_CD_KEY { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }
        [Display(Name = "근무조명")]
        public string SHIFT_NM { get; set; }
        [Display(Name = "정규시간")]
        public int REGUL_HOUR { get; set; }
        [Display(Name = "시작시각")]
        public TimeSpan START_TM { get; set; }
        [Display(Name = "종료시각")]
        public TimeSpan END_TM { get; set; }
        [Display(Name = "익일종료")]
        public bool IS_NEXT_DAY { get; set; }
        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
