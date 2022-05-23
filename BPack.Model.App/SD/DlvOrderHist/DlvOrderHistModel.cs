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

namespace BPack.Model.App.SD.DlvOrderHist
{
    public class DlvOrderHistModel : ModelBase
    {

        [Display(Name = "출하일자")]
        public DateTime DLV_DT { get; set; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "거래처")]
        public string BP_NM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "제품군")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "납품수량")]
        public string DLV_QTY { get; set; }
        [Display(Name = "반품수량")]
        public string RETURN_QTY { get; set; }
        [Display(Name = "납품완료수량")]
        public string CLOSE_QTY { get; set; }
        [Display(Name = "단위")]
        public string BASE_UNIT { get; set; }

    }
}
