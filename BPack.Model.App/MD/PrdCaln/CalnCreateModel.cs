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
    public class CalnCreateModel : ModelBase_CommonColumns
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

        public string YEAR_CD { get; set; }

        public string MONTH_CD { get; set; }
    }
}
