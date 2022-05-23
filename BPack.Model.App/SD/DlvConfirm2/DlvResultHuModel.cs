using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvResultHuModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DRD_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [Display(Name = "출하실적상세번호")]
        [StrapVisible(false, false, false)]
        public string DRD_NO { get; set; }
        [Display(Name = "식별표번호")]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }
        [Display(Name = "출하실적번호")]
        [StrapVisible(false, false, false)]
        public string DRH_NO { get; set; }
        [Display(Name = "발주번호")]
        [StrapVisible(false, false, false)]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "창고")]
        public string WH_CD { get; set; }
        [Display(Name = "위치")]
        public string LOC_CD { get; set; }
        [Display(Name = "LOT No")]
        [StrapVisible(false, false, false)]
        public string LOT_NO { get; set; }
        [Display(Name = "수량")]
        public decimal HU_QTY { get; set; }
        [Display(Name = "작업일")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "바코드번호")]
        public string BARCODE_TEXT { get; set; }
        [Display(Name = "상위바코드번호")]
        [StrapVisible(false, false, false)]
        public string PARENT_BARCODE_TEXT { get; set; }

    }
}
