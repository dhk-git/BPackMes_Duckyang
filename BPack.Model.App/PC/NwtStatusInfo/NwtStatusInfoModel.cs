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

namespace BPack.Model.App.PC.NwtStatusInfo
{
    public class NwtStatusInfoModel : ModelBase
    {
        
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }


        [Display(Name = "작업장")]
        [StrapMaxWidth(200)]
        public string WC_NM { get; set; }

        [Display(Name = "일자")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [StrapMaxWidth(200)]
        public DateTime WORK_DT { get; set; }


        [Display(Name = "근무조")]
        [StrapVisible(false, false, false)]
        public string SHIFT_CD { get; set; }

        [Display(Name = "근무조")]
        [StrapMaxWidth(200)]
        public string SHIFT_NM { get; set; }


        [Display(Name = "가동시간")]
        [StrapMaxWidth(200)]
        public string WORK_SUM { get; set; }

        [Display(Name = "비가동시간")]
        [StrapMaxWidth(200)]
        public string NOTWORK_SUM { get; set; }

    }
}
