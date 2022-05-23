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
    public class DeviceModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DVC_ID_KEY { get; set; }
        [Display(Name = "단말기ID")]
        public string DVC_ID { get; set; }
        [Display(Name = "단말기명")]
        public string DVC_NM { get; set; }
        [Display(Name = "단말기유형")]
        public string DVC_TYPE { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "설치작업장코드")]
        public string WC_CD { get; set; }
        [Display(Name = "제품일련번호")]
        public string DVC_NO { get; set; }
        [Display(Name = "IP")]
        public string DVC_IP { get; set; }
        [Display(Name = "POP화면유형")]
        public string POP_TYPE { get; set; }
        [Display(Name = "바코드발행구분코드")]
        public string BARCODE_CLS_CD { get; set; }
        [Display(Name = "바코드발행고객사코드")]
        public string BARCODE_BP_CD { get; set; }
        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
        
    }
}
