using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.QC.AppHist
{
    public class AppHistDetailModel : ModelBase
    {
        [Display(Name = "검사번호")]
        [StrapVisible(false, false, false)]
        public string INSP_NO { get; set; }

        [Display(Name = "차종")]
        [ReadOnly(true)]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "ALC")]
        [ReadOnly(true)]
        public string ALC_CD { get; set; }

        [Display(Name = "품번")]
        [ReadOnly(true)]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        [ReadOnly(true)]
        public string ITEM_NM { get; set; }

        [Display(Name = "단위")]
        [ReadOnly(true)]
        public string BASE_UNIT { get; set; }

        [Display(Name = "출하지시수량")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        public decimal DO_QTY { get; set; }

        [Display(Name = "합/부판정")]
        public string INSP_JUDGE_QC { get; set; }

        [Display(Name = "검사시간")]
        [StrapVisible(false, false, false)]
        public DateTime? INSP_DTTM_QC { get; set; }

        [Display(Name = "검사수량")]
        public decimal INSP_QTY { get; set; }

        [Display(Name = "검사차수")]
        public int INSP_SEQ { get; set; }

        [Display(Name = "개별식별번호")]
        [ReadOnly(true)]
        public string HU_NO { get; set; }

        [Display(Name = "생산일")]
        [StrapVisible(false, false, false)]
        public DateTime? WORK_DT { get; set; }

        [Display(Name = "LOT NO")]
        public string LOT_NO { get; set; }

        [Display(Name = "바코드")]
        [ReadOnly(true)]
        public string HU_BARCODE { get; set; }

        [Display(Name = "비고")]
        public string REMARK { get; set; }

        [Display(Name = "파일명")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string FILE_NAME { get; set; }

        [Display(Name = "파일경로")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string FILE_NAME_IN_SERVER { get; set; }

        [Display(Name = "식별표리스트 ")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string HU_NO_LIST { get; set; }

    }
}
