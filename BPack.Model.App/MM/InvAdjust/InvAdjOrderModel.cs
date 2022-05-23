using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.InvAdjust
{
    public class InvAdjOrderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INV_NO_KEY { get; set; }
        [Display(Name = "회사")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "실사지시번호")]
        public string INV_NO { get; set; }
        [Display(Name = "실사형태")]
        public string INV_TYPE { get; set; }
        [Display(Name = "창고")]
        public string TARGET_WH_CD { get; set; }
        [Display(Name = "실사그룹")]
        
        public string TARGET_INV_GR { get; set; }
        [Display(Name = "기준일자")]
        public DateTime TARGET_GIR_DT { get; set; }
        [Display(Name = "지시일시")]
        public DateTime ORDER_DTTM { get; set; }
        [Display(Name = "완료일시")]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "실사지시상태")]
        public string INV_STATUS { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
    }
}
