using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.NcrHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class NcrHistArgs : ArgsBase
    {
        public NcrHistModelArgs NcrHistModelArgs { get; set; } = new NcrHistModelArgs();
    }
}
