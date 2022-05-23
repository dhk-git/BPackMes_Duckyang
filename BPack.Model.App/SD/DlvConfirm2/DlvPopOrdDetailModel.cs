using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvPopOrdDetailModel : ModelBase_CommonColumns
    {
        
        [Display(Name = "출하지시번호")]
        
        public string DOH_NO { get; set; }

        [Display(Name = "출하실적번호")]
        public string DRH_NO { get; set; }


        [Display(Name = "회사코드")]
        
        public string COMP_CD { get; set; }
        [Display(Name = "품번")]
        [StrapMinWidth(100)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        
        [StrapMinWidth(150)]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "출하지시수량")]
        public int DOD_QTY { get; set; }
        
        
    }
}
