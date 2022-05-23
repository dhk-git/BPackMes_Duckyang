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
    public class LocHuModel : ModelBase
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
        [Display(Name = "위치")]
        public string LOC_CD { get; set; }
        [Display(Name = "현재수량")]
        [StrapGridSummary(Sum = true)]
        public decimal HU_STOCK_QTY { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "상위식별표번호")]
        public string PARENT_HU_NO { get; set; }
        [Display(Name = "식별표유형")]
        public string HU_TYPE { get; set; }
        [Display(Name = "바코드종류")]
        public string BARCODE_TYPE { get; set; }
        [Display(Name = "최초수량")]
        [StrapGridSummary(Sum = true)]
        public decimal HU_INIT_QTY { get; set; }
        [Display(Name = "비고")]
        public string REMARK { get; set; }
        [Display(Name = "식별표생성일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime HU_CREATE_DTTM { get; set; }
        [Display(Name = "식별표생성자")]
        public string HU_CREATE_USER_ID { get; set; }
        [Display(Name = "식별표입고일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime WHHU_CREATE_DTTM { get; set; }
        [Display(Name = "식별표입고자")]
        public string WHHU_CREATE_USER_ID { get; set; }
    }
}
