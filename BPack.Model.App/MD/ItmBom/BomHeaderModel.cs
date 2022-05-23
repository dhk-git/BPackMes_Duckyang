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
    public class BomHeaderModel : ModelBase_CommonColumns_With_DelFlag 
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BOM_NO_KEY { get; set; }
        [Display(Name = "BOM번호")]
        [StrapDenyEdit]
        public string BOM_NO { get; set; }
        [Display(Name = "회사")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapDenyEdit]
        public string ITEM_CD { get; set; }

        [StrapVisible(false,false,false)]
        [Display(Name = "BOM종류")]
        public string BOM_TYPE { get; set; }
        [Display(Name = "제품군")]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "리비전")]
        [StrapVisible(false, false, false)]
        public int BOM_REV { get; set; }
        [Display(Name = "팬텀자재 여부")]
        public string IS_PHANTOM { get; set; }

        [Display(Name = "기준일")]
        //[StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;

        [StrapVisible(false, false, false)]
        [Display(Name = "소요기준수량")]
        public decimal BOM_BASE_QTY { get; set; } = 1;

        [Display(Name = "유효종료일")]
        [StrapVisible(true, true, true)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
