using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MI.CommonCodeManager
{
    public class ChildCodeModel : ModelBase_CommonColumns_With_CompCode
    {
        [Key]
        [StrapVisible]
        public string P_CODE_KEY { get; set; }
        [Key]
        [StrapVisible]
        public string C_CODE_KEY { get; set; }
        [Display(Name = "상위코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string P_CODE { get; set; }
        [Display(Name = "하위코드")]
        public string C_CODE { get; set; }
        [Display(Name = "하위코드명")]
        public string C_NAME { get; set; }
        [Display(Name = "값1")]
        public string VALUE_1 { get; set; }
        [Display(Name = "값2")]
        public string VALUE_2 { get; set; }
        [Display(Name = "값3")]
        public string VALUE_3 { get; set; }
        [Display(Name = "값4")]
        public string VALUE_4 { get; set; }
        [Display(Name = "값5")]
        public string VALUE_5 { get; set; }
        [Display(Name = "정렬순서")]
        [StrapVisible(true)]
        public override float SORT_NO { get => base.SORT_NO; set => base.SORT_NO = value; }
        [Display(Name = "사용유무")]
        [StrapVisible(true)]
        public override bool VALID { get => base.VALID; set => base.VALID = value; }
    }
}
