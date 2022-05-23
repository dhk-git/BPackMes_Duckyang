using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmHeaderModel : ModelBase
    {
        [Display(Name = "납품장소코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DLV_PLC_CD { get; set; }

        [Display(Name = "납품장소")]
        [ReadOnly(true)]
        public string DLV_PLC_NM { get; set; }

        [Display(Name = "배차번호")]
        [ReadOnly(true)]
        public string CP_NO { get; set; }

        [Display(Name = "배차순서")]
        [ReadOnly(true)]
        public int CP_SEQ { get; set; }

        [Display(Name = "상차순서")]
        [ReadOnly(true)]
        public int LOAD_SEQ { get; set; }

        [Display(Name = "출하유형")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DLV_TYPE { get; set; }

        [Display(Name = "출하지시일")]
        [ReadOnly(true)]
        public DateTime REQ_DT { get; set; }

        [Display(Name = "출하순번")]
        [ReadOnly(true)]
        public int REQ_SEQ { get; set; }

        [Display(Name = "지시수량")]
        [ReadOnly(true)]
        [StrapGridSummary(Sum = true)]
        public decimal DO_QTY { get; set; }

        [Display(Name = "실적수량")]
        [ReadOnly(true)]
        [StrapGridSummary(Sum = true)]
        public decimal DR_QTY { get; set; }

        [Display(Name = "출하지시번호")]
        [ReadOnly(true)]
        public string DOH_NO { get; set; }

        [Display(Name = "출하상태코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DLV_STATUS { get; set; }

        [Display(Name = "출하상태")]
        [ReadOnly(true)]
        public string DLV_STATUS_NM { get; set; }

        [Display(Name = "출하준비완료시간")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime DLV_READY_DTTM { get; set; }

        [Display(Name = "출하실적번호")]
        [ReadOnly(true)]
        public string DRT_NO { get; set; }

        [Display(Name = "납품일자")]
        [ReadOnly(true)]
        public DateTime? DLV_DT { get; set; }

        [Display(Name = "납품일자(MAX)")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public DateTime? DLV_DT_MAX { get; set; }

        [Display(Name = "출고시간")]
        [ReadOnly(true)]
        public TimeSpan? DLV_TM { get; set; }

        [Display(Name = "차량번호")]
        [ReadOnly(true)]
        public string CAR_NO { get; set; }

        [Display(Name = "운전자")]
        [ReadOnly(true)]
        public string DRIV_NM { get; set; }

        [Display(Name = "전화번호")]
        [ReadOnly(true)]
        public string PHONE_NO { get; set; }

        [Display(Name = "출하지시번호(ERP)")]
        [ReadOnly(true)]
        public string OP_NO { get; set; }
    }
}
