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

namespace BPack.Model.App.QC.NcrHist
{
    public class NcrHistHeaderModel : ModelBase_CommonColumns
    {
        [Display(Name = "등록일자")]
        [ReadOnly(true)]
        public DateTime INSP_DT { get; set; }
        [Display(Name = "근무조코드")]
        [ReadOnly(true)]
        public string SHIFT_CD { get; set; }
        [Display(Name = "부적합번호")]
        [ReadOnly(true)]
        public string NCR_NO { get; set; }
        [Display(Name = "ALC코드")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string ALC_CD { get; set; }
        [Display(Name = "품번")]
        [ReadOnly(true)]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string ITEM_NM { get; set; }
        [Display(Name = "부적합유형")]
        [StrapDisableParam]
        public string NCR_TYPE { get; set; }
        [Display(Name = "부적합코드")]
        public string NCR_CD { get; set; }
        [Display(Name = "판정상태")]
        [ReadOnly(true)]
        public string NCR_STATUS { get; set; }
        [Display(Name = "부적합수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal NCR_QTY { get; set; }
        [Display(Name = "양품수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal NORMAL_QTY { get; set; }
        [Display(Name = "특채수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal SPECIAL_QTY { get; set; }
        [Display(Name = "수정수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal REPAIR_QTY { get; set; }
        [Display(Name = "재작업수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal REWORK_QTY { get; set; }
        [Display(Name = "반송수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal REJECT_QTY { get; set; }
        [Display(Name = "폐기수량")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public decimal SCRAP_QTY { get; set; }
        [Display(Name = "귀책거래처코드")]
        [StrapMinWidth(200)]
        public string R_BP_CD { get; set; }
        [Display(Name = "귀책작업장코드")]
        [StrapMinWidth(200)]
        public string R_WC_CD { get; set; }
        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        public string HU_NO { get; set; }
        [Display(Name = "작업장코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "작업장")]
        [ReadOnly(true)]
        public string WC_NM { get; set; }
        [Display(Name = "창고코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "창고")]
        [ReadOnly(true)]
        public string WH_NM { get; set; }
        [Display(Name = "위치코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string LOC_CD { get; set; }
        [Display(Name = "위치")]
        [ReadOnly(true)]
        public string LOC_NM { get; set; }
        [Display(Name = "검사번호")]
        [ReadOnly(true)]
        public string INSP_NO { get; set; }
        [Display(Name = "부적합설명")]
        public string NCR_DESC { get; set; }
        [Display(Name = "조치사항")]
        public string ACT_DESC { get; set; }
        [Display(Name = "판정일시")]
        [ReadOnly(true)]
        public DateTime? JUDGE_DTTM { get; set; }
        [Display(Name = "판정자")]
        [ReadOnly(true)]
        public string JUDGE_USER { get; set; }
        [Display(Name = "숨김처리여부")]
        public string HIDE_FG { get; set; }


        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NCR_NO_KEY { get; set; }

        [Display(Name = "회사코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "라우팅번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "공정")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int OPER { get; set; }
        [Display(Name = "금형코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string MOLD_CD { get; set; }
        [Display(Name = "거래처코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "처리상태")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string TRT_STATUS { get; set; }


        [Display(Name = "비고")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [StrapMemoEdit]
        public override string REMARK { get; set; }
        [Display(Name = "수정일시")]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string MODIFY_USER_ID { get; set; }
    }
}
