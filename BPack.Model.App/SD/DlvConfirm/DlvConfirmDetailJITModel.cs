using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmDetailJITModel : ModelBase
    {
        [Display(Name = "출하지시상세번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string DOD_NO { get; set; }

        [Display(Name = "출하지시번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string DOH_NO { get; set; }

        [Display(Name = "차종")]
        [ReadOnly(true)]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "ALC")]
        [ReadOnly(true)]
        public string ALC_CD { get; set; }

        [Display(Name = "품번")]
        [ReadOnly(true)]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        [ReadOnly(true)]
        public string ITEM_NM { get; set; }

        [Display(Name = "지시수량")]
        [ReadOnly(true)]
        [StrapGridSummary(Sum =true)]
        public decimal DO_QTY { get; set; }

        [Display(Name = "출하수량")]
        [ReadOnly(true)]
        [StrapGridSummary(Sum = true)]
        public decimal DR_QTY { get; set; }

        [Display(Name = "출하실적번호(ERP)")]
        [ReadOnly(true)]
        public string OG_NO { get; set; }

    }
}
