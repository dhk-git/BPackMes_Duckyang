using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PO.Mrp
{
    public class MrpmModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MRH_NO_KEY { get; set; }
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
        [Display(Name = "자재소요계획번호")]
        public string MRH_NO { get; set; }
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "규격")]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "리드타임(주)")]
        public int LT { get; set; }
        [Display(Name = "현재고")]
        public decimal WH_STOCK_QTY { get; set; }
        [Display(Name = "미착품")]
        public decimal NON_ARRIVAL_QTY { get; set; }
        [Display(Name = "안전재고기간")]
        public decimal SAFETY_TERM { get; set; }
        [Display(Name = "발주필요수량")]
        public decimal TO_POR_QTY { get; set; }
        [Display(Name = "구분코드")]
        public string MRP_CLS_CD { get; set; }
        [Display(Name = "구분")]
        public string MRP_CLS_NM { get; set; }
        [Display(Name = "정렬순서")]
        public int MRP_CLS_SORT_NO { get; set; }
    }
}
