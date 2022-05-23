using System;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PO.PurPack
{
    public class PurPackExcelUploadModel
    {
        //[Display(Name = "INVOICE NO")]
        //public string INVOICE_NO { get; set; }
        //[Display(Name = "INVOICE발행일자")]
        //public DateTime INVOICE_DT { get; set; }
        //[Display(Name = "DY발주번호")]
        //public string DY_PO_NO { get; set; }
        //[Display(Name = "발주상세번호")]
        //public string POD_NO { get; set; }
        [Display(Name = "순번")]
        public int SEQ { get; set; }
        [Display(Name = "대포장바코드번호")]
        public string BARCODE_NO { get; set; }
        [Display(Name = "오더번호")]
        public string ORDER_NO { get; set; }
        [Display(Name = "CASE_NO")]
        public string CASE_NO { get; set; }
        [Display(Name = "ARRIVAL_PORT")]
        public string ARRIVAL_PORT { get; set; }
        [Display(Name = "컨테이너번호")]
        public string CONTAINER_NO { get; set; }
        [Display(Name = "실번호")]
        public string SEAL_NO { get; set; }
        [Display(Name = "작업일")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "생성일자")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "적입수량")]
        public decimal PAC_QTY { get; set; }

    }
}
