using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirInv
{
    public class StockModel
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "기준일재고")]
        public decimal WH_STOCK_QTY { get; set; }
        [Display(Name = "이후입고수량")]
        public decimal AFTER_GR_QTY { get; set; }
        [Display(Name = "이후출고수량")]
        public decimal AFTER_GI_QTY { get; set; }
        [Display(Name = "전산재고")]
        public decimal LOGI_QTY { get; set; }
    }
}
