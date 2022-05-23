using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.MaterialRequest
{
    public class MrqhListModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MRH_NO_KEY { get; set; }

        [StrapDisableParam]
        [ReadOnly(true)]
        [Display(Name = "불출지시번호")]
        public string MRH_NO { get; set; }
        [Display(Name = "회사")]
        public string COMP_CD { get; set; }
        [Display(Name = "공장")]
        public string PLANT_CD { get; set; }

        [Display(Name = "요청 작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "요청일자")]
        public DateTime MRH_DT { get; set; }

        [ReadOnly(true)]
        [Display(Name = "상태")]
        public string MRH_STATUS { get; set; }

    }
}
