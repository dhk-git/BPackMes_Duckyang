using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.OrgUser
{
    public class UserModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string USER_ID_KEY { get; set; }
        [Display(Name = "사용자ID")]
        public string USER_ID { get; set; }
        [Display(Name = "패스워드")]
        [StrapVisible(false, false, false)]
        public string USER_PW { get; set; }
        [Display(Name = "사용자명")]
        public string USER_NM { get; set; }

        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }


        [Display(Name = "부서")]
        public string DEPT_CD { get; set; }

        [Display(Name = "유효시작일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        [Display(Name = "유효종료일")]
        [StrapVisible(false, false, false)]
        public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);

        [Display(Name = "삭제유무")]
        [StrapVisible(true, true, true)]
        public override string DEL_FG { get; set; }

        [Display(Name = "PDA알림TOPIC")]
        [StrapVisible(false, false, false)]
        public string RECEIVE_MQTT_TOPIC { get; set; }
    }
}
