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

namespace BPack.Model.App.QC.QchNcrRegRead
{
    public class QchNcrRegReadHeaderModel : ModelBase_CommonColumns
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
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }

        [ReadOnly(true)]
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }

        [ReadOnly(true)]
        [Display(Name = "품목유형")]
        public string ITEM_TYPE_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "등록일")]
        public DateTime NCH_DT { get; set; }

        [StrapGridSummary(Sum = true)]
        [StrapGridGroupSummary(Sum = true)]
        [ReadOnly(true)]
        [Display(Name = "불량수량")]
        public int DEFECT_QTY { get; set; }

        [StrapGridSummary(Sum = true)]
        [StrapGridGroupSummary(Sum = true)]
        [ReadOnly(true)]
        [Display(Name = "판정수량")]
        public int JUDGE_QTY { get; set; }

        [StrapGridSummary(Sum = true)]
        [StrapGridGroupSummary(Sum = true)]
        [ReadOnly(true)]
        [Display(Name = "양품 판정")]
        public int OK_JUDGE_QTY { get; set; }

        [StrapGridSummary(Sum = true)]
        [StrapGridGroupSummary(Sum = true)]
        [ReadOnly(true)]
        [Display(Name = "폐기 판정")]
        public int NG_JUDGE_QTY { get; set; }



        [StrapGridSummary(Sum = true)]
        [StrapGridGroupSummary(Sum = true)]
        [ReadOnly(true)]
        [Display(Name = "미처리수량")]
        public int REMAIN_QTY { get; set; }
    }
}
