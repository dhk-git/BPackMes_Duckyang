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

namespace BPack.Model.App.SD.SalesOrderHist
{
    public class SalesOrderHistDetailModel : ModelBase
    {

        [Display(Name = "주문일자")]
        public string SOR_DT { get; set; }
        [StrapVisible(false, false, false)]
        public string SOR_NO { get; set; }
        [Display(Name = "고객사코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "고객사")]
        public string BP_NM { get; set; }
        [Display(Name = "발주번호")]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품목코드")]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapVisible(false, false, false)]
        public string ITEM_NM { get; set; }
        [Display(Name = "사양")]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "제품군")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "주문수량")]
        public decimal SOD_QTY { get; set; }
        [Display(Name = "단가")]
        public decimal SOD_PRICE { get; set; }
        [Display(Name = "금액")]
        public decimal COST { get; set; }
        [Display(Name = "단위")]
        public string CURRENCY_TYPE { get; set; }
        [Display(Name = "납기일")]
        public DateTime DUE_DT { get; set; }

        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string SOD_NO_KEY { get; set; }
        //[Display(Name = "주문접수상세번호")]
        //public string SOD_NO { get; set; }
        //[Display(Name = "주문접수번호")]
        //public string SOR_NO { get; set; }
        //[Display(Name = "주문접수상세등록번호")]
        //public int SOD_SEQ { get; set; }
        //[Display(Name = "고객발주번호")]
        //public string CUSTOM_PO_NO { get; set; }
        //[Display(Name = "회사코드")]
        //public string COMP_CD { get; set; }
        //[Display(Name = "공장코드")]
        //public string PLANT_CD { get; set; }
        //[Display(Name = "품목코드")]
        //public string ITEM_CD { get; set; }

        //[Display(Name = "품목명")]
        //public string ITEM_NM   {get;set;}
        //[Display(Name = "규격")]
        //public string ITEM_SPEC {get;set;}
        //[Display(Name = "제품군")]
        //public string ITEM_GR_1 { get; set; }
        //[Display(Name = "주문일자")]
        //public DateTime SOR_DT { get; set; }
        //[Display(Name = "주문수량")]
        //public decimal SOD_QTY { get; set; }
        //[Display(Name = "단가")]
        //public decimal SOD_PRICE { get; set; }
        //[Display(Name = "통화(시스템코드)")]
        //public string CURRENCY_TYPE { get; set; }
        //[Display(Name = "납기일")]
        //public DateTime DUE_DT { get; set; }
        //[Display(Name = "주문접수상세상태")]
        //public string SOD_STATUS { get; set; }
        //[Display(Name = "납품진행상태")]
        //public string SOD_DLV_STATUS { get; set; }
        //[Display(Name = "비고")]
        //public string REMARK { get; set; }
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
