using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeHuModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string RST_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [Display(Name = "생산실적번호")]
        [StrapVisible(false, false, false)]
        public string RST_NO { get; set; }
        [Display(Name = "식별표형태")]
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string HU_TYPE { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "최초수량")]
        [StrapDisableParam]
        public decimal HU_INIT_QTY { get; set; }
        [Display(Name = "현재수량")]
        [StrapDisableParam]
        public decimal HU_STOCK_QTY { get; set; }
        [Display(Name = "양품/불량")]
        public string OK_NG { get; set; }
        [Display(Name = "적입식별표번호")]
        [StrapDisableParam]
        public string PARENT_HU_NO { get; set; }
    }
}
