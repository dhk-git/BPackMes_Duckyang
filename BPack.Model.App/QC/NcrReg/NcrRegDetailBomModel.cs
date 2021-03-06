using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.QC.NcrReg
{
    public class NcrRegDetailBomModel : ModelBase_CommonColumns
    {
        public string LV { get; set; }
        public string ID { get; set; }
        public string P_ID { get; set; }


        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "적용일")]
        [StrapVisible(false, false, false)]
        public DateTime? VALIDT_DT { get; set; }

        [Display(Name = "상위품번")]
        [StrapVisible(false, false, false)]
        public string P_ITEM_CD { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "규격")]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }

        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "소요량")]
        public decimal? BOM_QTY { get; set; }

        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }

        [Display(Name = "부적합 수량")]
        public int DEFECT_QTY { get; set; }

        [Display(Name = "불량유형")]
        public string DEFECT_CD { get; set; }
    }
}
