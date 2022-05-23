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

namespace BPack.Model.App.MI.CommonCodeManager
{
    public class ParentCodeModel : ModelBase_CommonColumns_With_CompCode
    {
        [Key]
        [ReadOnly(true)]
        [StrapVisible]
        public string P_CODE_KEY { get; set; }
        [Display(Name ="상위코드")]
        public string P_CODE { get; set; }
        [Display(Name = "상위코드명")]
        public string P_NAME { get; set; }
        [Display(Name = "구분")]
        [StrapLookUpEditCode(CoreOrApp.Core,"COMMON_CODE_CLS")]
        public string CODE_CLS { get; set; }
        [Display(Name = "값1설명")]
        public string VALUE_1_DESC { get; set; }
        [Display(Name = "값2설명")]
        public string VALUE_2_DESC { get; set; }
        [Display(Name = "값3설명")]
        public string VALUE_3_DESC { get; set; }
        [Display(Name = "값4설명")]
        public string VALUE_4_DESC { get; set; }
        [Display(Name = "값5설명")]
        public string VALUE_5_DESC { get; set; }
    }
}
