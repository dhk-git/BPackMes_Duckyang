using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirInv
{
    public class InvDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INV_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ITEM_CD_KEY { get; set; }
        [Display(Name = "재고실사번호")]
        [StrapVisible(false, false, false)]
        public string INV_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapDenyEdit]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "기준일재고")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public decimal CLOSE_STOCK_QTY { get; set; }
        [Display(Name = "이후입고수량")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public decimal AFTER_GR_QTY { get; set; }
        [Display(Name = "이후출고수량")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public decimal AFTER_GI_QTY { get; set; }
        [Display(Name = "전산재고")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public decimal LOGI_STOCK_QTY { get; set; }
        [Display(Name = "실재고")]
        public decimal PHYSI_STOCK_QTY { get; set; }
        [Display(Name = "차이")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public decimal DIFF_QTY { get; set; }

    }
}
