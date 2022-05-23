using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvOrderHist
{
    public class DlvOrderHistHuDetailModel : ModelBase
    {
        [StrapVisible(false, false, false)]
        [Display(Name = "출하지시번호")]
        public string DOH_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "출하지시상세번호")]
        public string DOD_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "출하실적번호")]
        public string DRH_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "출하실적상세번호")]
        public string DRD_NO { get; set; }

        [Display(Name = "출하지시일자")]
        public DateTime DOH_DT { get; set; }

        [Display(Name = "출하순서")]
        public int ORDER_SEQ { get; set; }

        [Display(Name = "고객발주번호")]
        public string CUSTOM_PO_NO { get; set; }

        [Display(Name = "고객사납품번호")]
        public string CUST_DOH_NO { get; set; }

        [Display(Name = "차량번호")]
        public string VEHICLE_NO { get; set; }

        [Display(Name = "피킹일자")]
        public DateTime PICKING_DT { get; set; }

        [Display(Name = "출하확정일자")]
        public DateTime DLV_DT { get; set; }

        [Display(Name = "출하확정시간")]
        public string DLV_TM { get; set; }

        [Display(Name = "거래처코드")]
        public string BP_CD { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "창고")]
        public string WH_CD { get; set; }

        [Display(Name = "위치")]
        public string LOC_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "식별표")]
        public string HU_NO { get; set; }

        [Display(Name = "BARCODE")]
        public string BARCODE_TEXT { get; set; }

        [Display(Name = "출하실적수량")]
        public int HU_QTY { get; set; }
    }
}
