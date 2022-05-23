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

namespace BPack.Model.App.MM.MovLoc
{
    public class MovLocItemModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MOD_NO_KEY { get; set; }


        [Display(Name = "재고이동번호")]
        [StrapVisible(false, false, false)]
        public string MOV_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapMinWidth(120)]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품명")]
        [StrapMinWidth(120)]
        public string ITEM_NM { get; set; }
        [StrapDenyEdit]
        [StrapDisableParam]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }


        [Display(Name = "이동수량")]
        public decimal MOV_QTY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "재고이동상세번호")]
        public string MOD_NO { get; set; }


    }
}
