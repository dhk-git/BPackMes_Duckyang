using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.HandlingUnit.Models
{
    public class HandlingUnitModelArgs : ModelArgsBase
    {
        public List<string> Select_HuNoList { get; set; }
        public List<string> Select_BarcodeNoList { get; set; }
        public List<string> Select_NcrNoList { get; set; }
        public string NcrReportType { get; set; }
        public List<string> Select_InspNoList { get; set; }

        public List<String>Select_MebBarcodeList { get; set; }
    }
}
