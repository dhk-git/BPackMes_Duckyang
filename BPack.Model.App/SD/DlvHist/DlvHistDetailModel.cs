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
    public class DlvHistDetailModel : ModelBase
    {
        [Display(Name = "생산기준일")]
        public DateTime? PROD_DT { get; set; }
        [Display(Name = "지시일자")]
        public DateTime? REQ_DT { get; set; }
        [Display(Name = "납품일자")]
        public DateTime? DLV_DT { get; set; }
        [Display(Name = "출하지시상세번호")]
        public string DOD_NO { get; set; }
        [Display(Name = "납품장소")]
        [StrapVisible(false, false, false)]
        public string GATE_CD { get; set; }
        [Display(Name = "출하유형")]
        [StrapVisible(false, false, false)]
        public string DLV_TYPE { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }
        [Display(Name = "ALC")]
        [StrapVisible(false, false, false)]
        public string ALC_CD { get; set; }
        [Display(Name = "차종")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "BODY NO")]
        public string BODY_NO { get; set; }
        [Display(Name = "투입순서")]
        public string PBS_SEQ { get; set; }
        [Display(Name = "지시수량")]
        [StrapGridSummary(Sum = true)]
        public decimal DO_QTY { get; set; }
        [Display(Name = "출하수량")]
        [StrapGridSummary(Sum = true)]
        public decimal DR_QTY { get; set; }
        [Display(Name = "출하수량")]
        [StrapGridSummary(Sum = true)]
        public decimal HU_INIT_QTY { get; set; }
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
    }
}
