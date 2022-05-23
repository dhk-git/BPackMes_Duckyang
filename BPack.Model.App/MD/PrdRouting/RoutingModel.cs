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
    public class RoutingModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "라우팅번호")]
        public string ROUTE_NO { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapMinWidth(120)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapMinWidth(150)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapDisableParam]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }

        [Display(Name = "차종")]
        [StrapMinWidth(80)]
        [StrapDisableParam]
        [ReadOnly(true)]
        
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "ALC코드")]
        [StrapMinWidth(80)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string ALC_CD { get; set; }

        [Display(Name = "리비전")]
        [StrapMinWidth(60)]
        [ReadOnly(true)]
        public int ROUTE_REV { get; set; }


        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);

        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
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
