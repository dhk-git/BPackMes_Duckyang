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
    public class MrpdModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MRD_NO_KEY { get; set; }
        [Display(Name = "자재소요계획상세번호")]
        public string MRD_NO { get; set; }
        [Display(Name = "자재소요계획번호")]
        public string MRH_NO { get; set; }
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }
        [Display(Name = "년")]
        public string YEAR_CD { get; set; }
        [Display(Name = "주차")]
        public int WEEK_CD { get; set; }
        [Display(Name = "주차시작일")]
        public DateTime WEEK_START_DT { get; set; }
        [Display(Name = "주차종료일")]
        public DateTime WEEK_END_DT { get; set; }
        [Display(Name = "구매요청수량")]
        public decimal POE_QTY { get; set; }
        [Display(Name = "발주수량")]
        public decimal POD_QTY { get; set; }
        [Display(Name = "미착품수량")]
        public decimal PAC_QTY { get; set; }
        [Display(Name = "안전재고수량")]
        public decimal SAFETY_QTY { get; set; }
        [Display(Name = "소요량")]
        public decimal USAGE_QTY { get; set; }
        [Display(Name = "과부족")]
        public decimal DIFF_QTY { get; set; }       //계산
        [Display(Name = "예상재고")]    
        public decimal PLAN_STOCK_QTY { get; set; } //계산
        public bool IsLeadTimeCheckCell { get; set; } = false;
        public bool IsLeadTimeOverCell { get; set; } = false;
        public bool IsPorCheckCell { get; set; } = false;
    }
}
