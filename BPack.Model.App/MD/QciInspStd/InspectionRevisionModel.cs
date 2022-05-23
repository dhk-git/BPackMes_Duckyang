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

namespace BPack.Model.App.MD.QciInspStd
{
    public class InspectionRevisionModel : ModelBase_CommonColumns_With_DelFlag
    {
        [Display(Name = "리비젼")]
        [ReadOnly(true)]
        public int REVISION { get; set; }
        [Display(Name = "전수검사여부")] 
        public string ALL_FG { get; set; } = "N";

        [Display(Name = "SAMPLE수량")]
        public int SAMPLE_CNT { get; set; }
        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);


        [Display(Name = "ALC")]
        [StrapDisableParam]
        public string ALC_CD { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_STD_ID_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int REVISION_KEY { get; set; }
        [Display(Name = "검사기준ID")]
        [StrapVisible(false, false, false)]
        public string INSP_STD_ID { get; set; }

        [Display(Name = "검사유형")]
        [StrapVisible(false, false, false)]
        public string INSP_TYPE { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품목명")]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string ITEM_NM { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "라우팅번호")]
        public string ROUTE_NO { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "공정")]
        public int OPER { get; set; }
        
        [Display(Name = "참조파일")]
        public string FILE_GROUP_ID { get; set; }

        [Display(Name = "사용여부")]
        [StrapVisible(false, false, false)]
        public string USE_FG { get; set; }

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
