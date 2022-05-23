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

namespace BPack.Model.App.MM.PurInboundHist
{
    public class PurInboundHistModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "가입고일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? CREATE_DTTM { get => base.CREATE_DTTM; set => base.CREATE_DTTM = value; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "거래처")]
        public string BP_NM { get; set; }
        [Display(Name = "납입카드번호")]
        public string DO_NO { get; set; }
        [Display(Name = "가입고번호(MES)")]
        public string PIH_NO { get; set; }
        [Display(Name = "가입고번호(ERP)")]
        public string PRCP_NO { get; set; }
        [Display(Name = "PID번호")]
        [StrapVisible(false, false, false)]
        public string PID_NO { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "규격")]
        [StrapVisible(false, false, false)]
        public string ITEM_SPEC { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_2 { get; set; }
        [Display(Name = "수량")]
        [StrapGridSummary(Sum =true)]
        [StrapGridGroupSummary(Sum = true)]
        public decimal ITEM_QTY { get; set; }
        [Display(Name = "입고상태")]
        public string INHU_IN_STATUS { get; set; }
        [Display(Name = "입고완료일시")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public DateTime? IN_DTTM { get; set; }
        [Display(Name = "수입검사상태")]
        [StrapVisible(false, false, false)]
        public string INHU_INSP_STATUS { get; set; }
        [Display(Name = "식별표번호")]
        public string HU_NO { get; set; }
        [Display(Name = "바코드번호")]
        public string HU_BARCODE { get; set; }
    }
}
