using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.ItmPurchase
{
    public class ItmListModel : ModelBase_CommonColumns
    {

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BP_CD_KEY { get; set; }

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

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT_KEY { get; set; } = DateTime.Now.Date;
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "품번")]
        [StrapMinWidth(120)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDenyEdit]
        [StrapMinWidth(150)]
        public string ITEM_NM { get; set; }

        [Display(Name = "제품군")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "품목유형")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_TYPE_CD { get; set; }

        [Display(Name = "공급사품번")]
        [StrapVisible(false, false, false)]
        public string SUPPL_ITEM_CD { get; set; }
        [Display(Name = "공급사품명")]
        [StrapVisible(false, false, false)]
        public string SUPP_ITEM_NM { get; set; }
        [Display(Name = "단가")]
        public decimal PUR_PRICE { get; set; }
        [Display(Name = "통화")]
        public string CURRENCY_TYPE { get; set; }
        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now.Date;
        [Display(Name = "유효종료일")]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; } = "N";


        //[Display(Name = "부서코드")]
        //public string BP_CD { get; set; }

        //[Display(Name = "품번")]
        //public string ITEM_CD { get; set; }
        //[Display(Name = "품명")]
        //public string ITEM_NM { get; set; }
        //[Display(Name = "규격")]
        //public string ITEM_SPEC { get; set; }
        //[Display(Name = "품목유형")]
        //public string ITEM_TYPE { get; set; }
        //[Display(Name = "공급사품번")]
        //public string SUPPLIER_ITEM_CD { get; set; }
        //[Display(Name = "공급사품명")]
        //public string SUPPLIER_ITEM_NM { get; set; }
        //[Display(Name = "자동출하")]
        //public string AUTO { get; set; }
        //[Display(Name = "유효시작일")]
        //public DateTime VALID_FROM_DT { get; set; } = DateTime.Now.Date;
        //[Display(Name = "유효종료일")]
        //public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);


    }
}
