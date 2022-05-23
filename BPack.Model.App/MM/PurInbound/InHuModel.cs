using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.PurInbound
{
    public class InHuModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PID_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [Display(Name = "구매입고상세번호")]
        public string PID_NO { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "구매입고번호")]
        public string PIH_NO { get; set; }
        [Display(Name = "입고상태(SYS_CODE)")]
        public string INHU_IN_STATUS { get; set; }
        [Display(Name = "입고완료일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDenyEdit]
        public DateTime? IN_DTTM { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string DEL_FG { get; set; } = "N";
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string PLANT_CD { get; set; }
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string ITEM_CD { get; set; }
        [Display(Name = "수량")]
        [StrapDisableParam]
        public decimal GR_QTY { get; set; }

        [StrapVisible(false, false, false)]
        public override bool VALID { get; set; }
        [StrapVisible(false, false, false)]
        public override float SORT_NO { get; set; }
    }

}
