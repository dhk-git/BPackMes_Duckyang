using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmCardDetailModel : ModelBase
    {
        [Display(Name = "순서")]
        public int RN { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "수량")]
        public decimal DR_QTY { get; set; }

        [Display(Name = "단위")]
        public string DO_UNIT { get; set; }

        [Display(Name = "LOT NO")]
        public string LOT_NO { get; set; }
    }
}
