using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WorWorkOrder
{
    public class WorkOrderHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WO_NO_KEY { get; set; }
        [Display(Name = "작업지시번호")]
        [ReadOnly(true)]
        public string WO_NO { get; set; }
        [Display(Name = "작업장")]
        public string WC_CD { get; set; }
        [Display(Name = "라우팅번호")]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "종료일자")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime? CLOSE_DT { get; set; }
        [Display(Name = "지시일자")]
        public DateTime WO_DT { get; set; }
        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }
        [Display(Name = "UPH")]
        public decimal UPH_QTY { get; set; }

        [Display(Name = "지시수량")]
        public decimal WOR_QTY { get; set; }
        [Display(Name = "1T")]
        public decimal A_TIME_QTY { get; set; }
        [Display(Name = "2T")]
        public decimal B_TIME_QTY { get; set; }
        [Display(Name = "3T")]
        public decimal C_TIME_QTY { get; set; }
        [Display(Name = "4T")]
        public decimal D_TIME_QTY { get; set; }
        [Display(Name = "5T")]
        public decimal E_TIME_QTY { get; set; }

        [Display(Name = "작업지시서상태")]
        [StrapVisible(false, false, false)]
        public string WO_STATUS { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
    }
}
