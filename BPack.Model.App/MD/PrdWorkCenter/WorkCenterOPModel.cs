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

namespace BPack.Model.App.MD.PrdWorkCenter
{
    public class WorkCenterOPModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int ROW_SEQ_KEY { get; set; }
        [Display(Name = "등록번호")]
        public override int ROW_SEQ { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "작업자명")]
        [StrapLookUpEditAllUsers]
        public string OPER_NM { get; set; }

        [Display(Name = "유효시작일")]
        public DateTime VALID_FROM_DT { get; set; }
        [Display(Name = "유효종료일")]
        public DateTime VALID_TO_DT { get; set; }
    

    }
}
