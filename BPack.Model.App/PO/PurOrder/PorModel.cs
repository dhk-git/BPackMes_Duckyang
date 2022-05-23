using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.PurOrder
{
    public class PorModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string POE_NO_KEY { get; set; }
        [Display(Name = "구매요청서상세번호")]
        [StrapDenyEdit]
        public string POE_NO { get; set; }
        [Display(Name = "구매요청서번호")]
        [StrapDenyEdit]
        public string POR_NO { get; set; }
        [Display(Name = "거래처")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapDenyEdit]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDenyEdit]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "요청수량")]
        [StrapDenyEdit]
        public decimal POE_QTY { get; set; }
        [Display(Name = "발주수량")]
        [StrapDenyEdit]
        public decimal PUR_QTY { get; set; }

        [Display(Name = "구매요청서상세상태")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string POE_STATUS { get; set; }
        [Display(Name = "발주시한")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public DateTime? PUR_DUE_DT { get; set; }
        [Display(Name = "요청납기")]
        [StrapDenyEdit]
        public DateTime POE_DUE_DT { get; set; }
    }
}
