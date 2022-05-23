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

namespace BPack.Model.App.MD.PrdWorkCenter
{
    public class WorkCenterModel : ModelBase_CommonColumns_With_DelFlag
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
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }
        [Display(Name = "작업장명")]
        public string WC_NM { get; set; }
        [Display(Name = "작업장그룹")]
        public string WC_GR { get; set; }
        [Display(Name = "작업장유형")]
        public string WC_TYPE { get; set; }
        [Display(Name = "UPH")]
        public decimal UPH { get; set; }
        [Display(Name = "근무조 그룹")]
        public string SHIFT_GROUP_CD { get; set; }



    }
}
