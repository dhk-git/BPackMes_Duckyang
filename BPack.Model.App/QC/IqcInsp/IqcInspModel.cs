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

namespace BPack.Model.App.QC.IqcInsp
{
    public class IqcInspModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string IQC_NO_KEY { get; set; }

        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고일자")]
        [StrapDenyEdit]
        public DateTime CLOSE_DT { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고검사번호")]
        [StrapDenyEdit]
        public string IQC_NO { get; set; }
        
        [StrapDisableParam]
        [Display(Name = "구매입고번호")]
        [StrapDenyEdit]
        public string PIH_NO { get; set; }

        [StrapDisableParam]
        [StrapDenyEdit]
        [Display(Name = "검사완료일")]
        public DateTime? IQC_DT { get; set; }

        [StrapDisableParam]
        [StrapDenyEdit]
        [Display(Name = "입고검사상태")]
        public string IQC_STATUS { get; set; }
    }
}
