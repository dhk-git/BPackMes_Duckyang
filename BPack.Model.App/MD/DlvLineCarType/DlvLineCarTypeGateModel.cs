using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MD.DlvLineCarType
{
    public class DlvLineCarTypeGateModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DLV_PLC_CD_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }

        [Display(Name = "거래처명")]
        public string BP_NM { get; set; }

        [Display(Name = "매출처코드")]
        [StrapVisible(false, false, false)]
        public string GATE_CD { get; set; }
        [Display(Name = "매출처명")]
        [StrapMinWidth(150)]
        public string GATE_NM { get; set; }

        [Display(Name = "납품장소코드")]
        [StrapMinWidth(100)]
        public string DLV_PLC_CD { get; set; }
        [Display(Name = "납품장소명")]
        [StrapMinWidth(150)]
        public string DLV_PLC_NM { get; set; }
        [Display(Name = "자동출하여부")]
        [StrapVisible(false, false, false)]
        public string DLV_AUTO_FG { get; set; }
        [Display(Name = "고객사품번체크여부")]
        [StrapVisible(false, false, false)]
        public string CHK_CUST_FG { get; set; }
        [Display(Name = "자동출하창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "자동출하위치코드")]
        [StrapVisible(false, false, false)]
        public string LOC_CD { get; set; }
        [Display(Name = "출하검사옵션")]
        [StrapVisible(false, false, false)]
        public string INSP_OPT { get; set; }

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
