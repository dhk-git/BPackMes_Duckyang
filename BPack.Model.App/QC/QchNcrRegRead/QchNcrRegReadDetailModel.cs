using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.QC.QchNcrRegRead
{
    public class QchNcrRegReadDetailModel: ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string NCH_NO { get; set; }


        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string NCD_NO { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int JUDGE_SEQ { get; set; }

        [ReadOnly(true)]
        [Display(Name = "등록일자")]
        public DateTime NCH_DT { get; set; }


        [ReadOnly(true)]
        [Display(Name = "부적합등록유형")]
        public string NCH_TYPE { get; set; }

        [ReadOnly(true)]
        [Display(Name = "발생창고")]
        public string FROM_WH_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "부적합창고")]
        public string NCR_WH_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "부적합등록상태")]
        public string NCH_STATUS { get; set; }

        [ReadOnly(true)]
        [Display(Name = "참조문서")]
        public string REF_DOC_TYPE { get; set; }

        [ReadOnly(true)]
        [Display(Name = "참조문서번호")]
        public string REF_DOC_NO { get; set; }

        [ReadOnly(true)]
        [Display(Name = "불량유형")]
        public string DEFECT_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "판정")]
        public string JUDGE_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "판정수량")]
        public int JUDGE_QTY { get; set; }

        [ReadOnly(true)]
        [Display(Name = "출고창고")]
        public string TO_WH_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "판정상태")]
        public string JUDGE_STATUS { get; set; }

        [ReadOnly(true)]
        [Display(Name = "신규식별표")]
        public string NEW_HU_NO { get; set; }

        [ReadOnly(true)]
        [Display(Name = "신규바코드")]
        public string NEW_BARCODE_TEXT { get; set; }



    }
}
