using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.Mrp
{
    public class PacPopupModel
    {
        [Display(Name ="InvoiceNo")]
        public string INVOICE_NO { get; set; }
        [Display(Name = "선적일자")]
        public DateTime INVOICE_DT { get; set; }
        [Display(Name = "도착예정일")]
        public DateTime ETA_DT { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "수량")]
        public decimal PAC_QTY { get; set; }
        [Display(Name = "바코드번호")]
        public string BARCODE_NO { get; set; }
    }
}

