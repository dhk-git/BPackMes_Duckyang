using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.EssInspection.Models
{
    public class EssLotDetailModel
    {
        [DisplayName("D_출고일")]
        public string D_DATE { get; set; }

        [DisplayName("D_주소")]
        public string D_ADDRESS { get; set; }

        [DisplayName("D_납품번호")]
        public string D_DOH_NO { get; set; }

        [DisplayName("D_품번")]
        public string D_PARD_CD { get; set; }

        [DisplayName("D_품명")]
        public string D_PARD_NM { get; set; }

        [DisplayName("D_LOTNO")]
        public string D_LOTNO { get; set; }

        public List<EssEolModel> EssEolModels { get; set; } = new List<EssEolModel>();
        public List<EssHousingModel> EssHousingModels { get; set; } = new List<EssHousingModel>();
        public List<EssCellModel> EssCellModels { get; set; } = new List<EssCellModel>();
    }
}
