using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.EssInspection.Models
{
    public class EssLotHeaderModel
    {

        [DisplayName("T_검사성적서")]
        public string T_TITLE { get; set; }

        [DisplayName("T_출고일")]
        public string T_DATE { get; set; }

        [DisplayName("T_주소")]
        public string T_ADDRESS { get; set; }

        [DisplayName("T_납품번호")]
        public string T_DOH_NO { get; set; }

        [DisplayName("T_품번")]
        public string T_PART_CD { get; set; }

        [DisplayName("T_품명")]
        public string T_PART_NM { get; set; }

        [DisplayName("T_LOTNO")]
        public string T_LOTNO { get; set; }

        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }
        public string HU_NO { get; set; }

        public string DRH_NO { get; set; }

        public string BARCODE_TEXT { get; set; }
        public List<EssLotDetailModel> detailModels { get; set; } = new List<EssLotDetailModel>();
    }
}
