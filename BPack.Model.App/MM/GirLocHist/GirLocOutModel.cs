using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirLocHist
{
    public class GirLocOutModel : ModelBase_CommonColumns
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "창고")]
        [StrapVisible(true, false, false)]
        public string WH_CD { get; set; }

        [Display(Name = "위치")]
        [StrapVisible(true, false, false)]
        public string LOC_CD { get; set; }

        [Display(Name = "식별표")]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }

        [Display(Name = "품번")]
        [StrapVisible(true, false, false)]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        [StrapVisible(false, false, false)]
        public string ITEM_NM { get; set; }

        [Display(Name = "바코드")]
        [StrapVisible(true, false, false)]
        public string BARCODE_TEXT { get; set; }

        [Display(Name = "일자")]
        [StrapVisible(true, false, false)]
        public DateTime GIR_DT { get; set; }

        [Display(Name = "출고유형")]
        [StrapVisible(true, false, false)]
        public string LOC_OUT_TYPE { get; set; }

        [Display(Name = "참조문서")]
        [StrapVisible(true, false, false)]
        public string REF_DOC_TYPE { get; set; }

        [Display(Name = "참조문서번호")]
        [StrapVisible(false, false, false)]
        public string REF_DOC_NO { get; set; }
    }
}
