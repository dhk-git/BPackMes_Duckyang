using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.MaterialRequest
{
    class MaterialRequestDocModelArgs : ModelArgsBase
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public string MRH_NO { get; set; }
    }
}
