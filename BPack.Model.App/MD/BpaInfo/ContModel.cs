using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.BpaInfo
{
    public class ContModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string BP_CD_KEY { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ADDI_NO_KEY { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }

        [Display(Name = "일련번호")]
        [StrapVisible(false, false, false)]
        public string ADDI_NO { get; set; }

        [Display(Name = "연락처명")]
        public string CONTACT_NM { get; set; }

        [Display(Name = "전화1")]
        public string PHONE_NO1 { get; set; }

        [Display(Name = "전화2")]
        public string PHONE_NO2 { get; set; }

        [Display(Name = "팩스")]
        public string FAX { get; set; }

        [Display(Name = "이메일")]
        public string EMAIL { get; set; }

        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; }

        [Display(Name = "유효종료일")]
        public DateTime VALID_TO_DT { get; set; }
        
        
        
    }
}
