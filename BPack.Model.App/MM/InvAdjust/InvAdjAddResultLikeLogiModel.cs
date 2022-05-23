using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.InvAdjust
{
    public class InvAdjAddResultLikeLogiModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        [Display(Name = "실사지시상세번호")]
        public string INVD_NO { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "전산상위식별표번호")]
        public string LOGI_PARENT_HU_NO { get; set; }
        [Display(Name = "전산재고")]
        public decimal LOGI_STOCK { get; set; }
    }
}
