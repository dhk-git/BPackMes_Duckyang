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

namespace BPack.Model.App.MD.PrdRouting
{
    public class BomHeaderModel : ModelBase_CommonColumns_With_DelFlag 
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BOM_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "BOM번호")]
        public string BOM_NO { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "공장코드")]                        
        public string PLANT_CD { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "기준일자")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "BOM종류")]
        [StrapVisible(false, false, false)]
        public string BOM_KIND { get; set; }
        [Display(Name = "리비전")]
        [StrapVisible(false, false, false)]
        public int BOM_REV { get; set; }
        [Display(Name = "소요기준수량")]
        public decimal BOM_BASE_QTY { get; set; }
        [Display(Name = "소요기준단위")]
        public string BOM_BASE_UNIT { get; set; }

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
