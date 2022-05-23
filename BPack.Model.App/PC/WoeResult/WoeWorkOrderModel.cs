using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResult
{
    public class WoeWorkOrderModel : ModelBase_CommonColumns
    {
        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }
        [Display(Name = "라우팅번호")]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "공정")]
        public int OPER { get; set; }
        [Display(Name = "공정설명")]
        public string OPER_DESC { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "작업장명")]
        [StrapVisible(false, false, false)]
        public string WC_NM { get; set; }
        [Display(Name = "실적식별표유형")]
        public string RST_HU_TYPE { get; set; }
        [Display(Name = "자재입고창고")]
        [StrapVisible(false, false, false)]
        public string MAT_WH_CD { get; set; }
        [Display(Name = "자재입고위치")]
        [StrapVisible(false, false, false)]
        public string MAT_LOC_CD { get; set; }
        [Display(Name = "생산입고창고")]
        [StrapVisible(false, false, false)]
        public string GD_WH_CD { get; set; }
        [Display(Name = "생산입고위치")]
        [StrapVisible(false, false, false)]
        public string GD_LOC_CD { get; set; }
        [Display(Name = "지시일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime WO_DT { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "지시수량")]
        public decimal WOR_QTY { get; set; }
        [Display(Name = "작업지시서상태")]
        [StrapVisible(false, false, false)]
        public string WO_STATUS { get; set; }
        [Display(Name = "공정진행상태")]
        public string WOD_STATUS { get; set; }
    }
}
