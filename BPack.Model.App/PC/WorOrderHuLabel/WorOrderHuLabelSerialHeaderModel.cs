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

namespace BPack.Model.App.PC.WorOrderHuLabel
{
    public class WorOrderHuLabelSerialHeaderModel : ModelBase
    {
        [Display(Name = "지시일자")]
        public DateTime WO_DT { get; set; }

        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }
        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC코드")]
        public string ALC_CD { get; set; }

        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }
        [Display(Name = "작업지시수량")]
        [StrapGridSummary(Sum = true)]
        public decimal WOR_QTY { get; set; }

        [Display(Name = "생산수량")]
        [StrapGridSummary(Sum = true)]
        public decimal IN_QTY { get; set; }

        [Display(Name = "발행된 수량")]
        [StrapGridSummary(Sum = true)]
        [StrapDisableParam]
        [StrapDenyEdit]
        public decimal PRINTED_QTY { get; set; }
    }
}
