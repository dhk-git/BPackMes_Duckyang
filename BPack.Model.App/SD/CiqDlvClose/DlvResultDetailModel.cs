using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.CiqDlvClose
{
    public class DlvResultDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DRD_NO_KEY { get; set; }
        [Display(Name = "출하실적상세번호")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string DRD_NO { get; set; }

        [Display(Name = "고객사")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string BP_CD { get; set; }

        [Display(Name = "출하실적번호")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string DRH_NO { get; set; }

        [Display(Name = "출하지시상세번호")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string DOD_NO { get; set; }

        [Display(Name = "납품일자")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public DateTime DLV_DT { get; set; }

        [Display(Name = "납품번호(SKBA)")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string CUST_DOH_NO { get; set; }

        [Display(Name = "발주번호(SKBA)")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string CUSTOM_PO_NO { get; set; }

        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string PLANT_CD { get; set; }

        [Display(Name = "품번")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_NM { get; set; }

        [Display(Name = "제품군")]
        [StrapDisableParam]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "납품수량")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public decimal DLV_QTY { get; set; }

        [Display(Name = "반품/취소수량")]
        public decimal RETURN_QTY { get; set; }

        [Display(Name = "납품완료수량")]
        [StrapToolTip("납품완료수량")]
        public decimal CLOSE_QTY { get; set; }
        
        [Display(Name = "납품차량")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string VEHICLE_NO { get; set; }
        [Display(Name = "납품기사")]
        [StrapDenyEdit]
        [StrapDisableParam]
        public string DRIVER_NM { get; set; }
    }
}
