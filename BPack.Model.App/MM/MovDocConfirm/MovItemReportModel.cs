using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.MovDocConfirm
{
    public class MovItemReportModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MOD_NO_KEY { get; set; }
        [Display(Name = "재고이동상세번호")]
        public string MOD_NO { get; set; }
        [Display(Name = "이동번호")]
        public string MOV_NO { get; set; }
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapDisableParam]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "이동수량")]
        public decimal MOV_QTY { get; set; }
        [Display(Name = "단위")]
        [StrapDisableParam]
        public string BASE_UNIT { get; set; }
        public List<MovHuReportModel> MovHuModels { get; set; }
    }
}
