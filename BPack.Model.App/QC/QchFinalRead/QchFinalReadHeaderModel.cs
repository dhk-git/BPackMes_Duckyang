using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.QC.QchFinalRead
{
    public class QchFinalReadHeaderModel : ModelBase_CommonColumns
    {
        [Display(Name = "생산일자")]
        public DateTime WO_DT { get; set; }

        [Display(Name = "근무조")]
        public string SHIFT_CD { get; set; }

        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }

        [Display(Name = "검사번호")]
        public string INSP_NO { get; set; }

        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }

        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품목명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }

        [Display(Name = "식별표바코드")]
        public string HU_BARCODE { get; set; }

        [Display(Name = "검사시간")]
        public string INSP_DTTM_QC { get; set; }
        [Display(Name = "합/부판정")]
        public string INSP_JUDGE_QC { get; set; }
        [Display(Name = "검사자")]
        public string EMP_QC { get; set; }

        [Display(Name = "비고")]
        [ReadOnly(true)]
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
