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

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvResultModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DRH_NO_KEY { get; set; }

        [Display(Name = "회사코드")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "고객사납품번호")]
        public string CUST_DOH_NO { get; set; }
        [Display(Name = "차량번호")]
        public string VEHICLE_NO { get; set; }
        [Display(Name = "운전자")]
        public string DRIVER_NM { get; set; }
        [Display(Name = "거래처코드")]
        [StrapDenyEdit]
        [StrapVisible(true, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "출하실적번호")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string DRH_NO { get; set; }
        [Display(Name = "출하지시번호")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string DOH_NO { get; set; }

        [Display(Name = "출하순서")]
        [StrapDenyEdit]
        [StrapVisible(true, false, false)]
        public int ORDER_SEQ { get; set; }


        [Display(Name = "출하지시일자")]
        [StrapDenyEdit]
        [StrapVisible(true, false, false)]
        public DateTime DOH_DT { get; set; }


        [Display(Name = "등록일자")]
        [StrapDenyEdit]
        [StrapVisible(true, false, false)]
        public DateTime PICKING_DT { get; set; }
        [Display(Name = "확정일자")]
        [StrapDenyEdit]
        [StrapVisible(true, false, false)]
        public DateTime? DLV_DT { get; set; }
        [Display(Name = "확정시간")]
        [StrapDenyEdit]
        [StrapVisible(true, false, false)]
        public TimeSpan? DLV_TM { get; set; }
        [Display(Name = "출하실적상태")]
        [StrapDenyEdit]
        [StrapLookUpEditCode(CoreOrApp.Core, "DRH_STATUS")]
        [StrapVisible(true, false, false)]
        public string DRH_STATUS { get; set; }

        //2021.12.28 정수교 추가
        [StrapVisible(true, false, false)]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string MIN_GR { get; set; }

        [StrapVisible(true, false, false)]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string MAX_GR { get; set; }

    }
}
