using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.PurOrderInp
{
    public class PurOrderInpModel : ModelBase
    {
        [Display(Name = "발주일자")]
        public DateTime POH_DT { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "공장코드")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "발주수량")]
        [StrapGridSummary(Sum = true)]
        public decimal POD_QTY { get; set; }
        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal IN_QTY { get; set; }
        [Display(Name = "차이")]
        [StrapGridSummary(Sum = true)]
        public decimal DIFF_QTY { get; set; }
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }
    }
}
