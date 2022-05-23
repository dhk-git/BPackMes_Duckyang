using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.NwtStatusInfo
{
    public class NwtStatusInfoListModel : ModelBase
    {
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int WK_SEQ_KEY { get; set; }


        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int COMP_CD_KEY { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int PLANT_CD_KEY { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [StrapDisableParam]
        public int WK_SEQ { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        [StrapDisableParam]
        public string COMP_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        [StrapDisableParam]
        public string PLANT_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "작업장코드")]
        [StrapDisableParam]
        public string WC_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "작업장")]
        [StrapDisableParam]
        [StrapMaxWidth(200)]
        public string WC_NM { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public DateTime WORK_DT { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "근무조")]
        [StrapDisableParam]
        public string SHIFT_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "근무조")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string SHIFT_NM { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "상태")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string WORK_STATUS { get; set; }

        [StrapVisible(true, false, true)]
        [Display(Name = "비가동 코드")]
        [StrapMaxWidth(200)]
        public string NOWK_CD { get; set; }

        [StrapVisible(true, false, false)]
        [Display(Name = "비가동명")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string NOWK_NM { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "작업지시")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string WO_NO { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "ALC")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string ALC_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "품번")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string ITEM_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "품명")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string ITEM_NM { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "시작")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [StrapMaxWidth(300)]
        [StrapDisableParam]
        public DateTime START_DTTM { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "종료")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [StrapMaxWidth(300)]
        [StrapDisableParam]
        public DateTime END_DTTM { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "누계")]
        [StrapMaxWidth(200)]
        [StrapDisableParam]
        public string WORK_HOURS { get; set; }

    }
}
