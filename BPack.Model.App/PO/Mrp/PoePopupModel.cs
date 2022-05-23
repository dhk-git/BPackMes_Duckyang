using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.Mrp
{
    public class PoePopupModel
    {
        [Display(Name = "구매요청번호")]
        public string POR_NO { get; set; }
        [Display(Name = "요청일자")]
        public DateTime POR_DT { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "요청수량")]
        public decimal POE_QTY { get; set; }
        [Display(Name = "요청납기일")]
        public DateTime POE_DUE_DT { get; set; }
    }
}
