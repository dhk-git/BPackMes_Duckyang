using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.MebLot
{
    public class MPackAndPartLotModel : ModelBase
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PACK_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PART_LOT_KEY { get; set; }
        [Display(Name = "중포장번호")]
        public string PACK_NO { get; set; }
        [Display(Name = "부품LOT")]
        public string PART_LOT { get; set; }
        [Display(Name = "포장일자")]
        public string PACK_DATE { get; set; }
        [Display(Name = "선적일자")]
        public string SHIP_DATE { get; set; }
        [Display(Name = "사용유무")]
        public string USE_YN { get; set; }
        [Display(Name = "IF유무")]
        public string SEND_YN { get; set; }
        [Display(Name = "저장일시")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "수정일시")]
        public DateTime SAVE_DTTM { get; set; }
        [Display(Name = "저장자")]
        public string CREATE_BY { get; set; }
        [Display(Name = "수정자")]
        public string SAVE_BY { get; set; }
    }
}
