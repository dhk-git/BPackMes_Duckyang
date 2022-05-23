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

namespace BPack.Model.App.QC.QchFmlRead
{
    public class QchFmlReadHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string INSP_NO_KEY { get; set; }
        //생산일자
        [Display(Name = "지시일자(계획일자)")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public DateTime WO_DT { get; set; }

        [Display(Name = "근무조코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string SHIFT_CD { get; set; }

        [Display(Name = "검사번호")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_NO { get; set; }

        [Display(Name = "검사기준ID")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string INSP_STD_ID { get; set; }
        [Display(Name = "리비젼")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public int REVISION { get; set; }
        [Display(Name = "검사유형")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_TYPE { get; set; }

        [Display(Name = "라인정지여부")]
        public string STOP_FG { get; set; }

        [Display(Name = "검사세부유형")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_SUB_TYPE { get; set; }
        [Display(Name = "회사코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }


        [Display(Name = "품목코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string ITEM_CD { get; set; }

        [Display(Name = "차종")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "라우팅번호")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "공정")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public int OPER { get; set; }

        [Display(Name = "작업장코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string WC_CD { get; set; }

        [Display(Name = "창고코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [StrapVisible(false, false, false)]
        [Display(Name = "위치코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string LOC_CD { get; set; }
        [Display(Name = "초중종그룹")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string FML_GR { get; set; }
        [Display(Name = "단말기ID")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string DVC_ID { get; set; }

        [Display(Name = "거래처코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "설비코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string EQUIP_CD { get; set; }


        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string HU_NO { get; set; }

        [Display(Name = "검사수량")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public decimal INSP_QTY { get; set; }

        [Display(Name = "참조번호 (초중종검사/최종검사:")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string REF_NO { get; set; }


        [Display(Name = "검사자(생산)")]
        [ReadOnly(true)]
        [StrapDisableParam]

        public string EMP_PC { get; set; }

        [Display(Name = "합/부판정(생산)")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_JUDGE_PC { get; set; }
        [Display(Name = "검사시간(생산)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public DateTime INSP_DTTM_PC { get; set; }


        [Display(Name = "검사자(품질)")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string EMP_QC { get; set; }
        
        [Display(Name = "합/부판정(품질)")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string INSP_JUDGE_QC { get; set; }

        [Display(Name = "검사시간(품질)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public DateTime? INSP_DTTM_QC { get; set; }

        //금형코드
        //금형명
        [Display(Name = "금형코드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string MOLD_CD { get; set; }
        [Display(Name = "금형명")]
        [ReadOnly(true)]
        [StrapDisableParam]
        public string MOLD_NM { get; set; }

        [Display(Name = "생성모드")]
        [ReadOnly(true)]
        [StrapDisableParam]
        [StrapVisible(false, false, false)]
        public string CREATE_MODE { get; set; }


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
