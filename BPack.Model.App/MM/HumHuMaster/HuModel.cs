using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumHuMaster
{
    public class HuModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "상위식별표번호")]
        public string PARENT_HU_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "추가된식별표번호")]
        public string ADDED_HU_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapHidden]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapHidden]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "식별표유형")]
        [StrapLookUpEditCode(CoreOrApp.Core, "HU_TYPE")]
        public string HU_TYPE { get; set; }
        [Display(Name = "최초수량")]
        public decimal INIT_QTY { get; set; }
        [Display(Name = "현재수량")]
        public decimal STOCK_QTY { get; set; }
        [Display(Name = "작업일")]
        public DateTime WORK_DT { get; set; }
        [Display(Name = "LOT NO")]
        public string LOT_NO { get; set; }
        [Display(Name = "식별표바코드 유형")]
        public string BARCODE_TYPE { get; set; }
        [Display(Name = "식별표바코드내용")]
        public string BARCODE_TEXT { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "커스텀바코드내용")]
        public string CUSTOM_BARCODE_TEXT { get; set; }
        [Display(Name = "참조문서형태")]
        public string REF_DOC_TYPE { get; set; }
        [Display(Name = "참조문서번호")]
        public string REF_DOC_NO { get; set; }

        //[StrapVisible(false, false, false)]
        [Display(Name = "식별표사용상태")]
        public string HU_USE_STATUS { get; set; }

        //[StrapVisible(false, false, false)]
        [Display(Name = "식별표재고상태")]
        public string HU_STOCK_STATUS { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "식별표재고조정상태")]
        public string HU_ADJUST_STATUS { get; set; }
        [Display(Name = "BLOCK여부")]
        public string BLOCK_YN { get; set; }
        [Display(Name = "BLOCK일시")]
        public DateTime? BLOCK_DTTM { get; set; }
        [Display(Name = "BLOCK사유")]
        public string BLOCK_DESC { get; set; }
        [Display(Name = "BLOCK해제일시")]
        public DateTime? BLOCK_CANCEL_DTTM { get; set; }
    }
}
