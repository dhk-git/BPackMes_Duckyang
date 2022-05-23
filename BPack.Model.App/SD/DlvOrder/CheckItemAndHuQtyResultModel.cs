using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvOrder
{
    public class CheckItemAndHuQtyResultModel
    {
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
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "지시수량")]
        public decimal DOD_QTY { get; set; }
        [Display(Name = "예약수량")]
        public decimal RESERVED_QTY { get; set; }
        [Display(Name = "차이")]
        public decimal DIFF_QTY { get; set; }
    }
}
