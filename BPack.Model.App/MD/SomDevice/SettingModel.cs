using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.SomDevice
{
    public class SettingModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DVC_ID_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MODE_ID_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DVCS_CD_KEY { get; set; }
        [Display(Name = "단말기ID")]
        [StrapVisible(false, false, false)]
        public string DVC_ID { get; set; }
        [Display(Name = "모드ID")]
        [StrapVisible(false, false, false)]
        public string MODE_ID { get; set; }
        [Display(Name = "항목코드")]
        [StrapDenyEdit]
        public string DVCS_CD { get; set; }
        [Display(Name = "항목명")]
        [StrapDisableParam]
        public string DVCS_NM { get; set; }
        [Display(Name = "설정값1")]
        public string DVCS_VALUE_1 { get; set; }
        [Display(Name = "설정값2")]
        public string DVCS_VALUE_2 { get; set; }
        [Display(Name = "설정값3")]
        public string DVCS_VALUE_3 { get; set; }
        [Display(Name = "설정값4")]
        public string DVCS_VALUE_4 { get; set; }
        [Display(Name = "설정값5")]
        public string DVCS_VALUE_5 { get; set; }
        [Display(Name = "비고")]
        public override string REMARK { get => base.REMARK ; set => base.REMARK = value; }
        [Display(Name = "설정값1설명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapToolTip("시스템코드 \"단말기설정항목\"에 작성된 내용입니다.")]
        public string VALUE_1_DESC { get; set; }
        [Display(Name = "설정값2설명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapToolTip("시스템코드 \"단말기설정항목\"에 작성된 내용입니다.")]
        public string VALUE_2_DESC { get; set; }
        [Display(Name = "설정값3설명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapToolTip("시스템코드 \"단말기설정항목\"에 작성된 내용입니다.")]
        public string VALUE_3_DESC { get; set; }
        [Display(Name = "설정값4설명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapToolTip("시스템코드 \"단말기설정항목\"에 작성된 내용입니다.")]
        public string VALUE_4_DESC { get; set; }
        [Display(Name = "설정값5설명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapToolTip("시스템코드 \"단말기설정항목\"에 작성된 내용입니다.")]
        public string VALUE_5_DESC { get; set; }
        [Display(Name = "설명비고")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapToolTip("시스템코드 \"단말기설정항목\"에 작성된 내용입니다.")]
        public string REMARK_DESC { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }

    }
}
