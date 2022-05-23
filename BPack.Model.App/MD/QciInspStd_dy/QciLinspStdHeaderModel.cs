using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.QciInspStd_dy
{
    public class QciLinspStdHeaderModel : ModelBase_CommonColumns
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
        public string ITEM_CD_KEY { get; set; }

        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [StrapDisableParam]
        [StrapDenyEdit]
        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [StrapDenyEdit]
        [Display(Name = "품목명")]
        public string ITEM_NM { get; set; }

        [StrapDisableParam]
        [StrapDenyEdit]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [StrapDisableParam]
        [StrapDenyEdit]
        [Display(Name = "제품유형")]
        public string ITEM_TYPE_CD { get; set; }

        [Display(Name = "입고검사유형")]
        public string QCI_TYPE { get; set; }


    }
}
