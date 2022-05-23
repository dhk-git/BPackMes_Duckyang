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

namespace BPack.CommonMes.Controls.ItemMaster
{
    public class ItemMasterModel : ModelBase_CommonColumns
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
        public string ITEM_CD_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품목명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "재질")]
        public string ITEM_DESC_1 { get; set; }
        [Display(Name = "품목설명2")]
        [StrapVisible(false, false, false)]
        public string ITEM_DESC_2 { get; set; }
        [Display(Name = "품목설명3")]
        [StrapVisible(false, false, false)]
        public string ITEM_DESC_3 { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "품목그룹1")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "품목그룹2")]
        public string ITEM_GR_2 { get; set; }
        [Display(Name = "품목그룹3")]
        public string ITEM_GR_3 { get; set; }
        [Display(Name = "품목그룹4")]
        public string ITEM_GR_4 { get; set; }
        [Display(Name = "품목그룹5")]
        public string ITEM_GR_5 { get; set; }
        [Display(Name = "구매단위수량")]
        public decimal PUR_SIZE { get; set; }
        [Display(Name = "중포장수량")]
        public decimal MID_PACK_SIZE { get; set; }
        [Display(Name = "대포장수량")]
        public decimal LARGE_PACK_SIZE { get; set; }
        [Display(Name = "불출단위수량")]
        public decimal PROD_OUT_SIZE { get; set; }
        [Display(Name = "BOX적재수량")]
        public decimal BOX_SIZE { get; set; }
        [Display(Name = "파렛트적재수량")]
        public decimal PALLET_SIZE { get; set; }
        [Display(Name = "FIFO체크여부")]
        public string FIFO_CHK_YN { get; set; }
        [Display(Name = "안전재고")]
        public decimal SAFETY_QTY { get; set; }
        [Display(Name = "재고단위")]
        public string BASE_UNIT { get; set; }
        [Display(Name = "중량")]
        public decimal WEIGHT { get; set; }
        [Display(Name = "중량단위")]
        public string WEIGHT_UNIT { get; set; }
        [Display(Name = "유효시작일")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime VALID_FROM_DT { get; set; }
        [Display(Name = "유효종료일")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime VALID_TO_DT { get; set; }



        [Display(Name = "수정일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string MODIFY_USER_ID { get; set; }


      
    }
}
