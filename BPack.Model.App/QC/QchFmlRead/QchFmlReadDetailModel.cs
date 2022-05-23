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

namespace BPack.Model.App.QC.QchFmlRead
{
    public class QchFmlReadDetailModel : ModelBase_CommonColumns
    {
        [Display(Name = "검사번호")]
        [StrapVisible(false, false, false)]
        public string INSP_NO { get; set; }

        //검사분류
        [Display(Name = "검사분류(공통코드)")]
        public string INSP_DV { get; set; }

        [Display(Name = "검사항목")]
        public string INSP_ID { get; set; }
        
        [Display(Name = "검사항목명")]
        public string INSP_NM { get; set; }

        //검사규격
        [Display(Name = "검사규격")]
        public string INSP_SPEC { get; set; }

        [Display(Name = "검사차수")]
        [StrapVisible(false, false, false)]
        public int INSP_SEQ { get; set; }
        [Display(Name = "식별표번호")]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }
        [Display(Name = "검사수량")]
        [StrapVisible(false, false, false)]
        public decimal INSP_QTY { get; set; }

        //하한값
        [Display(Name = "하한")]
        public string LOWER_LIMIT { get; set; }
        //기준값
        [Display(Name = "기준값")]
        public string BASE_VALUE { get; set; }
        //상한값
        [Display(Name = "상한")]
        public string UPPER_LIMIT { get; set; }

        //검사방법
        [Display(Name = "검사방법(공통코드)")]
        public string INSP_METHOD { get; set; }
        [Display(Name = "측정값유형(공통코드)")]
        //측정값유형
        public string INSP_VAL_TYPE { get; set; }

        [Display(Name = "검사값(생산)")]
        public string INSP_VAL_PC { get; set; }
        [Display(Name = "합/부판정(생산)")]
        public string INSP_JUDGE_PC { get; set; }

        [Display(Name = "검사값(품질)")]
        public string INSP_VAL_QC { get; set; }

        [Display(Name = "합/부판정(품질)")]
        public string INSP_JUDGE_QC { get; set; }

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
