using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.OrgPlant
{

    public class PlantWkModel : ModelBase_CommonColumns_With_CompCD_PlantCD
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string SHIFT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public DateTime VALID_DT_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string START_TM_KEY { get; set; }
        //[Display(Name = "근무조코드")]
        //public string SHIFT_CD { get; set; }
        [Display(Name = "조업형태")]
        public string WTM_TYPE { get; set; }
        [Display(Name = "타임명")]
        public string TM_CD { get; set; }

        [Display(Name = "적용일자")]
        public DateTime VALID_DT { get; set; }
        [Display(Name = "시작시간")]
        public TimeSpan START_TM { get; set; }
        [Display(Name = "종료시간")]
        public TimeSpan END_TM { get; set; }
    
        [Display(Name = "시간(분)")]
        public int WTM_MIN { get; set; }



    }
}
