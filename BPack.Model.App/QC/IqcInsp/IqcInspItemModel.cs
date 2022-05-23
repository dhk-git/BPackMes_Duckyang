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
    public class IqcInspItemModel :ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string IQD_NO_KEY { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고검사상세번호")]
        [StrapVisible(false, false, false)]
        public string IQD_NO { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고검사번호")]
        [StrapVisible(false, false, false)]
        public string IQC_NO { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품번")]
        [StrapDenyEdit]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품명")]
        [StrapDenyEdit]
        public string ITEM_NM { get; set; }

        [StrapDisableParam]
        [Display(Name = "제품군")]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }

        [StrapDisableParam]
        [Display(Name = "제품유형")]
        [StrapDenyEdit]
        public string ITEM_TYPE_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "식별표번호")]
        [StrapDenyEdit]
        public string HU_NO { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고수량")]
        [StrapDenyEdit]
        public decimal IN_QTY { get; set; }


        [Display(Name = "검사수량")]
        public decimal IQC_QTY { get; set; }

        [StrapDisableParam]
        [ReadOnly(true)]
        [Display(Name = "불량수량")]
        [StrapDenyEdit]
        public decimal DEFECT_QTY { get; set; }

        [Display(Name = "판정")]
        public string IQC_INSD_STATUS { get; set; }

        [Display(Name = "검사자")]
        public string INSPECTOR { get; set; }

    }
}
