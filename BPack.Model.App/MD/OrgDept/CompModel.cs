using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.OrgDept
{
    public class CompModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "회사명")]
        public string COMP_NM { get; set; }
        [Display(Name = "등록번호")]
        public string REG_NO { get; set; }
        [Display(Name = "사업자번호")]
        public string DUNS { get; set; }
        [Display(Name = "주소")]
        public string ADDR { get; set; }
        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; }
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public override string REMARK { get => base.REMARK; set => base.REMARK = value; }
        [StrapVisible(false, false, false)]
        public override DateTime? MODIFY_DTTM { get => base.MODIFY_DTTM; set => base.MODIFY_DTTM = value; }
        [StrapVisible(false, false, false)]
        public override string MODIFY_USER_ID { get => base.MODIFY_USER_ID; set => base.MODIFY_USER_ID = value; }
    }
}
