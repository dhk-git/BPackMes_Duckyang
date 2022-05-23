using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.QC.AppLine
{
    public class AppLineModel : ModelBase
    {
        [Display(Name = "결재선번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string APP_LINE_NO { get; set; }

        [Display(Name = "요청자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string APP_USER_ID_REQ { get; set; }

        [Display(Name = "검토자")]
        public string APP_USER_ID_REV { get; set; }

        [Display(Name = "승인자")]
        public string APP_USER_ID_APP { get; set; }

        [Display(Name = "삭제FLAG(Y=삭제)")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }

        [Display(Name = "생성일시")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime CREATE_DTTM { get; set; }
        
        [Display(Name = "수정일시")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime MODIFY_DTTM { get; set; }
        
        [Display(Name = "생성자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string CREATE_USER_ID { get; set; }
        
        [Display(Name = "수정자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string MODIFY_USER_ID { get; set; }

    }
}
