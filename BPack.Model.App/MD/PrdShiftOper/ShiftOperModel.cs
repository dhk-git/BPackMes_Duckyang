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
    public class ShiftOperModel : ModelBase_CommonColumns
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
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string USER_ID_KEY { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }
        [Display(Name = "사용자")]
        public string USER_ID { get; set; }
        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
