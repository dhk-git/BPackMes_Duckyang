using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdNonOper
{
    public class NonOperModel : ModelBase_CommonColumns
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
        public string NOTWORK_GROUP_CD_KEY { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NOTWORK_CD_KEY { get; set; }

        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [StrapVisible(true, true, false)]
        [ReadOnly(true)]
        [Display(Name = "비가동 그룹")]
        public string NOTWORK_GROUP_CD { get; set; }

        [StrapVisible(true, true, false)]
        [Display(Name = "비가동 코드")]
        public string NOTWORK_CD { get; set; }

        [StrapVisible(true, true, true)]
        [Display(Name = "비가동 명")]
        public string NOTWORK_NM { get; set; }
    }
}
