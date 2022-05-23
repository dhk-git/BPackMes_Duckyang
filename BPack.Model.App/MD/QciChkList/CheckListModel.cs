using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MD.QciChkList
{
    public class CheckListModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_ID_KEY { get; set; }
        [StrapMinWidth(80)]
        [Display(Name = "검사항목코드")]
        [ReadOnly(true)]
        public string INSP_ID { get; set; }
        [StrapMinWidth(150)]
        [Display(Name = "검사항목명")]
        public string INSP_NM { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [StrapMinWidth(130)]
        [Display(Name = "검사분류")]
        public string INSP_DV { get; set; }
        [StrapMinWidth(130)]
        [Display(Name = "검사방법")]
        public string INSP_METHOD { get; set; }
        [StrapMinWidth(100)]
        [Display(Name = "측정값유형")]
        public string INSP_VAL_TYPE { get; set; }
        [Display(Name = "단위")]
        public string UNIT { get; set; }

        [Display(Name = "수정일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        [StrapVisible(false, false, false)]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        [StrapVisible(false, false, false)]
        public override string MODIFY_USER_ID { get; set; }
    }
}
