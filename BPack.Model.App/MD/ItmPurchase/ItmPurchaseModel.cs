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
    public class ItmPurchaseModel : ModelBase_CommonColumns
    {

        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string COMP_CD_KEY { get; set; }
        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string BP_CD_KEY { get; set; }
        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string PLANT_CD_KEY { get; set; }
        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string ITEM_CD_KEY { get; set; }
        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public DateTime VALID_FROM_DT_KEY { get; set; }
        //[Display(Name = "회사코드")]
        //public string COMP_CD { get; set; }
        //[Display(Name = "거래처코드")]
        //public string BP_CD { get; set; }
        //[Display(Name = "공장코드")]
        //public string PLANT_CD { get; set; }
        //[Display(Name = "품목코드")]
        //public string ITEM_CD { get; set; }
        //[Display(Name = "유효시작일")]
        //public DateTime VALID_FROM_DT { get; set; } = DateTime.Now.Date;
        //[Display(Name = "유효종료일")]
        //public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
        //[Display(Name = "공급사품번")]
        //public string SUPPL_ITEM_CD { get; set; }
        //[Display(Name = "공급사품명")]
        //public string SUPP_ITEM_NM { get; set; }
        //[Display(Name = "단가")]
        //public decimal SL_PRICE { get; set; }
        //[Display(Name = "통화")]
        //public string CURRENCY_TYPE { get; set; }
        //[Display(Name = "삭제FLAG(Y=삭제)")]
        //public string DEL_FG { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BP_CD_KEY { get; set; }
        [Display(Name = "거래처코드")]
        public string BP_CD { get; set; }
        [Display(Name = "거래처명")]
        public string BP_NM { get; set; }
        [Display(Name = "매입여부")]
        [StrapVisible(false, false, false)]
        public string IS_PURCHASE { get; set; }
        [Display(Name = "매출여부")]
        [StrapVisible(false, false, false)]
        public string IS_SALES { get; set; }
        [Display(Name = "주소")]
        public string ADDR { get; set; }
    }


}
