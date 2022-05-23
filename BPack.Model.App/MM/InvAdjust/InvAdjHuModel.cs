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

namespace BPack.Model.App.MM.InvAdjust
{
    public class InvAdjHuModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INVD_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "실사지시상세번호")]
        [StrapVisible(false, false, false)]
        public string INVD_NO { get; set; }
        [Display(Name = "품번")]
        [ReadOnly(true)]
        public string ITEM_CD { get; set; }
        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        public string HU_NO { get; set; }
        [Display(Name = "전산상위식별표번호")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string LOGI_PARENT_HU_NO { get; set; }
        [Display(Name = "실상위식별표번호")]
        public string PHYSI_PARENT_HU_NO { get; set; }
        [Display(Name = "전산재고")]
        [StrapGridSummary(Sum = true)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal LOGI_STOCK { get; set; }
        [Display(Name = "실재고")]
        [StrapGridSummary(Sum = true)]
        public decimal PHYSI_STOCK { get; set; }
        [Display(Name = "차이")]
        [StrapGridSummary(Sum = true)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal DIFF_STOCK { get; set; }
        [Display(Name = "상태")]
        [ReadOnly(true)]
        public string INV_RSLT_HU_STATUS { get; set; }
        [Display(Name = "바코드번호")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string HU_BARCODE { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
        [StrapVisible(false, false, false)]
        public override string REMARK { get => base.REMARK; set => base.REMARK = value; }
        [StrapVisible(false, false, false)]
        public override DateTime? MODIFY_DTTM { get => base.MODIFY_DTTM; set => base.MODIFY_DTTM = value; }
        [StrapVisible(false, false, false)]
        public override string MODIFY_USER_ID { get => base.MODIFY_USER_ID; set => base.MODIFY_USER_ID = value; }
    }
}
