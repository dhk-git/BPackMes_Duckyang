using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.EssInspection.Models
{
    public class EssHousingModel
    {
        public int SEQ { get; set; }

        public string P_LOT_NO { get; set; }
        public string HOUSING_BARCODE { get; set; }

        public string L_T_PCB { get; set; }

        public string L_B_PCB { get; set; }

        public string R_T_PCB { get; set; }

        public string R_B_PCB { get; set; }
    }
}
