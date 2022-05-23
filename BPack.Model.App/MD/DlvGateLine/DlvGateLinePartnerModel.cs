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

namespace BPack.Model.App.MD.DlvGateLine
{
    public class DlvGateLinePartnerModel : ModelBase_CommonColumns_With_DelFlag
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "매출처코드")]
        [StrapMinWidth(100)]
        public string GATE_CD { get; set; }
        [Display(Name = "매출처명")]
        [StrapMinWidth(150)]
        public string GATE_NM { get; set; }
        [Display(Name = "거래처코드")]
        public string BP_CD { get; set; }
        [Display(Name = "매입여부")]
        [StrapVisible(false, false, false)]
        public bool IS_PURCHASE { get; set; }
        [Display(Name = "매출여부")]
        [StrapVisible(false, false, false)]
        public bool IS_SALES { get; set; }
        [Display(Name = "납품창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "납품위치코드")]
        [StrapVisible(false, false, false)]
        public string LOC_CD { get; set; }
        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        public override string REMARK { get; set; }
        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; }
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; }

        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public override string DEL_FG { get; set; } = "N";

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
