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

namespace BPack.Model.App.MD.OrgPlant
{
    public class PlantModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [Display(Name = "회사코드")]
        [ReadOnly(true)]
        [Key]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "공장명")]
        public string PLANT_NM { get; set; }
        [Display(Name = "기준근무시작시간")]
        public TimeSpan WORK_FROM_TM { get; set; }
        [Display(Name = "대표전화")]
        public string TEL { get; set; }
        [Display(Name = "전화Dummy1")]
        [StrapVisible(false, false, false)]
        public string TEL1 { get; set; }
        [Display(Name = "주소")]
        public string ADDR { get; set; }
        [Display(Name = "통화(환종)")]
        public string CURRENCY_TYPE { get; set; }

        [Display(Name = "유효시작일")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime VALID_FROM_DT { get; set; }
        [Display(Name = "유효종료일")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd")]
        public DateTime VALID_TO_DT { get; set; }
      

    }
}
