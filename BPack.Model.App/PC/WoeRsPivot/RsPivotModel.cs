using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeRsPivot
{
    public class RsPivotModel: ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }

        [Display(Name = "생산일자")]
        public DateTime WORK_DT { get; set; }
        public string SHIFT_CD { get; set; }

        [Display(Name = "근무조")]
        public string SHIFT_NM { get; set; }

        [Display(Name = "시간")]
        public string HOUR_CD { get; set; }

        public string WC_CD { get; set; }

        [Display(Name = "작업장")]
        public string WC_NM { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "품목유형")]
        public string ITEM_TYPE_NM { get; set; }

        [Display(Name = "수량")]
        public decimal RST_QTY { get; set; }
    }
}
