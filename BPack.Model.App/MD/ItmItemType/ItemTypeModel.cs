using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.ItmItemType
{
    public class ItemTypeModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE_CD_KEY { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "품목유형코드")]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "품목유형명")]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "품목유형분류")]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE_CLS { get; set; }
        [Display(Name = "재고실사그룹")]
        [StrapVisible(false, false, false)]
        public string INV_GR { get; set; }
        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
