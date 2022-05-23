using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class dy_LpackModel
    {

        public string HEADER_TITLE_01 { get; set; }
        public string HEADER_TITLE_02 { get; set; }

        public string HEADER_TITLE_03 { get; set; }

        public string SHIP_MODE { get; set; }

        public string PACKING_DATE { get; set; }

        public string ORDER_NO { get; set; }

        public string CASE_NO { get; set; }
        public string BARCODE_TEXT { get; set; }

        public List<dy_LpackDetailModel> LpackDetailModel { get; set; }
    }
}
