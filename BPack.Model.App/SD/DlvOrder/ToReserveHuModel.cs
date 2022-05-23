using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvOrder
{
    public class ToReserveHuModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고")]
        public string WH_CD { get; set; }
        [Display(Name = "위치")]
        public string LOC_CD { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "예약된식별표번호")]
        [StrapVisible(false, false, false)]
        public string RESERVED_HU_NO { get; set; }
        [Display(Name = "예약된출하지시번호")]
        [StrapVisible(false, false, false)]
        public string RESERVED_DOH_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string BARCODE_TEXT { get; set; }
        [Display(Name = "작업일")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "수량")]
        [StrapGridSummary(Sum = true)]
        public decimal STOCK_QTY { get; set; }
        [Display(Name = "비고")]
        public string REMARK { get; set; }
    }
}
