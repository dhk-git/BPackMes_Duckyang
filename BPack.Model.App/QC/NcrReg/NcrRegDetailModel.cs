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
    public class NcrRegDetailModel: ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NCD_NO_KEY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "부적합상세등록번호")]
        public string NCD_NO { get; set; }

        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "부적합등록번호")]
        public string NCH_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [StrapVisible(true, true,false)]
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [StrapVisible(true, true, false)]
        [StrapDisableParam]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [StrapVisible(true, true, false)]
        [StrapDisableParam]
        [Display(Name = "유형")]
        public string ITEM_TYPE_CD { get; set; }

        [StrapVisible(true, true, false)]
        [StrapDisableParam]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "불량유형")]
        public string DEFECT_CD { get; set; }

        [Range(1, Double.PositiveInfinity)]
        [Display(Name = "불량수량")]
        public int DEFECT_QTY { get; set; }

        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
       
    }
}
