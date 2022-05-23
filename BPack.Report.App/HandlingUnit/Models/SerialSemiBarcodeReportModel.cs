using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class SerialSemiBarcodeReportModel
    {
        public string HU_NO_KEY { get; set; }
        public string HU_NO { get; set; }
        public string PARENT_HU_NO { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string ITEM_CD { get; set; }
        public string HU_TYPE { get; set; }
        public decimal HU_INIT_QTY { get; set; }
        public decimal HU_STOCK_QTY { get; set; }
        public string IS_BLOCKED { get; set; }
        public DateTime BLOCK_DTTM { get; set; }
        public string BLOCK_DESC { get; set; }
        public DateTime WORK_DT { get; set; }
        public string LOT_NO { get; set; }
        public string BARCODE_NO { get; set; }
        public string HU_BARCODE { get; set; }
        public string REF_NO { get; set; }
        public string HU_STATUS { get; set; }
        public string REMARK { get; set; }
        public string DEL_FG { get; set; }
        public DateTime CREATE_DTTM { get; set; }
        public DateTime MODIFY_DTTM { get; set; }
        public string CREATE_USER_ID { get; set; }
        public string MODIFY_USER_ID { get; set; }
        public string BARCODE_KIND { get; set; }
        public string BARCODE_FULL_NO { get; set; }
        public string BARCODE_LENGTH { get; set; }
        public string ITEM_NM { get; set; }
        public string ITEM_GR_1 { get; set; }
        public string ALC_CD { get; set; }

        public string HU_BARCODE_WITHOUT_ITEM_CD { get; set; } //품번제거한 바코드번호 
    }
}
