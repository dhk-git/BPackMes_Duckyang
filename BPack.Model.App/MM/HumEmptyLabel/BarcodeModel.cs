using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumEmptyLabel
{
    public class BarcodeModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BARCODE_NO_KEY { get; set; }
        [Display(Name = "바코드종류")]
        public string BARCODE_KIND { get; set; }
        [Display(Name = "바코드번호")]
        public string BARCODE_FULL_NO { get; set; }
        [Display(Name = "품번")]
        [StrapDisableParam]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }
        [Display(Name = "최초수량")]
        [StrapDisableParam]
        public decimal HU_INIT_QTY { get; set; }
        [Display(Name = "현재수량")]
        [StrapDisableParam]
        public decimal HU_STOCK_QTY { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "상위식별표번호")]
        public string PARENT_HU_NO { get; set; }
        [Display(Name = "추가된식별표번호")]
        public string ADDED_HU_NO { get; set; }
        [Display(Name = "추가된바코드번호")]
        public string ADDED_BARCODE_NO { get; set; }
        [Display(Name = "LOCK여부")]
        public string IS_BLOCKED { get; set; }
        [Display(Name = "LOCK일시")]
        public string BLOCK_DTTM { get; set; }
        [Display(Name = "LOCK내용")]
        public string BLOCK_DESC { get; set; }
        [Display(Name = "바코드길이")]
        public int BARCODE_LENGTH { get; set; }
        [Display(Name = "참조번호")]
        public string REF_NO { get; set; }
        [Display(Name = "출력횟수")]
        public int PRINT_COUNT { get; set; }
        [Display(Name = "바코드일련번호")]
        [StrapVisible(false, false, false)]
        public string BARCODE_NO { get; set; }
    }
}
