using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.SomDevice
{
    public class ModeModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DVC_ID_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MODE_ID_KEY { get; set; }
        [Display(Name = "단말기ID")]
        public string DVC_ID { get; set; }
        [Display(Name = "모드ID")]
        public string MODE_ID { get; set; }
        [Display(Name = "모드명")]
        public string MODE_NM { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "삭제FLAG(Y=삭제)")]
        public string DEL_FG { get; set; }
    }
}
