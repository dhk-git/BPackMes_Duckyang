using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumEmptyLabel
{
    public class CreatingBarcodeModel : ModelBase_CommonColumns
    {
        public string BARCODE_KIND { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string WC_CD { get; set; }
        public string ITEM_CD { get; set; }
        public DateTime WORK_DT { get; set; }
        public string LOT_NO { get; set; }
        public decimal HU_QTY { get; set; }
        public int CREATING_QTY { get; set; }
        public string DEVICE_ID { get; set; }
        public string BP_CD { get; set; }
    }
}
