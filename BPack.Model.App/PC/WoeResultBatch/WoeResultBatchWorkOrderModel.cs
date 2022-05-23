using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResultBatch
{
    public class WoeResultBatchWorkOrderModel : ModelBase_CommonColumns_With_CompCD_PlantCD
    {
        [Display(Name = "작지번호(MES)")]
        public string WO_NO { get; set; }
        [Display(Name = "라우팅번호")]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "작지번호(ERP)")]
        public string CUSTOM_WO_NO { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "종료일자")]
        [StrapVisible(false, false, false)]
        public DateTime CLOSE_DT { get; set; }
        [Display(Name = "계획일자")]
        public DateTime WO_DT { get; set; }
        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }
        [Display(Name = "지시수량")]
        public decimal WOR_QTY { get; set; }
        [Display(Name = "A-TIME 수량")]
        [StrapVisible(false, false, false)]
        public decimal A_TIME_QTY { get; set; }
        [Display(Name = "B-TIME 수량")]
        [StrapVisible(false, false, false)]
        public decimal B_TIME_QTY { get; set; }
        [Display(Name = "C-TIME 수량")]
        [StrapVisible(false, false, false)]
        public decimal C_TIME_QTY { get; set; }
        [Display(Name = "D-TIME 수량")]
        [StrapVisible(false, false, false)]
        public decimal D_TIME_QTY { get; set; }
        [Display(Name = "E-TIME 수량")]
        [StrapVisible(false, false, false)]
        public decimal E_TIME_QTY { get; set; }
        [Display(Name = "작업지시서상태")]
        [StrapVisible(false, false, false)]
        public string WO_STATUS { get; set; }
        [Display(Name = "UnitPerHour")]
        [StrapVisible(false, false, false)]
        public decimal UPH_QTY { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }

    }
}
