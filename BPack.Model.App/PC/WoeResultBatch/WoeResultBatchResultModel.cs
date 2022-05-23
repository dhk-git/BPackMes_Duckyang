using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResultBatch
{
    public class WoeResultBatchResultModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string RST_NO_KEY { get; set; }
        [Display(Name = "생산실적번호")]
        public string RST_NO { get; set; }
        [Display(Name = "작업지시번호")]
        [StrapVisible(false, false, false)]
        public string WO_NO { get; set; }
        [Display(Name = "라우팅번호")]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "공정")]
        [StrapVisible(false, false, false)]
        public int OPER { get; set; }
        [Display(Name = "실적수량")]
        public decimal RST_QTY { get; set; }
        [Display(Name = "양품수량")]
        [StrapVisible(false, false, false)]
        public decimal OK_QTY { get; set; }
        [Display(Name = "불량수량")]
        [StrapVisible(false, false, false)]
        public decimal NG_QTY { get; set; }
        [Display(Name = "생산실적상태")]
        [StrapVisible(false, false, false)]
        public string RST_STATUS { get; set; }
        [Display(Name = "작업장")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "식별표유형")]
        [StrapVisible(false, false, false)]
        public string HU_TYPE { get; set; }
        [Display(Name = "품번")]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }
        [Display(Name = "생산일자")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }
        [Display(Name = "단말기ID")]
        [StrapVisible(false, false, false)]
        public string DVC_ID { get; set; }
        [Display(Name = "생산타임")]
        public string WORK_TM { get; set; }
    }
}
