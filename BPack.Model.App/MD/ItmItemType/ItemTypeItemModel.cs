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
    public class ItemTypeItemModel : ModelBase_CommonColumns
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
        [Key]
        [StrapVisible(false, false, false)]
        public string COL_PHYSI_NM_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "품목유형코드")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "컬럼물리명")]
        [StrapDenyEdit]
        public string COL_PHYSI_NM { get; set; }
        [Display(Name = "컬럼논리명")]
        [StrapDenyEdit]
        public string COL_LOGI_NM { get; set; }
        [Display(Name = "보이기")]
        public bool VISIBLE { get; set; }


    }
}
