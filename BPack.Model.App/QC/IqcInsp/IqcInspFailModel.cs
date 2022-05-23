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

namespace BPack.Model.App.QC.IqcInsp
{
    public class IqcInspFailModel : ModelBase
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string IQD_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int DEFECT_SEQ_KEY { get; set; } 
        [Display(Name = "입고검사상세번호")]
        public string IQD_NO { get; set; }
        [Display(Name = "순번")]
        public int DEFECT_SEQ { get; set; }
        [Display(Name = "불량유형")]
        public string DEFECT_CD { get; set; }
        [Display(Name = "귀책코드")]
        public string IQC_RESPON_CD { get; set; }

        [Range(1,Int32.MaxValue)]
        [Display(Name = "불량수량")]
        public int DEFECT_QTY { get; set; }
        [Display(Name = "비고")]
        [StrapMinWidth(150)]
        public string REMARK { get; set; }

        [Display(Name = "생성일시")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime CREATE_DTTM { get; set; } = DateTime.Now;
        [Display(Name = "수정일시")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime MODIFY_DTTM { get; set; } = DateTime.Now;
        [Display(Name = "생성자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string CREATE_USER_ID { get; set; } = Common.LoginInfo.UserInfo.UserID;
        [Display(Name = "수정자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string MODIFY_USER_ID { get; set; } = Common.LoginInfo.UserInfo.UserID;

    }
}
