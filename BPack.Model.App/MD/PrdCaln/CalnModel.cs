using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdCaln
{
    public class CalnModel : ModelBase_CommonColumns
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
        public DateTime? WORK_DT_KEY { get; set; }

        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        [StrapVisible(true, true, true)]
        public DateTime WORK_DT { get; set; }


        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "작업장")]
        public string WC_CD_KEY { get; set; }


        [StrapDisableParam]
        [ReadOnly(true)]
        [Display(Name = "요일")]
        public string WORK_DT_NM { get; set; }

        [ReadOnly(true)]
        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }

        [Display(Name = "근무유형")]
        public string WORK_TYPE { get; set; }

        [Display(Name = "근무조 그룹")]
        public string SHIFT_GROUP_CD { get; set; }

        [Display(Name = "휴일명")]
        public string MD_HOLIDAY_TYPE { get; set; }
    }
}
