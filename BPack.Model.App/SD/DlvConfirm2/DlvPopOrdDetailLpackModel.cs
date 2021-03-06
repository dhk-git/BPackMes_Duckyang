using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvConfirm2
{
    public class DlvPopOrdDetailLpackModel
    {
        [ReadOnly(true)]
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [ReadOnly(true)]
        [Display(Name = "대표 대포장")]
        public string PACK_NO { get; set; }
        //[Display(Name = "중포장")]
        //public string M_PACK_NO { get; set; }


        //[Display(Name = "부품 LOT")]
        //public string PART_LOT { get; set; }

        [ReadOnly(true)]
        [Display(Name = "포장일")]
        public string PACK_DATE { get; set; }

        [ReadOnly(true)]
        [Display(Name = "선적일")]
        public string SHIP_DATE { get; set; }
    }
}
