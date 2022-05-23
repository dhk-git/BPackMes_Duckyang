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
    public class SalesOrderHistModel : ModelBase
    {

        [Display(Name = "주문일자")]
        public DateTime SOR_DT { get; set; }
        [Display(Name = "고객사코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "고객사")]
        public string BP_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "주문수량")]
        public decimal SOD_QTY { get; set; }
        
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }
        [Display(Name = "단가")]
        public decimal COST { get; set; }
        [Display(Name = "통화")]
        public string CURRENCY_TYPE { get; set; }
        

    }
}
