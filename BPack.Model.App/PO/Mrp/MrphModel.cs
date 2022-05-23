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
    public class MrphModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MRH_NO_KEY { get; set; }
        [Display(Name = "자재소요계획번호")]
        public string MRH_NO { get; set; }
        [Display(Name = "기준일시")]
        public DateTime MRH_DTTM { get; set; }
        [Display(Name = "상태")]
        public string MRH_STATUS { get; set; }
    }
}
