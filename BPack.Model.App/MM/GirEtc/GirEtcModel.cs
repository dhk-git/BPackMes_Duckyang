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

namespace BPack.Model.App.MM.GirEtc
{
    public class GirEtcModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ETG_NO_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "수불일자")]
        public DateTime GIR_DT { get; set; } = DateTime.Now;
        [Display(Name = "입출고구분")]
        [Required]
        public string INOUT_CLS { get; set; }
        [Display(Name = "창고코드")]
        [Required]
        public string WH_CD { get; set; }
        [Display(Name = "수불코드")]
        [Required]
        public string GIR_TYPE_CD { get; set; }
        [Display(Name = "기타입출고유형")]
        [Required]
        public string ETC_GIR_TYPE { get; set; }
        [Display(Name = "기타입출고상태")]
        [ReadOnly(true)]
        public string ETC_GIR_STATUS { get; set; }
        [Display(Name = "내용")]
        public string ETC_GIR_DESC { get; set; }
        [Display(Name = "기타입출고번호")]
        [ReadOnly(true)]
        public string ETG_NO { get; set; }
    }

}
