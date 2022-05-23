using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumLotTracking
{
    public class HumHeaderForwardModel : ModelBase
    {
        [Display(Name = "납품카드번호")]
        public string DO_NO { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "LOT NO")]
        public string LOT_NO { get; set; }
        [Display(Name = "최초수량")]
        public decimal HU_INIT_QTY { get; set; }
        [Display(Name = "현재수량")]
        public decimal HU_STOCK_QTY { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "가입고번호")]
        public string PRCP_NO { get; set; }
        [Display(Name = "입고일시")]
        public DateTime? IN_DTTM { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
    }
}
