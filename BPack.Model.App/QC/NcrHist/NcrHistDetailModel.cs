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
    public  class NcrHistDetailModel : ModelBase_CommonColumns
    {
        [Display(Name = "부적합번호")]
        [ReadOnly(true)]
        public string NCR_NO { get; set; }

        [Display(Name = "부적합판정")]
        public string NCR_JUDGE { get; set; }
        
        [Display(Name = "식별표번호")]
        [ReadOnly(true)]
        public string HU_NO { get; set; }

        [Display(Name = "판정수량")]
        [ReadOnly(true)]
        public decimal NCR_QTY { get; set; }

        [Display(Name = "처리완료여부")]
        [ReadOnly(true)]
        public string TRT_FG { get; set; }

        [Display(Name = "재입고 창고코드")]
        [ReadOnly(true)]
        public string WH_CD { get; set; }
        [Display(Name = "재입고 창고")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string WH_NM { get; set; }
        [Display(Name = "재입고 위치코드")]
        [ReadOnly(true)]
        public string LOC_CD { get; set; }
        [Display(Name = "재입고 위치")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string LOC_NM { get; set; }
        [Display(Name = "반품 거래처코드")]
        [ReadOnly(true)]
        public string BP_CD { get; set; }
        [Display(Name = "반품 거래처")]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string BP_NM { get; set; }

        [Display(Name = "재투입 라우팅번호")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "재투입 공정")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public int OPER { get; set; }
        [Display(Name = "재투입 작업장코드")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }





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
