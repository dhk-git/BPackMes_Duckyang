using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvResultDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DRD_NO_KEY { get; set; }
        [Display(Name = "출하실적번호")]
        [StrapVisible(false, false, false)]
        [StrapDenyEdit]
        public string DRH_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapDenyEdit]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDenyEdit]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        [StrapDenyEdit]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "지시수량")]
        [StrapDenyEdit]
        public decimal DOD_QTY { get; set; }
        [Display(Name = "실적수량")]
        [StrapDenyEdit]
        public decimal DLV_QTY { get; set; }
        [Display(Name = "차이")]
        [StrapDenyEdit]
        public decimal DIFF_QTY { get; set; }
        [Display(Name = "고객발주번호")]
        public string CUSTOM_PO_NO { get; set; }
        [Display(Name = "출하지시상세번호")]
        [StrapDenyEdit]
        public string DOD_NO { get; set; }
        [Display(Name = "출하실적상세번호")]
        [StrapDenyEdit]
        public string DRD_NO { get; set; }
    }
}
