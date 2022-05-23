using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.QC.AppHist
{
    public class AppHistDetailInspModel : ModelBase
    {
        [Display(Name = "검사번호")]
        [StrapVisible(false, false, false)]
        public string INSP_NO { get; set; }
        
        [Display(Name = "검사분류코드")]
        [StrapVisible(false, false, false)]
        public string INSP_DV { get; set; }

        [Display(Name = "검사분류")]
        public string INSP_DV_NM { get; set; }

        [Display(Name = "검사항목ID")]
        [StrapVisible(false, false, false)]
        public string INSP_ID { get; set; }

        [Display(Name = "검사항목")]
        public string INSP_NM { get; set; }

        [Display(Name = "측정값유형코드")]
        [StrapVisible(false, false, false)]
        public string INSP_VAL_TYPE { get; set; }

        [Display(Name = "측정값유형")]
        public string INSP_VAL_TYPE_NM { get; set; }

        [Display(Name = "검사규격")]
        [StrapVisible(false, false, false)]
        public string INSP_SPEC { get; set; }

        [Display(Name = "기준값")]
        public string BASE_VALUE { get; set; }

        [Display(Name = "상한")]
        public string UPPER_LIMIT { get; set; }

        [Display(Name = "하한")]
        public string LOWER_LIMIT { get; set; }

        [Display(Name = "검사차수")]
        public int INSP_SEQ { get; set; }

        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }

        [Display(Name = "측정값")]
        public string INSP_VAL_QC { get; set; }

        [Display(Name = "합/부판정")]
        public string INSP_JUDGE_QC { get; set; }
    }
}
