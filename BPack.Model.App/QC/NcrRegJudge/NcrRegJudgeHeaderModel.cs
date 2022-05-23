using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.QC.NcrRegJudge
{
    public class NcrRegJudgHeaderModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NCD_NO_KEY { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "등록일자")]
        public DateTime NCH_DT { get; set; }

        [ReadOnly(true)]
        [StrapVisible(true, false, false)]
        [Display(Name = "부적합상세등록번호")]
        public string NCD_NO { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "부적합등록유형")]
        public string NCH_TYPE { get; set; }

        [ReadOnly(true)]
        [Display(Name = "참조유형")]
        public string REF_DOC_TYPE { get; set; }

        [ReadOnly(true)]
        [Display(Name = "참조문서번호")]
        public string REF_DOC_NO { get; set; }

        [ReadOnly(true)]
        [Display(Name = "창고")]
        public string NCR_WH_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [ReadOnly(true)]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        //2022.02.10 추가
        //부적합 양품 등록시 신규 식별표 발행 여부
        // N 인 경우 신규 식별표 발행 안함,팝업창에서 확인 ,신규 식별표 발행 여부 팝업 호출
        // Y 인 경우 신규 식별표 생성 ,신규 식별표 발행
        [StrapVisible(false, false, false)]
        public string JUDGE_NEW_PRINT_YN { get; set; }


        [ReadOnly(true)]
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }


        [ReadOnly(true)]
        [Display(Name = "불량수량")]
        public int DEFECT_QTY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "판정수량")]
        public int JUDGE_QTY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "미처리수량")]
        public int REMAIN_QTY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "불량유형")]
        public string DEFECT_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }

        //2022.02.10 추가
        //Y는 기본
        //N인 경우 신규 식별표 발행 없음.
        [StrapVisible(false, false, false)]
        public string JUDGE_HU_STATUS { get; set; }
        


        [Display(Name = "처리상태")]
        public string JUDGE_RESULT { get; set; }
    }
}
