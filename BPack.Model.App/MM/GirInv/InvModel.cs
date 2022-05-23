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

namespace BPack.Model.App.MM.GirInv
{
    public class InvModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INV_NO_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고")]
        [Required]
        public string WH_CD { get; set; }
        [Display(Name = "기준일")]
        [Required]
        public DateTime INV_GIR_DT { get; set; }
        [Display(Name = "기준일이후재고포함")]
        [StrapVisible(false, false, false)]
        [StrapLookUpEditCode(CoreOrApp.Core, "FLAG_YN")]
        public string IS_INCLUDE_AFTER_GIR { get; set; }
        [Display(Name = "실사지시상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "INV_STATUS")]
        [StrapDenyEdit]
        public string INV_STATUS { get; set; }
        [Display(Name = "완료일시")]
        [StrapDenyEdit]
        [StrapDateEdit(FormatString = "MM-dd-yyyy HH:mm")]
        public DateTime? CLOSE_DTTM { get; set; }
        [Display(Name = "재고실사번호")]
        [StrapDenyEdit]
        public string INV_NO { get; set; }

    }
}
