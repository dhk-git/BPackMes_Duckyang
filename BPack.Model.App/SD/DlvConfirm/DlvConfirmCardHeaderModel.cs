using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.DlvConfirm
{
    public class DlvConfirmCardHeaderModel : ModelBase
    {
        [Display(Name = "TITLE")]
        public string REPORT_TITLE { get; set; }

        [Display(Name = "출하실적번호")]
        public string DRT_NO { get; set; }

        [Display(Name = "발행일자")]
        public string PRINT_DT { get; set; }

        [Display(Name = "납품일자")]
        public DateTime? DLV_DT { get; set; }

        [Display(Name = "공급업체코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "공급업체명")]
        public string PLANT_NM { get; set; }

        [Display(Name = "납품장소코드")]
        public string DLV_PLC_CD { get; set; }

        [Display(Name = "납품장소")]
        public string DLV_PLC_NM { get; set; }

        [Display(Name = "출하실적 바코드")]
        public string DRT_BARCODE { get; set; }

        public List<DlvConfirmCardDetailModel> detailModels { get; set; }

    }
}
