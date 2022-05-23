using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.InvOrder
{
    public class InvDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INVD_NO_KEY { get; set; }
        [Display(Name = "실사지시번호")]
        [StrapVisible(false, false, false)]
        public string INV_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "위치코드")]
        public string LOC_CD { get; set; }
        [Display(Name = "실사그룹")]
        [StrapVisible(true, false, false)]
        public string INV_GR { get; set; }
        [Display(Name = "실사지시상세상태")]
        [StrapVisible(true, false, false)]
        public string INVD_STATUS { get; set; }
        [Display(Name = "시작일시")]
        [StrapVisible(false, false, false)]
        public DateTime START_DTTM { get; set; }
        [Display(Name = "완료일시")]
        [StrapVisible(false, false, false)]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "반영일시")]
        [StrapVisible(true, false, false)]
        public DateTime? ADJ_DTTM { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
        [Display(Name = "실사지시상세번호")]
        [StrapVisible(true, false, false)]
        public string INVD_NO { get; set; }
    }
}
