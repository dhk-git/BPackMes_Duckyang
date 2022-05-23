using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.PurchseOrder.Models
{
    public class PoModel
    {
        public string POH_NO { get; set; }
        public string BP_CD { get; set; }
        public string BP_NM { get; set; }
        public DateTime POH_DT { get; set; }
        public List<PoItemModel> PoItemModels { get; set; }

        public string COMP_CD { get; set; }
        public string COMP_NM { get; set; }
        public string PLANT_CD { get; set; }
        public string PLANT_NM { get; set; }
        public string ADDR { get; set; }
        public string TEL { get; set; }
        public string TEL1 { get; set; }
        public string REMARK { get; set; }
    }
}
