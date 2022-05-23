using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirClose
{
    public class CloseGirTypeModel : ModelBase_CommonColumns
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "마감일자")]
        [StrapVisible(false, false, false)]
        public DateTime CLOSE_DT { get; set; }
        [Display(Name = "창고코드")]
        public string WH_CD { get; set; }
        [Display(Name = "품목코드")]
        public string ITEM_CD { get; set; }
        [Display(Name = "수불코드")]
        public string GIR_TYPE_CD { get; set; }
        [Display(Name = "수량")]
        public decimal GIR_QTY { get; set; }
    }
}
