using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.QC.NcrReg
{
    public class NcrRegHeaderConfirmModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string NCH_NO_KEY { get; set; }

        public string NCH_STATUS { get; set; }
    }
}
