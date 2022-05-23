using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.GirWareHouse
{
    public class WareHouseModel : ModelBase_CommonColumns_With_DelFlag
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
        public string WH_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [ReadOnly(true)]
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        public string WH_CD { get; set; }
        [Display(Name = "창고명")]
        public string WH_NM { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "창고유형")]
        public string WH_TYPE { get; set; }
        [Display(Name = "창고그룹")]
        public string WH_GR { get; set; }
        [Display(Name = "재고유형")]
        public string WH_STOCK_TYPE { get; set; }
        //[Display(Name = "유효시작일")]
        //public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        //[Display(Name = "유효종료일")]
        //public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);
    }
}
