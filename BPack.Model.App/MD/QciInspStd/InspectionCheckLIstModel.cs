using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.QciInspStd
{
    public class InspectionCheckListModel : ModelBase_CommonColumns_With_DelFlag
    {
        [Display(Name = "검사분류")]
        [StrapDisableParam]
        [StrapMinWidth(200)]
        public string INSP_DV { get; set; }
        [Display(Name = "검사항목")]
        [StrapMinWidth(100)]
        public string INSP_ID { get; set; }
        [Display(Name = "검사규격")]
        public string INSP_SPEC { get; set; }
        [Display(Name = "하한")]
        public string LOWER_LIMIT { get; set; }
        [Display(Name = "기준값")]
        public string BASE_VALUE { get; set; }
        [Display(Name = "상한")]
        public string UPPER_LIMIT { get; set; }
        [Display(Name = "검사방법")]
        [StrapDisableParam]
        [StrapMinWidth(150)]
        [StrapVisible(true, false, false)]
        [ReadOnly(true)]
        public string INSP_METHOD { get; set; }
        [Display(Name = "측정값유형")]
        [StrapDisableParam]
        [StrapVisible(true, false, false)]
        [ReadOnly(true)]
        public string INSP_VAL_TYPE { get; set; }
        [Display(Name = "단위")]
        [StrapDisableParam]
        [StrapVisible(true, false, false)]
        [ReadOnly(true)]
        public string UNIT { get; set; }
        [Display(Name = "QC")]
        public string QC_FG { get; set; } = "N";
        [Display(Name = "참조파일")]
        public string FILE_GROUP_ID { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_STD_ID_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int REVISION_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_ID_KEY { get; set; }
        [Display(Name = "검사기준ID")]
        [StrapVisible(false, false, false)]
        public string INSP_STD_ID { get; set; }
        [Display(Name = "리비젼")]
        [StrapVisible(false, false, false)]
        public int? REVISION { get; set; }

        [Display(Name = "정렬순서")]
        [StrapVisible(false, false, false)]
        public int SORT_SEQ { get; set; }
        [Display(Name = "생산팀전용")]
        [StrapVisible(false, false, false)]
        public string PC_FG { get; set; } = "N";

    }
}
