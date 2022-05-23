using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.SD.DlvOrderVsResult
{
    public class DlvOrderVsResultModel
    {
        public DateTime DT { get; set; }
        public string COMP_CD { get; set; }
        public string BP_CD { get; set; }
        public string BP_NM { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public string ITEM_GR_1 { get; set; }
        public string CLS { get; set; }
        public string CLS_NAME { get; set; }
        public decimal? QTY { get; set; }
    }
}
