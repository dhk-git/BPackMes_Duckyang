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
    public class PurInpDetailModel : ModelBase
    {
        [Display(Name = "발주상세번호")]
        public string POD_NO { get; set; }
        [Display(Name = "패킹리스트번호")]
        public string PAC_NO { get; set; }
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
        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal IN_QTY { get; set; }
        [Display(Name = "납기일")]
        public DateTime DUE_DT { get; set; }
        [Display(Name = "입고일자")]
        public DateTime CLOSE_DT { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string BARCODE_NO { get; set; }
    }
}
