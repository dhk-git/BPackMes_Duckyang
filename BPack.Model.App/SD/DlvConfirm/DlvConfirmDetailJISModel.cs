using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmDetailJISModel : ModelBase
    {
        [Display(Name = "출하지시상세번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string DOD_NO { get; set; }

        [Display(Name = "출하지시번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string DOH_NO { get; set; }

        [Display(Name = "출하순서")]
        [ReadOnly(true)]
        public decimal DOH_SEQ { get; set; }

        [Display(Name = "PBS Seq")]
        [ReadOnly(true)]
        public string PBS_SEQ { get; set; }

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

        [Display(Name = "이종체크시간")]
        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? CHK_DTTM { get; set; }

        [Display(Name = "이종체크결과")]
        [ReadOnly(true)]
        public string CHK_RESULT { get; set; }

        [Display(Name = "상차시간")]
        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? DLV_READY_DTTM { get; set; }

        [Display(Name = "생산일자")]
        [ReadOnly(true)]
        public DateTime? WORK_DT { get; set; }

        [Display(Name = "개별식별번호")]
        [ReadOnly(true)]
        public string HU_NO { get; set; }

        [Display(Name = "바코드")]
        [ReadOnly(true)]
        public string HU_BARCODE { get; set; }

        [Display(Name = "선입선출")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string FIFO_FG { get; set; }

        [Display(Name = "출하지시수량")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public decimal DO_QTY { get; set; }

        [Display(Name = "출하실적수량")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public decimal DR_QTY { get; set; }

        [Display(Name = "직서열번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string JIS_NO { get; set; }

        [Display(Name = "ALC번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public int ALC_NO { get; set; }

        [Display(Name = "고객생산일자")]
        [ReadOnly(true)]
        public DateTime PROD_DT { get; set; }

        [Display(Name = "BODY NO")]
        [ReadOnly(true)]
        public string BODY_NO { get; set; }

        [Display(Name = "변경여부")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string CHG_FG { get; set; }

        [Display(Name = "출하실적번호(ERP)")]
        [ReadOnly(true)]
        public string OG_NO { get; set; }

    }
}
