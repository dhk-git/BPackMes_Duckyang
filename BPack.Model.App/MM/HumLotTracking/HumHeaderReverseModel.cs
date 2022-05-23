using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumLotTracking
{
    public class HumHeaderReverseModel : ModelBase
    {
        [Display(Name = "BODY NO")]
        public string BODY_NO { get; set; }
        [Display(Name = "PBS SEQ")]
        public string PBS_SEQ { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "출하일자")]
        public DateTime DLV_DT { get; set; }
        [Display(Name = "생산일자")]
        [StrapVisible(false, false, false)]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "LOT NO")]
        public string LOT_NO { get; set; }
        [Display(Name = "수량")]
        public decimal HU_INIT_QTY { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
    }
}
