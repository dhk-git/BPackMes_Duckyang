using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeRsltInfo
{
    public class WorkResultModel : ModelBase
    {
        [Display(Name = "지시일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime WO_DT { get; set; }
        [Display(Name = "생산일자")]
        [StrapVisible(false, false, false)]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "근무조")]
        public string SHIFT_NM { get; set; }
        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }
        [Display(Name = "작업장명")]
        public string WC_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "제품군")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_2 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "지시")]
        [StrapGridSummary(Sum =true)]
        public decimal WOR_QTY { get; set; }
        [Display(Name = "실적")]
        [StrapGridSummary(Sum = true)]
        public decimal RST_QTY { get; set; }
        [Display(Name = "양품")]
        [StrapGridSummary(Sum = true)]
        public decimal OK_QTY { get; set; }
        [Display(Name = "불량")]
        [StrapGridSummary(Sum = true)]
        public decimal NG_QTY { get; set; }
        [Display(Name = "잔량(지시-양품)")]
        [StrapGridSummary(Sum = true)]
        public decimal DIFF_QTY { get; set; }

        [Display(Name = "작업지시번호(ERP)")]
        public string CUSTOM_WO_NO { get; set; }
        [Display(Name = "작업지시번호(MES)")]
        public string WO_NO { get; set; }
        //[Display(Name = "생산타임(1T,2T...)")]
        //public string WORK_TM { get; set; }
        //[Display(Name = "비고")]
        //public string REMARK { get; set; }
    }
}
