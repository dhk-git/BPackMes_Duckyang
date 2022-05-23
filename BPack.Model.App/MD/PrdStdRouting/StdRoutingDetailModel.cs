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
    public class StdRoutingDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string STR_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int OPER_KEY { get; set; }
        [Display(Name = "표준라우팅번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string STR_NO { get; set; }
        [Display(Name = "공정")]
        public int OPER { get; set; }
        [Display(Name = "공정설명")]
        public string OPER_DESC { get; set; }
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }
        [Display(Name = "자재투입창고")]
        public string MAT_WH_CD { get; set; }
        [Display(Name = "자재투입위치")]
        public string MAT_LOC_CD { get; set; }
        [Display(Name = "생산입고창고")]
        public string GD_WH_CD { get; set; }
        [Display(Name = "생산입고위치")]
        public string GD_LOC_CD { get; set; }
        [Display(Name = "단말기ID")]
        public string DVC_ID { get; set; }
        [Display(Name = "모드ID")]
        public string MODE_ID { get; set; }
    }
}
