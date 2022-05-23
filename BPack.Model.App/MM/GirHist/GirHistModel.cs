using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirHist
{
    public class GirHistModel : ModelBase
    {
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "수불기준일")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime GIR_DT { get; set; }
        [Display(Name = "생성일시")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy HH:mm}")]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "창고코드")]
        [StrapVisible(false, false, false)]
        public string WH_CD { get; set; }
        [Display(Name = "창고")]
        public string WH_NM { get; set; }
        [Display(Name = "수불유형")]
        public string GIR_TYPE_CD { get; set; }
        [Display(Name = "FROM창고코드")]
        [StrapVisible(false, false, false)]
        public string FROM_WH_CD { get; set; }
        [Display(Name = "FROM창고")]
        public string FROM_WH_NM { get; set; }
        [Display(Name = "TO창고코드")]
        [StrapVisible(false, false, false)]
        public string TO_WH_CD { get; set; }
        [Display(Name = "TO창고")]
        public string TO_WH_NM { get; set; }
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "입고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal? GR_QTY { get; set; }
        [Display(Name = "출고수량")]
        [StrapGridSummary(Sum = true)]
        public decimal? GI_QTY { get; set; }
        [Display(Name = "참조문서유형")]
        [StrapLookUpEditCode(CoreOrApp.Core, "DOC_TYPE")]
        public string REF_DOC_TYPE { get; set; }
        [Display(Name = "참조문서번호")]
        public string REF_DOC_NO { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
        [Display(Name = "비고")]
        public string REMARK { get; set; }
        [Display(Name = "생성자")]
        [StrapLookUpEditAllUsers]
        public string CREATE_USER_ID { get; set; }
    }
}
