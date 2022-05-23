using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.DlvJisTrtRule
{
    public class DlvJisTrtRuleHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DLV_PLC_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string TRT_RULE_ID_KEY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        
        [ReadOnly(true)]
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "납품장소코드")]
        [StrapVisible(false, false, false)]
        public string DLV_PLC_CD { get; set; }
        
        [Display(Name = "처리기준ID")]
        public string TRT_RULE_ID { get; set; }
        
        [Display(Name = "처리기준명")]
        public string TRT_RULE_NM { get; set; }
        
        [Display(Name = "품목그룹1(차종)")]
        public string ITEM_GR_1 { get; set; }
        
        [Display(Name = "구분자1")]
        public string BODY_PREFIX1 { get; set; }
        
        [Display(Name = "구분자2")]
        public string BODY_PREFIX2 { get; set; }
        
        [Display(Name = "구분자3")]
        public string BODY_PREFIX3 { get; set; }

        [Display(Name = "처리유형")]
        public string ALC_TRT_TYPE { get; set; }

        [Display(Name = "처리방법")]
        public string ALC_TRT_METHOD { get; set; }

        [Display(Name = "ALC번호(SOURCE)")]
        public string ALC_NO_SOURCE { get; set; }
        
        [Display(Name = "ALC번호(TARGET)")]
        public string ALC_NO_TARGET { get; set; }
    }
}
