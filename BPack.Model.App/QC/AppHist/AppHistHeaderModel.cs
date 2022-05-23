using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.QC.AppHist
{
    public class AppHistHeaderModel : ModelBase
    {
        [Display(Name = "출하지시번호")]
        public string REF_NO { get; set; }

        [Display(Name = "출하지시일")]
        [ReadOnly(true)]
        public DateTime REQ_DT { get; set; }

        [Display(Name = "납품장소코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DLV_PLC_CD { get; set; }

        [Display(Name = "납품장소")]
        [ReadOnly(true)]
        public string DLV_PLC_NM { get; set; }

        [Display(Name = "출하유형")]
        [ReadOnly(true)]
        public string DLV_TYPE { get; set; }

        [Display(Name = "출하유형명")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DLV_TYPE_NM { get; set; }

        [Display(Name = "출하순번")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int REQ_SEQ { get; set; }

        [Display(Name = "지시수량")]
        [ReadOnly(true)]
        public decimal DO_QTY { get; set; }

        [Display(Name = "출하상태코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string DLV_STATUS { get; set; }

        [Display(Name = "출하상태")]
        [ReadOnly(true)]
        public string DLV_STATUS_NM { get; set; }

        [Display(Name = "출하지시번호(ERP)")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string OP_NO { get; set; }

        [Display(Name = "결재상태코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string INSP_APP_STATUS { get; set; }

        [Display(Name = "결재상태")]
        [ReadOnly(true)]
        public string INSP_APP_STATUS_NM { get; set; }

        [Display(Name = "결재번호")]
        [StrapVisible(false, false, false)]
        public string APP_NO { get; set; }

        [Display(Name = "결재선번호")]
        [StrapVisible(false, false, false)]
        public string APP_LINE_NO { get; set; }

        [Display(Name = "검사유형")]
        [StrapVisible(false, false, false)]
        public string INSP_TYPE { get; set; }

        [Display(Name = "결재선구분(요청자)")]
        [StrapVisible(false, false, false)]
        public string APP_LINE_DV_REQ { get; set; }

        [Display(Name = "요청자ID")]
        [StrapVisible(false, false, false)]
        public string APP_USER_ID_REQ { get; set; }

        [Display(Name = "요청자")]
        public string APP_USER_NM_REQ { get; set; }

        [Display(Name = "결재순서(요청자)")]
        [StrapVisible(false, false, false)]
        public int APP_SEQ_REQ { get; set; }

        [Display(Name = "요청상태코드")]
        [StrapVisible(false, false, false)]
        public string APP_STATUS_REQ { get; set; }

        [Display(Name = "요청상태")]
        public string APP_STATUS_NM_REQ { get; set; }

        [Display(Name = "요청일시")]
        public DateTime? APP_DTTM_REQ { get; set; }

        [Display(Name = "첨언(요청자)")]
        public string REMARK_REQ { get; set; }

        [Display(Name = "결재선구분(검토자)")]
        [StrapVisible(false, false, false)]
        public string APP_LINE_DV_REV { get; set; }

        [Display(Name = "검토자ID")]
        [StrapVisible(false, false, false)]
        public string APP_USER_ID_REV { get; set; }

        [Display(Name = "검토자")]
        public string APP_USER_NM_REV { get; set; }

        [Display(Name = "결재순서(검토자)")]
        [StrapVisible(false, false, false)]
        public int APP_SEQ_REV { get; set; }

        [Display(Name = "검토상태코드")]
        [StrapVisible(false, false, false)]
        public string APP_STATUS_REV { get; set; }

        [Display(Name = "검토상태")]
        public string APP_STATUS_NM_REV { get; set; }

        [Display(Name = "결재일시(검토자)")]
        public DateTime? APP_DTTM_REV { get; set; }

        [Display(Name = "첨언(검토자)")]
        public string REMARK_REV { get; set; }

        [Display(Name = "결재선구분(승인자)")]
        [StrapVisible(false, false, false)]
        public string APP_LINE_DV_APP { get; set; }

        [Display(Name = "승인자ID")]
        [StrapVisible(false, false, false)]
        public string APP_USER_ID_APP { get; set; }

        [Display(Name = "승인자")]
        public string APP_USER_NM_APP { get; set; }

        [Display(Name = "결재순서(승인자)")]
        [StrapVisible(false, false, false)]
        public int APP_SEQ_APP { get; set; }

        [Display(Name = "승인상태코드")]
        [StrapVisible(false, false, false)]
        public string APP_STATUS_APP { get; set; }

        [Display(Name = "승인상태")]
        public string APP_STATUS_NM_APP { get; set; }

        [Display(Name = "결재일시(승인자)")]
        public DateTime? APP_DTTM_APP { get; set; }

        [Display(Name = "첨언(승인자)")]
        public string REMARK_APP { get; set; }

    }
}
