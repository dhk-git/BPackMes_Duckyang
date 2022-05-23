using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvPopOrdModel
    {
        [Display(Name ="출하지시")]
        public string DOH_NO { get; set; }

        [Display(Name = "출하회차")]
        public int ORDER_SEQ { get; set; }

        [Display(Name = "거래처")]
        public string BP_CD { get; set; }

        [Display(Name = "상태")]
        public string DOH_STATUS { get; set; }

        [Display(Name = "비고")]
        public string REMARK { get; set; }
    }
}
