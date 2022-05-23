using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.DlvOrder.Models
{
    public class DlvOrderDetailModel
    {
        public string DOD_NO { get; set; }
        public string DOH_NO { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string ITEM_CD { get; set; }
        public string ITEM_NM { get; set; }
        public string ITEM_GR_1 { get; set; }
        public decimal DOD_QTY { get; set; }
        public string BASE_UNIT { get; set; }
        public string REMARK { get; set; }
        public List<ReservedHuModel> ReservedHuModels { get; set; }
    }
}
