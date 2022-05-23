using BPack.Common.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WoeRsPivot
{
    public class RsBatchModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }

        [Display(Name = "생산일자")]
        public DateTime WORK_DT { get; set; }

        [Display(Name = "생산일시")]
        public DateTime WORK_DTTM { get; set; }

        [Display(Name = "근무조그룹코드")]
        public string SHIFT_GROUP_CD { get; set; }

        [Display(Name = "근무조그룹")]
        public string SHIFT_GROUP_NM { get; set; }

        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }

        [Display(Name = "근무조")]
        public string SHIFT_NM { get; set; }

        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }

        [Display(Name = "작업장")]
        public string WC_NM { get; set; }

        [Display(Name = "품목유형코드")]
        public string ITEM_TYPE_CD { get; set; }

        [Display(Name = "품목유형")]
        public string ITEM_TYPE_NM { get; set; }

        [Display(Name = "제품군코드")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_NM { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "생산수량")]
        public int QTY { get; set; }

        [Display(Name = "바코드")]
        public string BARCODE { get; set; }

        [Display(Name = "식별표")]
        public string HU_NO { get; set; }

        [Display(Name = "작업지시")]
        public string WO_NO { get; set; }

        [Display(Name = "작업지시일자")]
        public DateTime WO_DT { get; set; }
    }
}
