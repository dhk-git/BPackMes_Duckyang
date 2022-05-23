using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.EssInspection.Models
{
    public class EssInspectionModelArgs : ModelArgsBase
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public string DRH_NO { get; set; }

        public string HU_NO { get; set; }

        public string BARCODE_TEXT { get; set; }
    }
}
