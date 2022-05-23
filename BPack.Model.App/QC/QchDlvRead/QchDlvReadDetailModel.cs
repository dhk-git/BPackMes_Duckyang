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

namespace BPack.Model.App.QC.QchDlvRead
{
    public class QchDlvReadDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_NO_KEY { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_ID_KEY { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int INSP_SEQ_KEY { get; set; }

        [Display(Name = "검사번호")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_NO { get; set; }

        [Display(Name = "검사항목")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapMinWidth(80)]
        public string INSP_ID { get; set; }

        [Display(Name = "검사차수")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapMinWidth(80)]
        public int INSP_SEQ { get; set; }


        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapMaxWidth(200)]
        public string HU_NO { get; set; }

        [Display(Name = "바코드")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(200)]
        [StrapMaxWidth(200)]
        public string HU_BARCODE { get; set; }

        [Display(Name = "검사분류")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string INSP_DV { get; set; }

        [Display(Name = "검사항목명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string INSP_NM { get; set; }

        [Display(Name = "검사규격")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string INSP_SPEC { get; set; }

        [Display(Name = "하한")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string LOWER_LIMIT { get; set; }

        [Display(Name = "기준값")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string BASE_VALUE { get; set; }

        [Display(Name = "상한")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string UPPER_LIMIT { get; set; }

        [Display(Name = "검사방법")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string INSP_METHOD { get; set; }

        [Display(Name = "측정값유형")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapMinWidth(80)]
        public string INSP_VAL_TYPE { get; set; }

        [Display(Name = "측정값")]
        [StrapMinWidth(80)]
        public string INSP_VAL_QC { get; set; }

        [Display(Name = "판정")]
        [StrapMinWidth(80)]

        public string INSP_JUDGE_QC { get; set; }

        [Display(Name = "검사수량")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapDisableParam]
        public decimal INSP_QTY { get; set; }


        [Display(Name = "검사값(생산)")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_VAL_PC { get; set; }


        [Display(Name = "합/부판정(생산)")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_JUDGE_PC { get; set; }


        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        [StrapMemoEdit]
        public override string REMARK { get; set; }

        [Display(Name = "수정일시")]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]


        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string MODIFY_USER_ID { get; set; }
    }
}
