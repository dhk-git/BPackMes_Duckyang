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

namespace BPack.Model.App.PC.WorOrderRead
{
    public class WorOrderReadHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WO_NO_KEY { get; set; }
        [Display(Name = "라우팅번호")]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "작지번호(ERP)")]
        public string CUSTOM_WO_NO { get; set; }
        [Display(Name = "작지번호(MES)")]
        public string WO_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "계획일자")]
        public DateTime WO_DT { get; set; }

        [Display(Name = "종료일자")]
        [StrapVisible(false, false, false)]
        public DateTime CLOSE_DT { get; set; }

        [Display(Name = "근무조")]
        public string SHIFT_CD { get; set; }

        [Display(Name = "라인")]
        public string PARENT_WC_CD { get; set; }

        [Display(Name = "작업장")]
        public string WC_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapMinWidth(150)]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC코드")]
        public string ALC_CD { get; set; }


        [Display(Name = "지시수량")]
        [StrapGridSummary(Sum = true)]
        public decimal WOR_QTY { get; set; }

        [Display(Name = "1T")]
        [StrapGridSummary(Sum = true)]
        public decimal A_TIME_QTY { get; set; }
        [Display(Name = "2T")]
        [StrapGridSummary(Sum = true)]
        public decimal B_TIME_QTY { get; set; }
        [Display(Name = "3T")]
        [StrapGridSummary(Sum = true)]
        public decimal C_TIME_QTY { get; set; }
        [Display(Name = "4T")]
        [StrapGridSummary(Sum = true)]
        public decimal D_TIME_QTY { get; set; }
        [Display(Name = "5T")]
        [StrapGridSummary(Sum = true)]
        public decimal E_TIME_QTY { get; set; }

        

        [Display(Name = "작업지시서상태(SYS_CODE)")]
        [StrapVisible(false, false, false)]
        public string WO_STATUS { get; set; }

        [Display(Name = "UnitPerHour")]
        [StrapVisible(false, false, false)]
        public decimal UPH_QTY { get; set; }


        //[Display(Name = "비고")]
        //public string REMARK { get; set; }
        //[Display(Name = "삭제FLAG(Y=삭제)")]
        //public string DEL_FG { get; set; }
        //[Display(Name = "생성일시")]
        //public DateTime CREATE_DTTM { get; set; }
        //[Display(Name = "수정일시")]
        //public DateTime MODIFY_DTTM { get; set; }
        //[Display(Name = "생성자")]
        //public string CREATE_USER_ID { get; set; }
        //[Display(Name = "수정자")]
        //public string MODIFY_USER_ID { get; set; }

    }
}
