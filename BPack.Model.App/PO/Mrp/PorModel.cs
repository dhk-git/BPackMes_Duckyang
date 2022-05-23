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

namespace BPack.Model.App.PO.Mrp
{
    public class PorModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string POR_NO_KEY { get; set; }
        [Display(Name = "구매요청서번호")]
        [StrapDenyEdit]
        public string POR_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "생성일자")]
        public DateTime POR_DT { get; set; }
        [Display(Name = "생성구분")]
        [StrapLookUpEditCode(CoreOrApp.Core, "POR_CREATE_CLS")]
        [StrapDenyEdit]
        public string POR_CREATE_CLS { get; set; }
        [Display(Name = "자재소요계획번호")]
        [StrapDenyEdit]
        public string MRH_NO { get; set; }
        [Display(Name = "상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "POR_STATUS")]
        [StrapDenyEdit]
        public string POR_STATUS { get; set; }
    }
}
