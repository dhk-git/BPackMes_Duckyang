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
    public class NcrRegJudgeDetailModel: ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string NCD_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int JUDGE_SEQ_KEY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "부적합상세등록번호")]
        public string NCD_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "판정SEQ")]
        public int JUDGE_SEQ { get; set; }

        [Display(Name = "판정")]
        public string JUDGE_CD { get; set; }

        [Range(1, Int32.MaxValue)]
        [Display(Name = "판정수량")]
        public int JUDGE_QTY { get; set; }

        [StrapVisible(false,false,false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [Display(Name = "출고창고")]
        public string TO_WH_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "판정상태")]
        public string JUDGE_STATUS { get; set; }

        //2022.02.10 추가
        //부적합 양품 등록시 신규 식별표 발행 여부
        // N 인 경우 신규 식별표 발행 안함,팝업창에서 확인 ,신규 식별표 발행 여부 팝업 호출
        // Y 인 경우 신규 식별표 생성 ,신규 식별표 발행
        [StrapVisible(false, false, false)]
        public string JUDGE_NEW_PRINT_YN { get; set; } = "Y";



        [ReadOnly(true)]
        [StrapDisableParam]
        [Display(Name = "신규식별표")]
        public string HU_NO { get; set; }


    }
}
