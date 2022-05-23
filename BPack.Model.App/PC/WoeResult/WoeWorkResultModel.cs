using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeWorkResultModel : ModelBase_CommonColumns
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
        public decimal OK_QTY { get; set; }
        [Display(Name = "불량수량")]
        public decimal NG_QTY { get; set; }
        [Display(Name = "생산실적상태")]
        public string RST_STATUS { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
    }
}
