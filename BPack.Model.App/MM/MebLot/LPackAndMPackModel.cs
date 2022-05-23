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
    public class LPackAndMPackModel : ModelBase
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PACK_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string M_PACK_NO_KEY { get; set; }
        [Display(Name = "대포장번호")]
        public string PACK_NO { get; set; }
        [Display(Name = "중포장번호")]
        public string M_PACK_NO { get; set; }
        [Display(Name = "CASE NO")]
        public string CASE_NO { get; set; }
        [Display(Name = "ORDER NO")]
        public string ORDER_NO { get; set; }
        [Display(Name = "품번")]
        public string PART_NO { get; set; }
        [Display(Name = "수량")]
        public int QTY { get; set; }
        [Display(Name = "LOT")]
        public string LOT { get; set; }
        [Display(Name = "작업일")]
        public string WORK_DATE { get; set; }
        [Display(Name = "사용유무")]
        public string USE_YN { get; set; }
        [Display(Name = "I/F유무")]
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
