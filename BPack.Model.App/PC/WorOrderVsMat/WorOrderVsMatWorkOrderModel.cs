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

namespace BPack.Model.App.PC.WorOrderVsMat
{
    public class WorOrderVsMatWorkOrderModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }


        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "규격")]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }

        [Display(Name = "품목유형")]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE { get; set; }
        
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        
        [Display(Name = "제품군")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_2 { get; set; }

        [Display(Name = "서열유형")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_3 { get; set; }

        [Display(Name = "ALC코드")]
        public string ALC_CD { get; set; }


        [Display(Name = "지시수량")]
        [StrapGridSummary(Sum = true)]
        public decimal WOR_QTY { get; set; }

        [Display(Name = "1T")]
        [StrapGridSummary(Sum = true)]
        public decimal A_TIME_QTY { get; set; }
        [Display(Name = "2T")]
        [StrapGridSummary(Sum = true)]
        public decimal B_TIME_QTY { get; set; }
        [Display(Name = "3T")]
        [StrapGridSummary(Sum = true)]
        public decimal C_TIME_QTY { get; set; }
        [Display(Name = "4T")]
        [StrapGridSummary(Sum = true)]
        public decimal D_TIME_QTY { get; set; }
        [Display(Name = "5T")]
        [StrapGridSummary(Sum = true)]
        public decimal E_TIME_QTY { get; set; }

        [Display(Name = "지시일자")]
        [StrapVisible(false, false, false)]
        public DateTime WO_DT { get; set; }

        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }
    }
}
