using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdShift
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
        public string SHIFT_GROUP_CD_KEY { get; set; }

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

        [Display(Name = "근무조 그룹")]
        public string SHIFT_GROUP_CD { get; set; }

        [Display(Name = "근무조 코드")]
        public string SHIFT_CD { get; set; }

        [Display(Name = "SEQ")]
        public int SEQ { get; set; }

        [Display(Name = "명일 시작")]
        public bool IS_START_NEXT_DAY { get; set; }

        [Display(Name = "시작 시간")]
        public TimeSpan WORK_START_TIME { get; set; }

        [Display(Name = "명일 종료")]
        public bool IS_END_NEXT_DAY { get; set; }

        [Display(Name = "종료 시간")]
        public TimeSpan WORK_END_TIME { get; set; }

        [Display(Name = "연장 근무")]
        public bool OVERTIME_STATUS { get; set; }

        [Display(Name = "작업 상태")]
        public string WORK_STATUS { get; set; }

        [Display(Name = "비가동 그룹")]
        public string NOTWORK_GROUP_CD { get; set; }
        [Display(Name = "비가동 코드")]
        public string NOTWORK_CD { get; set; }

    }
}
