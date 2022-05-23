using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvHist
{
    public class DlvHistDetailJisModel : ModelBase
    {
        [Display(Name = "지시일자")]
        [StrapVisible(false, false, false)]
        public DateTime? REQ_DT { get; set; }
        [Display(Name = "납품일자")]
        [StrapVisible(false, false, false)]
        public DateTime? DLV_DT { get; set; }
        [Display(Name = "생산기준일")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime? PROD_DT { get; set; }
        [Display(Name = "납품처")]
        [StrapVisible(false, false, false)]
        public string GATE_CD { get; set; }
        [Display(Name = "납품장소")]
        public string DLV_PLC_CD { get; set; }
        [Display(Name = "출하유형")]
        [StrapVisible(false, false, false)]
        public string DLV_TYPE { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "투입순서")]
        public string PBS_SEQ { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "BODY NO")]
        public string BODY_NO { get; set; }
        [Display(Name = "지시수량")]
        [StrapGridGroupSummary(Sum = true)]
        [StrapGridSummary(Sum = true)]
        public decimal DO_QTY { get; set; }
        [Display(Name = "출하수량")]
        [StrapGridGroupSummary(Sum = true)]
        [StrapGridSummary(Sum = true)]
        public decimal DR_QTY { get; set; }
        [Display(Name = "지시생성일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "식별표번호")]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "스캔일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public DateTime? SCAN_DTTM { get; set; }
        [Display(Name = "출하지시상세번호")]
        public string DOD_NO { get; set; }
        [Display(Name = "이종체크결과")]
        public string CHK_RESULT { get; set; }
        [Display(Name = "삭제여부")]
        public string DEL_FG { get; set; }
        [Display(Name = "출하상태")]
        public string DLV_STATUS { get; set; }
    }
}
