using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdStdRouting
{
    public class StdRoutingModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string STR_NO_KEY { get; set; }
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "표준라우팅번호")]
        [ReadOnly(true)]
        public string STR_NO { get; set; }
        [Display(Name = "공정그룹")]
        public string PROC_GR_CD { get; set; }
        [Display(Name = "품목유형")]
        [StrapVisible(false, false, false)]
        public string ITEM_TYPE { get; set; }
        [Display(Name = "품목그룹(차종[&사양구분])")]
        [StrapToolTip("차종과 사양구분의 조건으로 작업지시등록시 자동선택 되도록함\r\n예)BD차종4DR일때 : BD&M (M=BD4DR, N=BD5DR)\r\n차종으로만 구분할시 \"&\"와사양구분은 생략함")]
        public string ITEM_GR { get; set; }
        [Display(Name = "사양구분")]
        [StrapVisible(false, false, false)] 
        public string ITEM_GR_2 { get; set; } //울산db에 생성해놨으나 아직 미적용 20210609 - 차종에 "&"로 작성하는걸 컬럼에 선택하는걸로 바꾸는게 
        [Display(Name = "적용일")]
        [StrapVisible(false, false, false)]
        public DateTime APPLY_DT { get; set; }

    }
}
