using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvResultLpackModel
    {
        [Display(Name ="대포장번호")]
        public string PACK_NO { get; set; }

        [Display(Name = "중포장번호")]
        public string M_PACK_NO { get; set; }

        [Display(Name = "부품 LOT")]
        public string PART_LOT { get; set; }

        
        [Display(Name = "CASE NO")]
        public string CASE_NO { get; set; }

        [Display(Name = "ORDER NO")]
        public string ORDER_NO { get; set; }

        [Display(Name = "품번")]
        public string PART_NO { get; set; }

        [Display(Name = "수량")]
        public int QTY { get; set; }

        [Display(Name = "LOT")]
        public string LOT { get; set; }

        [Display(Name = "작업일")]
        public string WORK_DATE { get; set; }

        [Display(Name = "포장일자")]
        public string PACK_DATE { get; set; }

        [Display(Name = "선적일자")]
        public string SHIP_DATE { get; set; }
    }
}
