using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumMebBarcode
{
    public class HumMebBarcodeModel: ModelBase
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BARCODE_TEXT_KEY { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "Barcode")]
        public string BARCODE_TEXT { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사")]
        public string COMP_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장")]
        public string PLANT_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "생성일")]
        public DateTime WORK_DT { get; set; }
        [ReadOnly(true)]
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [ReadOnly(true)]
        [Display(Name = "식별표유형")]
        public string HU_MEB_TYPE { get; set; }
        [ReadOnly(true)]
        [Display(Name = "수량")]
        public decimal INIT_QTY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "CASE NO")]
        public string CASE_NO { get; set; }
        [ReadOnly(true)]
        [Display(Name = "ORDER NO")]
        public string ORDER_NO { get; set; }
        [ReadOnly(true)]
        [Display(Name = "LOT")]
        public string LOT { get; set; }
        [ReadOnly(true)]
        [Display(Name = "PACK DATE")]
        public string PACK_DATE { get; set; }
        [ReadOnly(true)]
        [Display(Name = "SHIP DATE")]
        public string SHIP_DATE { get; set; }

        [ReadOnly(true)]
        public string HU_NO { get; set; }


    }
}
