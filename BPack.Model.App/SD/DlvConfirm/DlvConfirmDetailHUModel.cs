using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmDetailHUModel : ModelBase
    {
        [Display(Name = "순서")]
        [ReadOnly(true)]
        public int ROW_SEQ { get; set; }

        [Display(Name = "출하지시상세번호")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string DOD_NO { get; set; }

        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        public string HU_NO { get; set; }

        [Display(Name = "바코드")]
        [ReadOnly(true)]
        public string HU_BARCODE { get; set; }
        [Display(Name = "고객사바코드")]
        [ReadOnly(true)]
        public string CUSTOMER_BARCODE { get; set; }

        [Display(Name = "Picking 시간")]
        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? DLV_READY_DTTM { get; set; }

        [Display(Name = "생산일")]
        [ReadOnly(true)]
        public DateTime? WORK_DT { get; set; }

        [Display(Name = "출하수량")]
        [StrapVisible(false, false, false)]
        public decimal DR_QTY { get; set; }

        [Display(Name = "선입선출")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string FIFO_FG { get; set; }

        [Display(Name = "FIFO PASS")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string FIFO_PASS { get; set; }

        [Display(Name = "이종체크결과")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public string CHK_RESULT { get; set; }

    }
}
