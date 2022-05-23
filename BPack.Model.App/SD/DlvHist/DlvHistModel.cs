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
    public class DlvHistModel : ModelBase
    {
        [Display(Name = "지시일자")]
        public DateTime? REQ_DT { get; set; }
        [Display(Name = "납품일자")]
        [StrapVisible(false, false, false)]
        public DateTime? DLV_DT { get; set; }
        [Display(Name = "납품처")]
        [StrapVisible(false, false, false)]
        public string GATE_CD { get; set; }
        [Display(Name = "납품장소")]
        public string DLV_PLC_CD { get; set; }
        [Display(Name = "출하유형")]
        public string DLV_TYPE { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "제품군")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_2 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "지시수량")]
        [StrapGridSummary(Sum = true)]
        public decimal DO_QTY { get; set; }
        [Display(Name = "출하수량")]
        [StrapGridSummary(Sum = true)]
        public decimal DR_QTY { get; set; }
        [Display(Name = "잔량")]
        [StrapGridSummary(Sum = true)]
        public decimal DIFF_QTY { get; set; }

    }
}
