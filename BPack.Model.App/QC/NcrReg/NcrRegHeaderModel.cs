using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.QC.NcrReg
{
    public class NcrRegHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NCH_NO_KEY { get; set; }

        [Display(Name = "등록일자")]
        public DateTime NCH_DT { get; set; }

        [StrapVisible(true, false, false)]
        [Display(Name = "부적합등록번호")]
        public string NCH_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }


        [Display(Name = "부적합유형")]
        public string NCH_TYPE { get; set; }
        [Display(Name = "발생창고")]
        public string FROM_WH_CD { get; set; }
        [Display(Name = "부적합창고")]
        public string NCR_WH_CD { get; set; }

        [StrapVisible(true, false, false)]
        [StrapDisableParam]
        [Display(Name = "상태")]
        public string NCH_STATUS { get; set; }
        [Display(Name = "참조문서")]
        public string REF_DOC_TYPE { get; set; }
        [Display(Name = "참조문서번호")]
        public string REF_DOC_NO { get; set; }
       
    }
}
