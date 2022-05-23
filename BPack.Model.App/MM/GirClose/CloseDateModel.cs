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

namespace BPack.Model.App.MM.GirClose
{
    public class CloseDateModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "마감일자")]
        public DateTime CLOSE_DT { get; set; }
        [Display(Name = "마감상태")]
        [StrapDisableParam]
        public string GIR_CLOSE_STATUS { get; set; }
        [Display(Name = "사용여부")]
        [StrapVisible(false, false, false)]     
        public virtual bool VALID { get; set; } = true;
        [Display(Name = "비고")]
        [StrapMemoEdit]
        [StrapMinWidth(200)]
        public virtual string REMARK { get; set; }
        [Display(Name = "정렬순서")]
        [StrapVisible(false, false, false)]
        public virtual float SORT_NO { get; set; }
        [Display(Name = "일련번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapDisableParam]
        public virtual int ROW_SEQ { get; set; }
        [Display(Name = "생성일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public virtual DateTime? CREATE_DTTM { get; set; } 
        [Display(Name = "생성자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [StrapLookUpEditAllUsers]
        public virtual string CREATE_USER_ID { get; set; }
        [Display(Name = "수정일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        [ReadOnly(true)]
        public virtual DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public virtual string MODIFY_USER_ID { get; set; }
        [Display(Name = "언어코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public virtual string LANG_CODE { get; set; } = Common.LoginInfo.UserInfo.Sys_Language;
    }
}
