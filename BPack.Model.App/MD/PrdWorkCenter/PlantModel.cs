using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdWorkCenter
{
    public class PlantModel : ModelBase_CommonColumns_With_CompCD_PlantCD
    {
        [Display(Name = "공장코드")]
        [StrapVisible(true)]
        [StrapMinWidth(80)]
        public override string PLANT_CD { get => base.PLANT_CD; set => base.PLANT_CD = value; }
        [Display(Name = "공장명")]
        [StrapMinWidth(120)]
        public string PLANT_NM { get; set; }
        [StrapVisible(false)]
        public override string REMARK { get => base.REMARK; set => base.REMARK = value; }
    }
}
