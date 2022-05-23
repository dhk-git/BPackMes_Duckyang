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

namespace BPack.Model.App.MD.BpaGate
{
    public class GateModel : ModelBase_CommonColumns_With_DelFlag
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
        public string GATE_CD_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false)]
        public string COMP_CD { get; set; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false)]
        public string BP_CD { get; set; }
        [Display(Name = "매입/매출처코드")]
        public string GATE_CD { get; set; }
        [Display(Name = "매입/매출처명")]
        public string GATE_NM { get; set; }
        [Display(Name = "매입여부")]
        public bool IS_PURCHASE { get; set; }
        [Display(Name = "매출여부")]
        public bool IS_SALES { get; set; }
        [Display(Name = "납품창고코드")]
        [StrapVisible(false)]
        public string WH_CD { get; set; }
        [Display(Name = "납품위치코드")]
        [StrapVisible(false)]
        public string LOC_CD { get; set; }

        [Display(Name = "유효시작일")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime VALID_FROM_DT { get; set; }
        [Display(Name = "유효종료일")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime VALID_TO_DT { get; set; }

        [Display(Name = "출하지")]
        public string DLV_SPOT { get; set; }
        [Display(Name = "고객공장코드")]
        public string CUST_PLANT_CD { get; set; }
    }
}
