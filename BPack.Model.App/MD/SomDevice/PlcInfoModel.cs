using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.SomDevice
{
    public class PlcInfoModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DVC_ID_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string TAG_GR_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string TAG_ID_KEY { get; set; }
        [Display(Name = "단말기ID")]
        [StrapVisible(false, false, false)]
        public string DVC_ID { get; set; }
        [Display(Name = "태그ID")]
        public string TAG_ID { get; set; }
        [Display(Name = "태그그룹")]
        public string TAG_GR { get; set; }
        [Display(Name = "태그명")]
        public string TAG_NM { get; set; }
        [Display(Name = "어드레스")]
        public string ADDR { get; set; }
        [Display(Name = "데이터타입")]
        public string DATA_TYPE { get; set; }
        [Display(Name = "길이")]
        public int DATA_LENGTH { get; set; }
        [Display(Name = "읽기유무")]
        public bool READ_YN { get; set; }
        [Display(Name = "쓰기유무")]
        public bool WRITE_YN { get; set; }
        [Display(Name = "더미1")]
        public string DUMMY_1 { get; set; }
        [Display(Name = "더미2")]
        public string DUMMY_2 { get; set; }
        [Display(Name = "더미3")]
        public string DUMMY_3 { get; set; }
        [Display(Name = "삭제FLAG")]
        public string DEL_FG { get; set; }
    }
}
