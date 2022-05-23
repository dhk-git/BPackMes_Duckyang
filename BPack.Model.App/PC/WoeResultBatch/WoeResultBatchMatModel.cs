using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResultBatch
{
    public class WoeResultBatchMatModel : ModelBase_CommonColumns
    {
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
        [Display(Name = "소요량")]
        public decimal OPER_QTY { get; set; }
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }
        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "창고명")]
        public string WH_NM { get; set; }
        [Display(Name = "위치코드")]
        [StrapVisible(false, false, false)]
        public string LOC_CD { get; set; }
        [Display(Name = "위치명")]
        public string LOC_NM { get; set; }
        [Display(Name = "수량")]
        public decimal HU_STOCK_QTY { get; set; }
        [Display(Name = "LotNo")]
        public string LOT_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }

    }
}
