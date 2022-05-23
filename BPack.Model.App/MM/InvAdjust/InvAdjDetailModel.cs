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
    public class InvAdjDetailModel : ModelBase_CommonColumns
    {
        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string INVD_NO_KEY { get; set; }
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "실사지시번호")]
        [StrapVisible(false, false, false)]
        public string INV_NO { get; set; }
        [Display(Name = "창고코드")]
        [StrapDisableParam]
        public string WH_CD { get; set; }
        [Display(Name = "위치코드")]
        [StrapDisableParam]
        public string LOC_CD { get; set; }
        [Display(Name = "실사그룹")]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string INV_GR { get; set; }
        [Display(Name = "실사지시상세상태")]
        [StrapDisableParam]
        public string INVD_STATUS { get; set; }
        [Display(Name = "시작일시")]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public DateTime START_DTTM { get; set; }
        [Display(Name = "완료일시")]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "반영일시")]
        [StrapDisableParam]
        public DateTime? ADJ_DTTM { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string DEL_FG { get; set; }
        [Display(Name = "실사지시상세번호")]
        public string INVD_NO { get; set; }
    }
}
