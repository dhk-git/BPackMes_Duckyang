using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumLocInfo
{
    public class HumLocInfoModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "창고")]
        [StrapDisableParam]
        public string WH_NM { get; set; }
        [Display(Name = "위치코드")]
        [StrapVisible(false, false, false)]
        public string LOC_CD { get; set; }
        [Display(Name = "위치")]
        [StrapDisableParam]
        public string LOC_NM { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "식별표유형코드")]
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string HU_TYPE { get; set; }
        [Display(Name = "식별표유형")]
        [StrapDisableParam]
        public string HU_TYPE_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }
        [Display(Name = "품목유형코드")]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "품목유형")]
        [StrapDisableParam]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "수량")]
        [StrapDisableParam]
        public decimal STOCK_QTY { get; set; }
        [Display(Name = "작업일")]
        [StrapDisableParam]
        public string WORK_DT { get; set; }
        [Display(Name = "식별표바코드")]
        [StrapDisableParam]
        public string BARCODE_TEXT { get; set; }
        [Display(Name = "BLOCK여부")]
        [StrapDisableParam]
        public string BLOCK_YN { get; set; }
        [Display(Name = "BLOCK일시")]
        [StrapDisableParam]
        public DateTime? BLOCK_DTTM { get; set; }
        [Display(Name = "BLOCK사유")]
        [StrapDisableParam]
        public string BLOCK_DESC { get; set; }
        [Display(Name = "BLOCK해제일시")]
        [StrapDisableParam]
        public DateTime? BLOCK_CANCEL_DTTM { get; set; }
    }
}
