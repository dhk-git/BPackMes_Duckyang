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

namespace BPack.Model.App.MD.EquItemCheckList
{
    public class EquItemCheckListItemModel : ModelBase_CommonColumns_With_DelFlag
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
        public string EQUIP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ITEM_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string EQUIP_CHK_CD_KEY { get; set; }


        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "설비코드")]
        [StrapVisible(false, false, false)]
        public string EQUIP_CD { get; set; }

        [Display(Name = "품번")]
        [StrapMinWidth(100)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapMinWidth(150)]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }
        [ReadOnly(true)]
        [Display(Name = "차종")]
        [StrapMinWidth(80)]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }
        [ReadOnly(true)]
        [Display(Name = "ALC코드")]
        [StrapDisableParam]
        public string ALC_CD { get; set; }
        [ReadOnly(true)]
        [StrapMinWidth(100)]
        [Display(Name = "품목유형코드")]
        [StrapDisableParam]
        public string ITEM_TYPE { get; set; }

        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);

        public override string DEL_FG { get; set; } = "N";
        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        [StrapMemoEdit]
        [StrapMinWidth(200)]
        public override string REMARK { get; set; }

        [Display(Name = "수정일시")]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string MODIFY_USER_ID { get; set; }
    }
}
