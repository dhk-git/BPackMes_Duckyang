using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.NcrRegJudge
{
    public class NcrRegJudgeModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_dt { get; set; }
        public DateTime Select_Main_End_dt { get; set; }

        public string Select_Main_Judge_Result { get; set; }

        public string NCD_NO_KEY { get; set; }

        public string JUDGE_RESULT { get; set; }

        /// <summary>
        /// 미판정 수량(잔량)
        /// </summary>
        public int REMAIN_QTY { get; set; }

        /// <summary>
        /// 부적합 수량
        /// </summary>
        public int DEFECT_QTY { get; set; }

        //2022.02.10 추가
        //부적합 양품 등록시 신규 식별표 발행 여부
        // N 인 경우 신규 식별표 발행 안함,팝업창에서 확인 ,신규 식별표 발행 여부 팝업 호출
        // Y 인 경우 신규 식별표 생성 ,신규 식별표 발행
        public string JUDGE_NEW_PRINT_YN { get; set; }

        //부적합 품목 상세 현재 신규 식별표 발행 여부 상태
        //Y는 기본
        //N인 경우에는 양품은 1개밖에 못하는 로직 체크
        public string JUDGE_HU_STATUS { get; set; }

        public string PRE_HU_NO { get; set; }

    }
}
