using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WorOrderVsMat
{
    public class WorOrderVsMatMaterialModel : ModelBase
    {
        [Display(Name = "지시일자(계획일자)")]
        [StrapVisible(false, false, false)]
        public DateTime WO_DT { get; set; }

        [Display(Name = "자재입고창고")]
        [StrapVisible(false, false, false)]
        public string MAT_WH_CD { get; set; }
        [Display(Name = "창고/위치")]
        public string MAT_LOC_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "현재고")]
        public decimal LOC_STOCK_QTY { get; set; }

        [Display(Name = "구분")]
        public string GUBUN { get; set; }

        [Display(Name = "지시수량")]
        [StrapVisible(false, false, false)]
        public decimal WOR_QTY { get; set; }

        [Display(Name = "소요량")]
        [StrapVisible(false, false, false)]
        public decimal OPER_QTY { get; set; }

        [Display(Name = "주간-1T")]
        public decimal D_A_TIME_QTY { get; set; }
        [Display(Name = "주간-2T")]
        public decimal D_B_TIME_QTY { get; set; }
        [Display(Name = "주간-3T")]
        public decimal D_C_TIME_QTY { get; set; }
        [Display(Name = "주간-4T")]
        public decimal D_D_TIME_QTY { get; set; }
        [Display(Name = "주간-5T")]
        public decimal N_E_TIME_QTY { get; set; }
        [Display(Name = "야간-1T")]
        public decimal N_A_TIME_QTY { get; set; }
        [Display(Name = "야간-2T")]
        public decimal N_B_TIME_QTY { get; set; }
        [Display(Name = "야간-3T")]
        public decimal N_C_TIME_QTY { get; set; }
        [Display(Name = "야간-4T")]
        public decimal N_D_TIME_QTY { get; set; }
        [Display(Name = "야간-5T")]
        public decimal D_E_TIME_QTY { get; set; }

        [Display(Name = "합계")]
        public decimal? TOTAL_QTY { get; set; }


    }
}
