using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.PC.WorkOrder
{
    public class RouteMtrlModel : ModelBase_CommonColumns
    {
        [Display(Name = "라우팅번호")]
        public string ROUTE_NO { get; set; }

        [Display(Name = "공정")]
        public int OPER { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [Display(Name = "소요량")]
        public float OPER_QTY { get; set; }

        [Display(Name = "소요단위")]
        public string OPER_UNIT { get; set; }

        [Display(Name = "백플러시여부")]
        public bool IS_BACKFLUSH { get; set; }

        [Display(Name = "자재투입방식")]
        public string MAT_INPUT_TYPE { get; set; }

    }
}
