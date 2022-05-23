using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MD.ItmBomTree
{
    public class ItemBomModel : ModelBase_CommonColumns
    {

        [Key]
        [StrapVisible(false, false, false)]
        public string BOM_NO_KEY { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "BOM번호")]
        public string BOM_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "BOM종류")]
        [StrapVisible(false, false, false)]
        public string BOM_TYPE { get; set; }
        [Display(Name = "리비전")]
        public int BOM_REV { get; set; }
        //[Display(Name = "소요기준수량")]
        //[StrapVisible(false, false, false)]
        //public decimal BOM_BASE_QTY { get; set; }
        [Display(Name = "소요기준단위(공통코드:UNIT)")]
        [StrapVisible(false, false, false)]
        public string BOM_BASE_UNIT { get; set; }

        [Display(Name = "기준일")]
        [StrapVisible(true, false, false)]
        public DateTime VALID_FROM_DT { get; set; }

        [Display(Name = "유효종료일")]
        [StrapVisible(true, false, false)]
        public DateTime VALID_TO_DT { get; set; }

        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
       

        //[StrapVisible(false, false, false)]
        //[Display(Name = "회사코드")]
        //public string COMP_CD { get; set; }

        //[StrapVisible(false, false, false)]
        //[Display(Name = "공장코드")]
        //public string PLANT_CD { get; set; }

        //[StrapVisible(true, false, false)]
        //[Display(Name = "품번")]
        //public string ITEM_CD { get; set; }
        
        //[Display(Name = "적용일")]
        //public DateTime? APPLY_DT { get; set; }

        //[StrapVisible(true, false, false)]
        //[Display(Name = "품명")]
        //public string ITEM_NM { get; set; }

        //[Display(Name = "규격")]
        //[StrapVisible(false, false, false)]
        //public string ITEM_SPEC { get; set; }

        //[Display(Name = "품목유형")]
        //public string ITEM_TYPE { get; set; }

        //[Display(Name = "차종")]
        //public string ITEM_GR_1 { get; set; }

        //[Display(Name = "ALC")]
        //public string ALC_CD { get; set; }


        //[StrapVisible(false, false, false)]
        //public override string REMARK { get => base.REMARK; set => base.REMARK = value; }

        //[StrapVisible(false, false, false)]
        //public override DateTime? MODIFY_DTTM { get => base.MODIFY_DTTM; set => base.MODIFY_DTTM = value; }

        //[StrapVisible(false, false, false)]
        //public override string MODIFY_USER_ID { get => base.MODIFY_USER_ID; set => base.MODIFY_USER_ID = value; }
    }
}
