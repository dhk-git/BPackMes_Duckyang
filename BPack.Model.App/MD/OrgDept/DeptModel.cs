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
    public class DeptModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DEPT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "부서코드")]
        public string DEPT_CD { get; set; }
        [Display(Name = "부서명")]
        public string DEPT_NM { get; set; }
        [Display(Name = "상위부서코드")]
        public string PARENT_DEPT_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "유효종료일")]
        public DateTime VALID_TO_DT { get; set; }
    }
}
