using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirLocStock
{
    public class LocGirModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "생성일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "수불기준일")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime GIR_DT { get; set; }
        [Display(Name = "위치")]
        public string LOC_CD { get; set; }
        [Display(Name = "수불유형")]
        public string GIR_TYPE_CD { get; set; }
        [Display(Name = "대상창고")]
        public string TARGET_WH_CD { get; set; }
        [Display(Name = "대상위치")]
        public string TARGET_LOC_CD { get; set; }
        [Display(Name = "참조번호")]
        public string REF_NO { get; set; }
        [Display(Name = "식별표번호")]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }
        [Display(Name = "참조추가정보")]
        public string REF_REMARK { get; set; }
        [Display(Name = "품번")]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }
        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal? GR_QTY { get; set; }
        [Display(Name = "출고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal? GI_QTY { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "생성자")]
        public string CREATE_USER_ID { get; set; }
    }
}
