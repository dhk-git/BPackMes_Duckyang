using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.NcrRegJudge;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class NcrRegJudgeArgs : ArgsBase
    {
        public NcrRegJudgeModelArgs NcrRegJudgModelArgs { get; set; } = new NcrRegJudgeModelArgs();
    }
}
