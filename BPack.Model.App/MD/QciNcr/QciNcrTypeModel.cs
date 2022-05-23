using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MD.QciNcr
{
    public class QciNcrTypeModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NCR_TYPE_KEY { get; set; }
        [Display(Name = "부적합유형코드")]
        public string NCR_TYPE { get; set; }
        [Display(Name = "부적합유형명")]
        [StrapMinWidth(200)]
        public string NCR_DESC { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public override string DEL_FG { get; set; } = "N";
        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        [StrapMemoEdit]
        [StrapMinWidth(200)]
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
