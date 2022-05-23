using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.DlvOrder.Models
{
    public class DlvOrderModel
    {
        public int ORDER_SEQ { get; set; }
        public string DOH_NO { get; set; }
        public string COMP_CD { get; set; }
        public string BP_CD { get; set; }
        public string BP_NM { get; set; }
        public string ADDR { get; set; }
        public string TEL { get; set; }
        public string CEO_NM { get; set; }
        public string CORP_NO { get; set; }
        public string REG_NO { get; set; }
        public DateTime DOH_DT { get; set; }
        public string BARCODE_TEXT { get; set; }
        public string REMARK { get; set; }
        public List<DlvOrderDetailModel> DlvOrderDetailModels { get; set; }
    }
}
