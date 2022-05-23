using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.Mrp
{
    public class PoPopupModel
    {
        [Display(Name = "발주번호")]
        public string POH_NO { get; set; }
        [Display(Name = "발주일자")]
        public DateTime POH_DT { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "발주수량")]
        public decimal POD_QTY { get; set; }
        [Display(Name = "발행수량")]
        public decimal INTO_PAC_QTY { get; set; }
        [Display(Name = "발주잔량")]
        public decimal DIFF_QTY { get; set; }
        [Display(Name = "납기일")]
        public DateTime DUE_DT { get; set; }
    }
}
