using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.ItmBom
{
    public class ItemInfoModel : ModelBase_CommonColumns_With_DelFlag
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
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "품명(PlantLang)")]
        [StrapVisible(false, false, false)]
        public string ITEM_NM_PL { get; set; }
        [Display(Name = "규격")]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE { get; set; }
        [Display(Name = "품목그룹2")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_2 { get; set; }
        [Display(Name = "품목그룹3")]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_3 { get; set; }
        [Display(Name = "HU수량")]
        [StrapVisible(false, false, false)]
        public float HU_SIZE { get; set; }
        [Display(Name = "HU단위")]
        [StrapVisible(false, false, false)]
        public string HU_UNIT { get; set; }
        [Display(Name = "모델")]
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
        [Display(Name = "기본자재투입방식(FIFO자동,개별")]
        [StrapVisible(false, false, false)]
        public string MAT_INPUT_TYPE { get; set; }
        [Display(Name = "개별식별표관리여부")]
        [StrapVisible(false, false, false)]
        public string INDI_HU_FG { get; set; }
        [StrapVisible(false, false, false)]
        public override string REMARK { get => base.REMARK; set => base.REMARK = value; }
        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
