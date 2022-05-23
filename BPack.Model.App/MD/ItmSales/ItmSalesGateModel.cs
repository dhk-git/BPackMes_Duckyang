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

namespace BPack.Model.App.MD.ItmSales
{
    public class ItmSalesGateModel : ModelBase
    {

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }

        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BP_CD_KEY { get; set; }
        [Display(Name = "거래처코드")]
        public string BP_CD { get; set; }
        [Display(Name = "거래처명")]
        public string BP_NM { get; set; }
        [Display(Name = "매입여부")]
        [StrapVisible(false, false, false)]
        public string IS_PURCHASE { get; set; }
        [Display(Name = "매출여부")]
        [StrapVisible(false, false, false)]
        public string IS_SALES { get; set; }
        [Display(Name = "주소")]
        public string ADDR { get; set; }
    }
}
