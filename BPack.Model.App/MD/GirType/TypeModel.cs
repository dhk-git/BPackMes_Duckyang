using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.GirType
{
    public class TypeModel : ModelBase_CommonColumns_With_DelFlag
    {
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string GIR_TYPE_CD_KEY { get; set; }
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "수불코드")]
        public string GIR_TYPE_CD { get; set; }
        [Display(Name = "수불명")]
        public string GIR_TYPE_NM { get; set; }
        [Display(Name = "입출고구분")]
        public string INOUT_CLS { get; set; }
        [Display(Name = "입출고유형")]
        public string INOUT_TYPE { get; set; }
        [Display(Name = "ERP코드맵핑")]
        public string ERP_CODE_MAP { get; set; }
        //[Display(Name = "비고")]
        //public string REMARK { get; set; }
        //[Display(Name = "삭제FLAG(Y=삭제)")]
        //public string DEL_FG { get; set; }
        //[Display(Name = "생성일시")]
        //public DateTime CREATE_DTTM { get; set; }
        //[Display(Name = "수정일시")]
        //public DateTime MODIFY_DTTM { get; set; }
        //[Display(Name = "생성자")]
        //public string CREATE_USER_ID { get; set; }
        //[Display(Name = "수정자")]
        //public string MODIFY_USER_ID { get; set; }

        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string COMP_CD_KEY { get; set; }
        //[ReadOnly(true)]
        //[Key]
        //[StrapVisible(false, false, false)]
        //public string GIR_TYPE_CD_KEY { get; set; }
        //[ReadOnly(true)]
        //[Display(Name = "회사코드")]
        //[StrapVisible(false, false, false)]
        //public string COMP_CD { get; set; }
        //[Display(Name = "수불코드")]
        //public string GIR_TYPE_CD { get; set; }
        //[Display(Name = "수불명")]
        //public string GIR_TYPE_NM { get; set; }
        //[Display(Name = "입출고구분")]
        //public string INOUT_CLS { get; set; }
        //[Display(Name = "입출고유형")]
        //public string INOUT_TYPE { get; set; }
        //[Display(Name = "ERP코드맵핑")]
        //public string ERP_CODE_MAP { get; set; }
        //[Display(Name = "유효시작일")]
        //public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        //[Display(Name = "유효종료일")]
        //public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
