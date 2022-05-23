using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WoeRsltInfo
{
    public class WoeRsltInfoModel : ModelBase_CommonColumns
    {
        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }

        [Display(Name = "라우팅번호")]
        public string ROUTE_NO { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "차종코드")]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "차종명")]
        public string ITEM_GR_1_NM { get; set; }

        [Display(Name = "종료일자")]
        public DateTime CLOSE_DT { get; set; }

        [Display(Name = "지시일자")]
        public DateTime WO_DT { get; set; }

        [Display(Name = "근무조코드")]
        public string SHIFT_CD { get; set; }

        [Display(Name = "지시수량")]
        public float WOR_QTY { get; set; }

        [Display(Name = "진행상태(작업지시)")]
        public string WO_STATUS { get; set; }

        [Display(Name = "공정")]
        public int OPER { get; set; }

        [Display(Name = "공정설명")]
        public string OPER_DESC { get; set; }

        [Display(Name = "작업장코드")]
        public string WC_CD { get; set; }

        [Display(Name = "금형코드")]
        public string MOLD_CD { get; set; }

        [Display(Name = "금형명")]
        public string MOLD_NM { get; set; }

        [Display(Name = "공정진행상태")]
        public string WOD_STATUS { get; set; }

        [Display(Name = "I/F 여부")]
        public string IS_IF { get; set; }

        [Display(Name = "실적수량")]
        public float RST_QTY { get; set; }

        [Display(Name = "앙품수량")]
        public float OK_QTY { get; set; }

        [Display(Name = "불량수량")]
        public float NG_QTY { get; set; }

    }
}
