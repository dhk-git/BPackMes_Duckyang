using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MI.UserInfo
{
    public class UserInfoModel : ModelBase_CommonColumns_With_CompCode
    {
        [Key]
        [StrapVisible(false, false, false)]
        public string USER_ID_KEY { get; set; }
        [Display(Name = "사용자ID")]
        public string USER_ID { get; set; }
        [Display(Name = "사용자명")]
        public string USER_NAME { get; set; }
        [Display(Name = "사용자PW")]
        [StrapVisible(false, true, true)]
        public string USER_PW { get; set; }
        [StrapLookUpEditCode(CoreOrApp.App, "DEPT")]
        [Display(Name = "부서")]
        public string DEPT_CODE { get; set; }
        [StrapLookUpEditCode(CoreOrApp.App, "POSITION")]
        [Display(Name = "직급")]
        public string POSITION_CODE { get; set; }
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string GROUPS { get; set; }
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public string LOGIN_GUID { get; set; }
    }
}
