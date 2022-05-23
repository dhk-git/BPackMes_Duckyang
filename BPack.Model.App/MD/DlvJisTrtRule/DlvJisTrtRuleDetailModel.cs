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
    public class DlvJisTrtRuleDetailModel : ModelBase_CommonColumns
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
        [Key]
        [StrapVisible(false, false, false)]
        public string ALC_CD_KEY { get; set; }

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

        [ReadOnly(true)]
        [Display(Name = "처리기준ID")]
        [StrapVisible(false, false, false)]
        public string TRT_RULE_ID { get; set; }

        [Display(Name = "ALC코드")]
        public string ALC_CD { get; set; }

        [Display(Name = "ALC코드(변환)")]
        public string ALC_CD_TARGET { get; set; }
    }
}
