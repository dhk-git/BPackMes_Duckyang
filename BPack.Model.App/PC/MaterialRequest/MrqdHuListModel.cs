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

namespace BPack.Model.App.PC.MaterialRequest
{
    public class MrqdHuListModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string MRD_NO_KEY { get; set; }

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string HU_NO_KEY { get; set; }

        [StrapDisableParam]
        [Display(Name = "불출지시상세번호")]
        public string MRD_NO { get; set; }


        [Display(Name = "회사")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고일")]
        public DateTime WORK_DT { get; set; }

        [StrapDisableParam]
        [Display(Name = "품번")]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "창고")]
        public string WH_CD { get; set; }

        [StrapDisableParam]
        [Display(Name = "위치")]
        public string LOC_CD { get; set; }


        [Display(Name = "식별표번호")]
        [StrapVisible(false, false, false)]
        public string HU_NO { get; set; }

        [Display(Name = "Barcode")]
        [StrapDisableParam]
        public string BARCODE_TEXT { get; set; }

        [Display(Name = "재고수량")]
        public decimal STOCK_QTY { get; set; }

        [Display(Name = "상태")]
        public string MRD_HU_STATUS { get; set; }

        [StrapDisableParam]
        [Display(Name = "입고검사유무")]
        public string HU_INSP_STATUS { get; set; }


        [StrapDisableParam]
        [ReadOnly(true)]
        [Display(Name = "등록")]
        public bool IS_REG { get; set; }

        [StrapDisableParam]
        [ReadOnly(true)]
        [Display(Name = "예약 등록")]
        public bool IS_OTHER_REG { get; set; }


        public string CrudCls2 { get; set; } = "";
    }
}
