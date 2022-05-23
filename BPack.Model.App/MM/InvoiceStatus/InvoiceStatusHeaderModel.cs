using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.InvoiceStatus
{
    public class InvoiceStatusHeaderModel : ModelBase_CommonColumns
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "INVOICE NO")]
        public string INVOICE_NO { get; set; }

        [Display(Name = "선적일")]
        public DateTime? INVOICE_DT { get; set; }

        [Display(Name = "거래처")]
        public string BP_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "미도착")]
        public int PAC_DEPARTED { get; set; }

        [Display(Name = "입고대기")]
        public int PAC_WAIT { get; set; }

        [Display(Name = "입고등록중")]
        public int PAC_OPEN { get; set; }

        [Display(Name = "입고완료")]
        public int PAC_CLOSE { get; set; }
        
        [Display(Name = "강제종료")]
        [StrapHidden]
        public string PAC_DROP { get; set; }

        [Display(Name = "합계")]
        public int PAC_QTY { get; set; }

        [StrapHidden]
        public override DateTime? MODIFY_DTTM { get => base.MODIFY_DTTM; set => base.MODIFY_DTTM = value; }
        [StrapHidden]
        public override string MODIFY_USER_ID { get => base.MODIFY_USER_ID; set => base.MODIFY_USER_ID = value; }
        [StrapHidden]
        public override string REMARK { get => base.REMARK; set => base.REMARK = value; }
    }
}

