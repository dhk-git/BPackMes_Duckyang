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

namespace BPack.Model.App.MM.PurInbound
{
    public class InDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PID_NO_KEY { get; set; }
        [Display(Name = "구매입고상세번호")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string PID_NO { get; set; }
        [Display(Name = "구매입고번호")]
        [StrapVisible(false, false, false)]
        public string PIH_NO { get; set; }
        [Display(Name = "발주상세번호")]
        [StrapVisible(false, false, false)]
        public string POD_NO { get; set; }
        [Display(Name = "패킹리스트등록번호")]
        public string PAC_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "입고수량")]
        public decimal PID_QTY { get; set; }
        [Display(Name = "입고일자")]
        public DateTime GIR_DT { get; set; }
        [Display(Name = "식별표번호")]
        [StrapDenyEdit]
        public string HU_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string BARCODE_NO { get; set; }
        [Display(Name = "상세입고처리상태")]
        [StrapLookUpEditCode(CoreOrApp.Core, "PID_STATUS", false)]
        [StrapDenyEdit]
        public string PID_STATUS { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; } = "N";
    }
}
