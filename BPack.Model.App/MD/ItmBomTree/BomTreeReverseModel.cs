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

namespace BPack.Model.App.MD.ItmBomTree
{
    public class BomTreeReverseModel : ModelBase_CommonColumns
    {

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "품목")]
        public string ITEM_CD { get; set; }

        [Display(Name = "자재품목")]
        [StrapVisible(false, false, false)]
        public string CHILD_ITEM_CD { get; set; }


        
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        
        [Display(Name = "규격")]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }

        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }


        [Display(Name = "소요량")]
        public float BOM_QTY { get; set; }

        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }
        [Display(Name = "적용일")]
        public DateTime VALID_FROM_DT { get; set; }

        [Display(Name = "비고")]
        [StrapMemoEdit]
        [StrapMinWidth(200)]
        [StrapVisible(false, false, false)]
        public override string REMARK { get; set; }
        [Display(Name = "수정일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        [StrapVisible(false, false, false)]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        [StrapVisible(false, false, false)]
        public override string MODIFY_USER_ID { get; set; }
    }
}
