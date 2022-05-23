using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeResultBatch
{
    public class WoeResultBatchBpModel
    {
        public string CrudCls { get; set; }
        public string LANG_CODE { get; set; }
        public string USER_ID { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string WC_CD { get; set; }
        public string WO_NO { get; set; }
        public string ROUTE_NO { get; set; }
        public int OPER { get; set; }
        public string SEMI_HU_NO { get; set; }
        public string SEMI_SEPERATOR { get; set; }
        public int PROD_QTY { get; set; }
        public string REMARK { get; set; }
    }
}
