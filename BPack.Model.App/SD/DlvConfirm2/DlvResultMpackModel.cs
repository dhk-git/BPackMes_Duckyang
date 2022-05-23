using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvResultMpackModel
    {
        [Display(Name = "중포장")]
        public string PACK_NO { get; set; }

        [Display(Name = "부품 LOT")]
        public string PART_LOT { get; set; }

        [Display(Name = "포장일자")]
        public string PACK_DATE { get; set; }

        [Display(Name = "선적일자")]
        public string SHIP_DATE { get; set; }
    }
}
