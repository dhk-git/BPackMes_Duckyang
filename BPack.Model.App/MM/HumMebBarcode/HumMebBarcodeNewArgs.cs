using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumMebBarcode
{
    public class NewHumMebBarcodeArgs : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string HU_MEB_TYPE { get; set; }
        //public string CASE_NO { get; set; }
        public string ORDER_NO { get; set; }

        //public string LOT { get; set; }

        public DateTime WORK_DT { get; set; }
        public string ITEM_CD { get; set; }

        public DateTime? PACK_DATE { get; set; }

        public DateTime? SHIP_DATE { get; set; }

        public int INIT_QTY { get; set; }


    }
}
