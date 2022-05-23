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
    public class QchDlvReadHeaderModel : ModelBase_CommonColumns
    {
        [Display(Name = "검사일자")]
        public DateTime INSP_DT_QC { get; set; }

        [Display(Name = "검사번호")]
        public string INSP_NO { get; set; }

        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품목명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "품목유형")]
        public string ITEM_TYPE { get; set; }

        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }

        [Display(Name = "식별표바코드")]
        [StrapMaxWidth(400)]
        public string HU_BARCODE { get; set; }

        [Display(Name = "검사수량")]
        public string INSP_QTY { get; set; }

        [Display(Name = "검사시간")]
        public string INSP_DTTM_QC { get; set; }

        [Display(Name = "판정")]
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
