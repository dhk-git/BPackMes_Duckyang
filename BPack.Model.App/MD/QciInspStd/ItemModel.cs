using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.MD.QciInspStd
{
    public class ItemModel : ModelBase_CommonColumns
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapMinWidth(100)]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "품목유형코드")]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE { get; set; }
        [Display(Name = "품목유형명")]
        [StrapMinWidth(80)]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "차종")]
        [StrapMinWidth(80)]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "제품군")]
        [StrapMinWidth(80)]
        public string ITEM_GR_2 { get; set; }
        [Display(Name = "서열유형")]
        [StrapMinWidth(80)]
        public string ITEM_GR_3 { get; set; }
        [Display(Name = "구매단위수량")]
        [StrapVisible(false, false, false)]
        public decimal PUR_SIZE { get; set; }
        [Display(Name = "불출단위수량")]
        [StrapVisible(false, false, false)]
        public decimal PROD_OUT_SIZE { get; set; }
        [Display(Name = "HU수량")]
        [StrapVisible(false, false, false)]
        public decimal HU_SIZE { get; set; }
        [Display(Name = "HU단위")]
        [StrapVisible(false, false, false)]
        public string HU_UNIT { get; set; }
        [Display(Name = "대표모델")]
        [StrapVisible(false, false, false)]
        public string MAIN_MODEL { get; set; }
        [Display(Name = "기본단위")]
        [StrapVisible(false, false, false)]
        public string BASE_UNIT { get; set; }
        [Display(Name = "중량")]
        [StrapVisible(false, false, false)]
        public string WEIGHT { get; set; }
        [Display(Name = "중량단위")]
        [StrapVisible(false, false, false)]
        public string WEIGHT_UNIT { get; set; }
        [Display(Name = "개별식별표관리여부")]
        [StrapVisible(false, false, false)]
        public string INDI_HU_FG { get; set; }
        [Display(Name = "ALC코드")]
        [StrapMinWidth(100)]
        public string ALC_CD { get; set; }
        [Display(Name = "자재입고구분(자동/수동)(시스템")]
        [StrapVisible(false, false, false)]
        public string MAT_IN_FG { get; set; }
        [Display(Name = "자재공용여부")]
        [StrapVisible(false, false, false)]
        public string MAT_COMM_FG { get; set; }
        [Display(Name = "입고자재창고")]
        [StrapVisible(false, false, false)]
        public string MAT_IN_WH { get; set; }
        [Display(Name = "입고자재위치")]
        [StrapVisible(false, false, false)]
        public string MAT_IN_LOC { get; set; }
        [Display(Name = "입고현장창고")]
        [StrapVisible(false, false, false)]
        public string PROD_IN_WH { get; set; }
        [Display(Name = "입고현장위치")]
        [StrapVisible(false, false, false)]
        public string PROD_IN_LOC { get; set; }

        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);

    }
}
