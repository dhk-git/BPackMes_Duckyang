using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.JisDetailSum
{
    public class JisDetailSumModel : ModelBase
    {
        [Display(Name = "서열(생산기준)일자")]
        [ReadOnly(true)]
        public DateTime DT { get; set; }

        [Display(Name = "차종")]
        [ReadOnly(true)]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "ALC")]
        [ReadOnly(true)]
        public string ALC_CD { get; set; }

        [Display(Name = "품번")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]

        public string ITEM_CD { get; set; }

        [Display(Name = "수신수량")]
        [ReadOnly(true)]
        public int CNT { get; set; }

    }
}
