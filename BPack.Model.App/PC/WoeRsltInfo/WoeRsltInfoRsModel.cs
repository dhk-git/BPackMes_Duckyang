using BPack.Common.Model;
using System;
using System.ComponentModel.DataAnnotations;
using BPack.Model.Annotation.Common;


namespace BPack.Model.App.PC.WoeRsltInfo
{
    public class WoeRsltInfoRsModel : ModelBase_CommonColumns
    {
        [Display(Name = "생산실적번호")]
        public string RST_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "작업지시번호")]
        public string WO_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "라우팅번호")]
        public string ROUTE_NO { get; set; }

        [StrapVisible(false, false, false)]
        [Display(Name = "공정")]
        public int OPER { get; set; }

        [Display(Name = "실적수량")]
        public float RST_QTY { get; set; }

        [Display(Name = "양품수량")]
        public float OK_QTY { get; set; }

        [Display(Name = "불량수량")]
        public float NG_QTY { get; set; }

        [Display(Name = "LOT번호")]
        public string LOT_NO { get; set; }

        [Display(Name = "진행상태")]
        public string RST_STATUS { get; set; }

    }
}
