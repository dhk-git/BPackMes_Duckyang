using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.MaterialRequest
{
    public class MrqdListModel: ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MRD_NO_KEY { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string MRH_NO_KEY { get; set; }

        [StrapDisableParam]
        [Display(Name = "불출지시번호")]
        public string MRH_NO { get; set; }

        [Display(Name = "회사")]
        public string COMP_CD { get; set; }
        [Display(Name = "공장")]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }


        [StrapDisableParam]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [ReadOnly(true)]
        [StrapDenyEdit]
        [StrapDisableParam]
        [Display(Name = "요청식별표수")]
        public decimal MRD_QTY { get; set; }

        [ReadOnly(true)]
        [StrapDenyEdit]
        [StrapDisableParam]
        [Display(Name = "요청수량")]
        public decimal HU_STOCK_QTY { get; set; }


        [StrapDisableParam]
        [Display(Name = "출고식별표수")]
        public decimal OUT_QTY { get; set; }

        [ReadOnly(true)]
        [StrapDenyEdit]
        [StrapDisableParam]
        [Display(Name = "출고수량")]
        public decimal HU_OUT_STOCK_QTY { get; set; }


        [Display(Name = "상태")]
        public string MRD_STATUS { get; set; }
        [StrapDisableParam]
        [Display(Name = "불출지시상세번호")]
        public string MRD_NO { get; set; }

    }
}
