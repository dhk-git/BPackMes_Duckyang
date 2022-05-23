using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.QC.NcrRegJudge
{
    public class NcrRegJudgeConfirmModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }

        public string NCD_NO_KEY { get; set; }

        public int JUDGE_SEQ_KEY { get; set; }

        public string JUDGE_STATUS { get; set; }
    }
}
