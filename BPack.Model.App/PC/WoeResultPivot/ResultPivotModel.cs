using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResultPivot
{
    public class ResultPivotModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        [Display(Name = "생산일자")]
        public DateTime WORK_DT { get; set; }
        public string SHIFT_CD { get; set; }
        [Display(Name = "근무조")]
        public string SHIFT_NM { get; set; }
        [Display(Name = "작업시간")]
        public string WORK_TM { get; set; }
        public string WC_CD { get; set; }
        [Display(Name = "작업장")]
        public string WC_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_NM { get; set; }
        [Display(Name = "양/불")]
        public string OK_NG { get; set; }
        [Display(Name = "수량")]
        public decimal HU_INIT_QTY { get; set; }
    }
}
