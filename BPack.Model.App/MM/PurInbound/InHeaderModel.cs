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
    public class InHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PIH_NO_KEY { get; set; }
        [Display(Name = "구매입고번호")]
        [StrapDenyEdit]
        public string PIH_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "거래처")]
        [Required]
        public string BP_CD { get; set; }
        [Display(Name = "입고공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "납입카드번호")]
        [StrapVisible(false, false, false)]
        public string INVOICE_NO { get; set; }
        [Display(Name = "처리일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDenyEdit]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "입고처리상태")]
        [StrapDenyEdit]
        public string PIH_STATUS { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; } = "N";
    }

}
