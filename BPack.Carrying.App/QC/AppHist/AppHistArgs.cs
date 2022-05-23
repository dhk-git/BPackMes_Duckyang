using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.AppHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class AppHistArgs : ArgsBase
    {
        public AppHistModelArgs AppHistModelArgs { get; set; } = new AppHistModelArgs();
    }
}
